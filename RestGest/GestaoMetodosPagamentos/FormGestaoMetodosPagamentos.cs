using RestGest.GestaoMetodosPagamentos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGestaoMetodosPagamentos : Form
    {
        private RestGestContainer databaseContainer;

        public FormGestaoMetodosPagamentos()
        {
            InitializeComponent();
        }

        private void FormGestaoMetodosPagamentos_Shown(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(ReloadDataGridView);
            loadingThread.Start();
        }

        private void ReloadDataGridView()
        {
            databaseContainer = new RestGestContainer();

            Metodo_DataGridView.Invoke(new MethodInvoker(delegate
            {
                panel1.Visible = true;

                Metodo_DataGridView.Rows.Clear();
                foreach (MetodoPagamento metodos in databaseContainer.MetodosPagamento)
                {
                    string[] row = { metodos.Id.ToString(), metodos.Metodo, metodos.Ativo.ToString()};
                    Metodo_DataGridView.Rows.Add(row);
                }

                if (Metodo_DataGridView.Rows.Count > 0)
                    Metodo_DataGridView.Rows[0].Selected = true;

                panel1.Visible = false;
            }));
        }

        private void btnAddMedodoPagamento_Click(object sender, EventArgs e)
        {
            new RegistarMetodosPagamento().ShowDialog();
            ReloadDataGridView();
        }

        private void Metodo_DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = Metodo_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                Metodo_DataGridView.ClearSelection();
                Metodo_DataGridView.Rows[hit.RowIndex].Selected = true;
                btnEditMetodoPagamento_Click(sender, e);
            }
        }

        private void Metodo_DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = Metodo_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                Metodo_DataGridView.ClearSelection();
                Metodo_DataGridView.Rows[hit.RowIndex].Selected = true;
            }
        }

        private void btnEditMetodoPagamento_Click(object sender, EventArgs e)
        {
            if (Metodo_DataGridView.SelectedRows.Count == 1)
            {
                int row = Metodo_DataGridView.SelectedRows[0].Index;
                int idMetodo = int.Parse(Metodo_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormEdicaoMetodosPagamentos(idMetodo).ShowDialog();
                ReloadDataGridView();
            }
        }

        private void btnRemoveMetodoPagamento_Click(object sender, EventArgs e)
        {
            if (Metodo_DataGridView.SelectedRows.Count == 1)
            {
                string nomeMetodo = Metodo_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show("Tem a certeza que pertende remover este Método de Pagamento \"" + nomeMetodo + "\"?", "Remover Método de Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id_metodo = int.Parse(Metodo_DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    MetodoPagamento MetodoPagamentoARemover = databaseContainer.MetodosPagamento.OfType<MetodoPagamento>().First(Metodo => Metodo.Id == id_metodo);
                    databaseContainer.MetodosPagamento.Remove(MetodoPagamentoARemover);

                    databaseContainer.SaveChanges();
                    ReloadDataGridView();
                }
            }
        }

        private void FormGestaoMetodosPagamentos_FormClosing(object sender, EventArgs e)
        {
            databaseContainer.Dispose();
        }

        private void btnCleanFilterMetodosPagamentos_Click(object sender, EventArgs e)
        {
            tbFilterMetodosPagamentos.Text = "";
            ReloadDataGridView();
        }

        private void btnFilterMetodosPagamentos_Click(object sender, EventArgs e)
        {
            Metodo_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<MetodoPagamento> metodosPagamentos = databaseContainer.MetodosPagamento.OfType<MetodoPagamento>().Where(metodo => metodo.Metodo.ToUpper().Contains(tbFilterMetodosPagamentos.Text.ToUpper())).ToList();

                Metodo_DataGridView.Rows.Clear();
                foreach (MetodoPagamento metodo in metodosPagamentos)
                {
                    string[] row = { metodo.Id.ToString(), metodo.Metodo, metodo.Ativo.ToString()};
                    Metodo_DataGridView.Rows.Add(row);
                }

                if (Metodo_DataGridView.Rows.Count > 0)
                    Metodo_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }
    }
}