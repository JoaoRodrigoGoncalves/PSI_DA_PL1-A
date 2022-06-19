using RestGest.GestaoClientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGestaoClientes : Form
    {
        private RestGestContainer databaseContainer;
        private bool FormGestao;
        private Form FormBack;
        public Cliente returnCliente;

        public FormGestaoClientes(Form formBack, bool gestao)
        {
            InitializeComponent();
            this.FormBack = formBack;
            this.FormGestao = gestao;
            ActivationFuntion(this.FormGestao);
        }

        private void ActivationFuntion(bool active)
        {
            Adicionar_BTN.Enabled = active;
            Editar_BTN.Enabled = active;
            Remover_BTN.Enabled = active;
            Selecionar_BTN.Enabled = !active;
        }

        private void FormGestaoClientes_Shown_1(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(ReloadDataGridView);
            loadingThread.Start();
        }

        private void ReloadDataGridView()
        {
            databaseContainer = new RestGestContainer();

            Clientes_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                Clientes_DataGridView.Rows.Clear();
                foreach (Cliente cliente in databaseContainer.Pessoas.OfType<Cliente>().Where(clientes => clientes.Ativo == true))
                    Clientes_DataGridView.Rows.Add(buildDataGridRow(cliente));
                

                if (Clientes_DataGridView.Rows.Count > 0)
                    Clientes_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private string[] buildDataGridRow(Cliente cliente)
        {
            string[] row = { cliente.Id.ToString(), cliente.Nome, cliente.Telemovel, cliente.NumContribuinte, cliente.Morada.ToString() };
            return row;
        }

        private void Adicionar_BTN_Click(object sender, EventArgs e)
        {
            new FormCliente().ShowDialog();
            if (tbFiltrar.Text.Length > 0)
            {
                btnFiltrar_Click(sender, e);
            }
            else
            {
                ReloadDataGridView();
            }
        }

        private void Clientes_DataGridView_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = Clientes_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                Clientes_DataGridView.ClearSelection();
                Clientes_DataGridView.Rows[hit.RowIndex].Selected = true;
                //
                if (this.FormGestao)
                    Editar_BTN_Click_1(sender, e);
                else
                    Selecionar_BTN_Click(sender, e);
            }
        }

        private void Editar_BTN_Click_1(object sender, EventArgs e)
        {
            if (Clientes_DataGridView.SelectedRows.Count == 1)
            {
                int row = Clientes_DataGridView.SelectedRows[0].Index;
                int idCliente = int.Parse(Clientes_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormCliente(idCliente).ShowDialog();
                if (tbFiltrar.Text.Length > 0)
                {
                    btnFiltrar_Click(sender, e);
                }
                else
                {
                    ReloadDataGridView();
                }
            }
        }

        private void Selecionar_BTN_Click(object sender, EventArgs e)
        {
            if (Clientes_DataGridView.SelectedRows.Count == 1)
            {
                int row = Clientes_DataGridView.SelectedRows[0].Index;
                int idCliente = int.Parse(Clientes_DataGridView.Rows[row].Cells[0].Value.ToString());
                this.returnCliente = this.databaseContainer.Pessoas.OfType<Cliente>().Where(t => t.Id == idCliente).First();
                this.Close();
            }
        }
        
        private void Remover_BTN_Click_1(object sender, EventArgs e)
        {
            if (Clientes_DataGridView.SelectedRows.Count == 1)
            {
                string nome = Clientes_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show("Tem a certeza que pertende remover o cliente \"" + nome + "\"?", "Remover cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id_cliente = int.Parse(Clientes_DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    Cliente clienteARemover = databaseContainer.Pessoas.OfType<Cliente>().First(Cliente => Cliente.Id == id_cliente);
                    if (databaseContainer.Pedidos.Where(cliente => cliente.ClienteId == id_cliente).Count() > 0)
                    {
                        clienteARemover.Ativo = false;
                    }
                    else
                    {
                        databaseContainer.Pessoas.Remove(clienteARemover);
                    }

                    databaseContainer.SaveChanges();
                    if (tbFiltrar.Text.Length > 0)
                    {
                        btnFiltrar_Click(sender, e);
                    }
                    else
                    {
                        ReloadDataGridView();
                    }
                }
            }
        }

        private void FormGestaoRestaurantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
            this.FormBack.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbFiltrar.Text = "";
            ReloadDataGridView();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Clientes_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Cliente> clientes = databaseContainer.Pessoas.OfType<Cliente>().Where(cliente => cliente.Nome.ToUpper().Contains(tbFiltrar.Text.ToUpper()) && cliente.Ativo == true).ToList();

                Clientes_DataGridView.Rows.Clear();

                foreach (Cliente cliente in clientes)
                    Clientes_DataGridView.Rows.Add(buildDataGridRow(cliente));

                if (Clientes_DataGridView.Rows.Count > 0)
                    Clientes_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        
    }
}