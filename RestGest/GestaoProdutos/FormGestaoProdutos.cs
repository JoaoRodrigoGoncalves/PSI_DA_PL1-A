using RestGest.GestaoRestaurantes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGestaoProdutos : Form
    {
        private RestGestContainer databaseContainer;
        private int idRestauranteFiltro = -1;
        private Form FormBack;

        public FormGestaoProdutos(Form form_back)
        {
            InitializeComponent();
            this.FormBack = form_back;
        }

        public FormGestaoProdutos(Form form_back, int idRestaurante)
        {
            // Iniciar filtro por restaurante
            InitializeComponent();
            this.FormBack = form_back;
            idRestauranteFiltro = idRestaurante;
        }

        private void FormGestaoProdutos_Shown(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(ReloadDataGridView);
            loadingThread.Start();
        }

        private void ReloadDataGridView()
        {
            databaseContainer = new RestGestContainer();

            produtos_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                produtos_DataGridView.Rows.Clear();
                foreach (ItemMenu item in databaseContainer.ItemsMenus)
                {
                    string[] row = { item.Id.ToString(), item.Ativo.ToString(), item.Nome, item.Categoria.Nome, item.Preco + "€" };
                    produtos_DataGridView.Rows.Add(row);
                }


                if (produtos_DataGridView.Rows.Count > 0)
                    produtos_DataGridView.Rows[0].Selected = true;

                filtroRestaurante_ComboBox.Items.Clear();
                filtroRestaurante_ComboBox.Items.Add("(todos)");
                foreach (Restaurante restaurante in databaseContainer.Restaurantes)
                {
                    filtroRestaurante_ComboBox.Items.Add(restaurante);
                }

                if(idRestauranteFiltro == -1)
                {
                    filtroRestaurante_ComboBox.SelectedIndex = 0;
                }
                else
                {
                    filtroRestaurante_ComboBox.SelectedItem = databaseContainer.Restaurantes.Find(idRestauranteFiltro);
                    filtrar_BTN_Click(null, null);
                }


                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void Adicionar_BTN_Click(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
            if (filtrar_TextBox.Text.Length > 0)
            {
                filtrar_BTN_Click(sender, e);
            }
            else
            {
                ReloadDataGridView();
            }
        }

        private void filtrar_BTN_Click(object sender, EventArgs e)
        {
            produtos_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<ItemMenu> Itens = new List<ItemMenu>();
                
                if(filtroRestaurante_ComboBox.SelectedIndex == 0)
                {
                    Itens = databaseContainer.ItemsMenus.Where(prato => prato.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper())).ToList();
                }
                else
                {
                    if(filtrar_TextBox.Text.Length > 0)
                    {
                        Itens = databaseContainer.ItemsMenus.Where(prato =>
                                    prato.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper()) &&
                                    prato.Restaurante.Any(r => r.Nome == filtroRestaurante_ComboBox.Text)
                                    ).ToList();
                    }
                    else
                    {
                        Itens = databaseContainer.ItemsMenus.Where(prato =>
                                    prato.Restaurante.Any(r => r.Nome == filtroRestaurante_ComboBox.Text)
                                    ).ToList();
                    }
                }
                
                produtos_DataGridView.Rows.Clear();
                foreach (ItemMenu item in Itens.Where(p => p.Restaurante.Contains(filtroRestaurante_ComboBox.SelectedItem)))
                {
                    string[] row = { item.Id.ToString(), item.Ativo.ToString(), item.Nome, item.Categoria.Nome, item.Preco + "€" };
                    produtos_DataGridView.Rows.Add(row);
                }

                if (produtos_DataGridView.Rows.Count > 0)
                    produtos_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void FormGestaoProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
            this.FormBack.Show();
        }

        private void produtos_DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = produtos_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                produtos_DataGridView.ClearSelection();
                produtos_DataGridView.Rows[hit.RowIndex].Selected = true;
                Editar_BTN_Click(sender, e);
            }
        }

        private void Editar_BTN_Click(object sender, EventArgs e)
        {
            if (produtos_DataGridView.SelectedRows.Count == 1)
            {
                int row = produtos_DataGridView.SelectedRows[0].Index;
                int idProduto = int.Parse(produtos_DataGridView.Rows[row].Cells[0].Value.ToString());
				
                new FormProduto(idProduto).ShowDialog();
                if (filtrar_TextBox.Text.Length > 0)
                {
                    filtrar_BTN_Click(sender, e);
                }
                else
                {
                    ReloadDataGridView();
                }
            }
        }

        private void Remover_BTN_Click(object sender, EventArgs e)
        {
            if (produtos_DataGridView.SelectedRows.Count == 1)
            {
                string nome = produtos_DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                if (MessageBox.Show("Tem a certeza que pertende remover o produto \"" + nome + "\"?", "Remover produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idProduto = int.Parse(produtos_DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    ItemMenu ProdutoRemover = databaseContainer.ItemsMenus.Find(idProduto);
                    if (itemMeneAssociado(idProduto))
                    {
                        ProdutoRemover.Ativo = false;
                    }
                    else
                    {
                        ProdutoRemover.Restaurante.Clear(); // Remover a associação com qualquer restaurante
                        databaseContainer.ItemsMenus.Remove(ProdutoRemover);
                    }
                    databaseContainer.SaveChanges();
                    if (filtrar_TextBox.Text.Length > 0)
                    {
                        filtrar_BTN_Click(sender, e);
                    }
                    else
                    {
                        ReloadDataGridView();
                    }
                }
            }
        }

        //Valida sem o produto tem associações
        private bool itemMeneAssociado(int idProduto)
        {
            bool result = false;

            result = databaseContainer.Pedidos.Where(p => p.ItemMenu.Any(x => x.Id == idProduto)).Count() > 0;

            return result;
        }

        private void LimparFiltro_BTN_Click(object sender, EventArgs e)
        {
            filtrar_TextBox.Clear();
            ReloadDataGridView();
        }
    }
}
