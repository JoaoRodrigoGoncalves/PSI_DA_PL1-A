using RestGest.GestaoRestaurantes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGestaoRestaurantes : Form
    {
        public Restaurante returnRestaurante;

        private Form FormBack;
        private RestGestContainer databaseContainer;
        private bool FormGestao;

        public FormGestaoRestaurantes(Form formBack, bool gestao)
        {
            InitializeComponent();
            this.FormBack = formBack;
            this.FormGestao = gestao;
            activeFuntion(this.FormGestao);
        }

        private void activeFuntion(bool active)
        {
            Adicionar_BTN.Enabled = active;
            Editar_BTN.Enabled = active;
            Remover_BTN.Enabled = active;
            Selecionar_BTN.Visible = !active;
            Selecionar_BTN.Enabled = !active;
        }

        private void FormGestaoRestaurantes_Shown(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(ReloadDataGridView);
            loadingThread.Start();
        }

        private void ReloadDataGridView()
        {
            databaseContainer = new RestGestContainer();


            restaurantes_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                restaurantes_DataGridView.Rows.Clear();
                foreach (Restaurante restaurante in databaseContainer.Restaurantes.Where(x => x.Ativo))
                    restaurantes_DataGridView.Rows.Add(buildDataGridRow(restaurante));

                if (restaurantes_DataGridView.Rows.Count > 0)
                    restaurantes_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private string[] buildDataGridRow(Restaurante restaurante)
        {
            int count_funcionarios = databaseContainer.Pessoas.OfType<Trabalhador>().Where(t => t.RestauranteId == restaurante.Id).Count();
            string[] row = { restaurante.Id.ToString(), restaurante.Nome, restaurante.Morada.ToString(), "0", count_funcionarios.ToString() };
            return row;
        }

        private void Adicionar_BTN_Click(object sender, EventArgs e)
        {
            new FormRegistoRestaurante().ShowDialog();
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
            restaurantes_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Restaurante> restaurantes = databaseContainer.Restaurantes.Where(restaurante => restaurante.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper()) && restaurante.Ativo == true).ToList();

                restaurantes_DataGridView.Rows.Clear();
                foreach (Restaurante restaurante in restaurantes)
                    restaurantes_DataGridView.Rows.Add(buildDataGridRow(restaurante));

                if (restaurantes_DataGridView.Rows.Count > 0)
                    restaurantes_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void FormGestaoRestaurantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
        }

        private void restaurantes_DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = restaurantes_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                restaurantes_DataGridView.ClearSelection();
                restaurantes_DataGridView.Rows[hit.RowIndex].Selected = true;
                //Filtra o tipo de ação 
                if (this.FormGestao)
                    Editar_BTN_Click(sender, e);
                else
                    Selecionar_BTN_Click(sender, e);
            }
        }

        private void Editar_BTN_Click(object sender, EventArgs e)
        {
            if (restaurantes_DataGridView.SelectedRows.Count == 1)
            {
                int row = restaurantes_DataGridView.SelectedRows[0].Index;
                int idRestaurante = int.Parse(restaurantes_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormEdicaoRestaurante(idRestaurante).ShowDialog();
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
            if (restaurantes_DataGridView.SelectedRows.Count == 1)
            {
                string nome = restaurantes_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show("Tem a certeza que pertende remover o restaurante \"" + nome + "\"?", "Remover restaurante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int restaurante_id = int.Parse(restaurantes_DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        Restaurante restauranteRemover = databaseContainer.Restaurantes.Find(restaurante_id);
                        if (restauranteAssociado(restaurante_id))
                        {
                            restauranteRemover.Ativo = false;
                        }
                        else
                        {
                            databaseContainer.Restaurantes.Remove(restauranteRemover);
                        }
                        databaseContainer.SaveChanges();
                    }catch(Exception)
                    {
                        MessageBox.Show("Uncommon error found!\nCall system administration...", "Restaurant Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //Valida se o restaurante que for pasado tem alguma associação
        private bool restauranteAssociado(int restaurante_id)
        {
            bool result = false;

            result = databaseContainer.Pedidos.Where(p => p.RestauranteId == restaurante_id).Count() > 0;
            result = databaseContainer.ItemsMenus.Where(i => i.Restaurante.Any(r => r.Id == restaurante_id)).Count() > 0;
            result = databaseContainer.Pessoas.OfType<Trabalhador>().Where(t => t.RestauranteId == restaurante_id).Count() > 0;

            return  result;
        }

        private void LimparFiltro_BTN_Click(object sender, EventArgs e)
        {
            filtrar_TextBox.Clear();
            ReloadDataGridView();
        }

        private void Selecionar_BTN_Click(object sender, EventArgs e)
        {
            if (restaurantes_DataGridView.SelectedRows.Count == 1)
            {
                int row = restaurantes_DataGridView.SelectedRows[0].Index;
                int idRestaurante = int.Parse(restaurantes_DataGridView.Rows[row].Cells[0].Value.ToString());
                this.returnRestaurante = databaseContainer.Restaurantes.Find(idRestaurante);
                this.Close();
            }
        }

        private void FormGestaoRestaurantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormBack.Show();
        }

        private void Produtos_BTN_Click(object sender, EventArgs e)
        {
            if(restaurantes_DataGridView.SelectedRows.Count == 1)
            {
                int row = restaurantes_DataGridView.SelectedRows[0].Index;
                int idRestaurante = int.Parse(restaurantes_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormGestaoProdutos(idRestaurante).ShowDialog();
            }
        }
    }
}
