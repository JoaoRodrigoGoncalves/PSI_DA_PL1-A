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

        public FormGestaoProdutos()
        {
            InitializeComponent();
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
                    produtos_DataGridView.Rows.Add(buildDataGridRow(item));

                if (produtos_DataGridView.Rows.Count > 0)
                    produtos_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void Adicionar_BTN_Click(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
            ReloadDataGridView();
        }

        private void filtrar_BTN_Click(object sender, EventArgs e)
        {
            produtos_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<ItemMenu> Itens = databaseContainer.ItemsMenus.Where(prato => prato.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper())).ToList();

                produtos_DataGridView.Rows.Clear();
                foreach (ItemMenu item in Itens)
                    produtos_DataGridView.Rows.Add(buildDataGridRow(item));

                if (produtos_DataGridView.Rows.Count > 0)
                    produtos_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private string[] buildDataGridRow(ItemMenu item)
        {
            string[] row = { item.Id.ToString(), item.Ativo.ToString(), item.Nome, item.Categoria.Nome, item.Preco + "€" };
            return row;
        }

        private void FormGestaoProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
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

        private void produtos_DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = produtos_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                produtos_DataGridView.ClearSelection();
                produtos_DataGridView.Rows[hit.RowIndex].Selected = true;
            }
        }

        private void Editar_BTN_Click(object sender, EventArgs e)
        {
            if (produtos_DataGridView.SelectedRows.Count == 1)
            {
                int row = produtos_DataGridView.SelectedRows[0].Index;
                int idProduto = int.Parse(produtos_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormProduto(idProduto).ShowDialog();
                ReloadDataGridView();
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
                    if (databaseContainer.Pedidos.Where(p => p.ItemMenu.Any(x => x.Id == idProduto)).Count() > 0)
                    {
                        ProdutoRemover.Ativo = false;
                    }
                    else
                    {
                        ProdutoRemover.Restaurante.Clear(); // Remover a associação com qualquer restaurante
                        databaseContainer.ItemsMenus.Remove(ProdutoRemover);
                    }
                    databaseContainer.SaveChanges();
                    ReloadDataGridView();
                }
            }
        }

        private void LimparFiltro_BTN_Click(object sender, EventArgs e)
        {
            filtrar_TextBox.Clear();
            ReloadDataGridView();
        }
    }
}
