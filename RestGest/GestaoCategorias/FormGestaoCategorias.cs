using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestGest.GestaoCategorias
{
    public partial class FormGestaoCategorias : Form
    {
        public Categoria returnCategoriaMenu;
        private RestGestContainer databaseContainer;
        private bool FormGestao;
        private Form FormBack;

        public FormGestaoCategorias(Form formBack, bool gestao)
        {
            InitializeComponent();
            this.FormBack = formBack;
            this.FormGestao = gestao;
            activeFuntion(this.FormGestao);
        }
        private void FormGestaoCategorias_Shown(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(ReloadDataGridView);
            loadingThread.Start();
        }

        private void activeFuntion(bool active)
        {
            Adicionar_BTN.Enabled = active;
            Editar_BTN.Enabled = active;
            Remover_BTN.Enabled = active;
            Selecionar_BTN.Enabled = !active;
        }

        private void ReloadDataGridView()
        {
            databaseContainer = new RestGestContainer();


            categorias_menu_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                categorias_menu_DataGridView.Rows.Clear();

                List<Categoria> categorias = new List<Categoria>();

                if (this.FormGestao)
                    categorias = databaseContainer.Categorias.Where(categoria => categoria.Ativo == true).ToList();
                else
                    categorias = databaseContainer.Categorias.ToList();

                foreach (Categoria categoria in categorias)
                    categorias_menu_DataGridView.Rows.Add(buildDataGridRow(categoria));

                if (categorias_menu_DataGridView.Rows.Count > 0)
                    categorias_menu_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void filtrar_BTN_Click(object sender, EventArgs e)
        {
            categorias_menu_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Categoria> categorias = new List<Categoria>();

                if (this.FormGestao)
                    categorias = databaseContainer.Categorias.Where(categoria => categoria.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper()) && categoria.Ativo == true).ToList();
                else
                    categorias = databaseContainer.Categorias.Where(categoria => categoria.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper())).ToList();

                categorias_menu_DataGridView.Rows.Clear();
                foreach (Categoria categoria in categorias)
                    categorias_menu_DataGridView.Rows.Add(buildDataGridRow(categoria));

                if (categorias_menu_DataGridView.Rows.Count > 0)
                    categorias_menu_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private string[] buildDataGridRow(Categoria categoria)
        {
            string[] row = { categoria.Id.ToString(), categoria.Ativo.ToString(), categoria.Nome};
            return row;
        }

        private void categorias_menu_DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = categorias_menu_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                categorias_menu_DataGridView.ClearSelection();
                categorias_menu_DataGridView.Rows[hit.RowIndex].Selected = true;
                //Filtra o tipo de ação 
                if (this.FormGestao)
                    Editar_BTN_Click(sender, e);
                else
                    Selecionar_BTN_Click(sender, e);
            }
        }

        private void categorias_menu_DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = categorias_menu_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                categorias_menu_DataGridView.ClearSelection();
                categorias_menu_DataGridView.Rows[hit.RowIndex].Selected = true;
            }
        }

        private void Adicionar_BTN_Click(object sender, EventArgs e)
        {
            new FormCategoria().ShowDialog();
            ReloadDataGridView();
        }

        private void Editar_BTN_Click(object sender, EventArgs e)
        {
            if (categorias_menu_DataGridView.SelectedRows.Count == 1)
            {
                int row = categorias_menu_DataGridView.SelectedRows[0].Index;
                int idCategoria = int.Parse(categorias_menu_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormCategoria(idCategoria).ShowDialog();
                ReloadDataGridView();
            }
        }

        private void Remover_BTN_Click(object sender, EventArgs e)
        {
            if (categorias_menu_DataGridView.SelectedRows.Count == 1)
            {
                string nome = categorias_menu_DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                if (MessageBox.Show("Tem a certeza que pertende remover o restaurante \"" + nome + "\"?", "Remover restaurante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int categoria_id = int.Parse(categorias_menu_DataGridView.SelectedRows[0].Cells[0].Value.ToString());

                    Categoria categoriasRemover = databaseContainer.Categorias.Find(categoria_id);

                    if (databaseContainer.ItemsMenus.Where(p => p.CategoriaId == categoria_id).Count() > 0)
                    {
                        categoriasRemover.Ativo = false;
                    }
                    else
                    {
                        databaseContainer.Categorias.Remove(categoriasRemover);
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

        private void Selecionar_BTN_Click(object sender, EventArgs e)
        {
            if (categorias_menu_DataGridView.SelectedRows.Count == 1)
            {
                int row = categorias_menu_DataGridView.SelectedRows[0].Index;
                int idCategoria = int.Parse(categorias_menu_DataGridView.Rows[row].Cells[0].Value.ToString());
                this.returnCategoriaMenu = databaseContainer.Categorias.Find(idCategoria);
                this.Close();
            }
        }

        private void FormGestaoCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormBack.Show();
        }

        private void FormGestaoRestaurantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
        }

        private void LimparFiltro_BTN_Click_1(object sender, EventArgs e)
        {
            ReloadDataGridView();
        }
    }
}
