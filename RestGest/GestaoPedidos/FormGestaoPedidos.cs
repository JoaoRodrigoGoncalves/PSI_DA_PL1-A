using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest.GestaoPedidos
{
    public partial class FormGestaoPedidos : Form
    {
        public Pedido returnPedido;
        private RestGestContainer databaseContainer;
        private bool FormGestao;
        private Form FormBack;
        private Estado estadoFiltro;
        public FormGestaoPedidos(Form formBack, bool gestao)
        {
            InitializeComponent();
            this.FormBack = formBack;
            this.FormGestao = gestao;
            ActivationFuntion(this.FormGestao);
            this.databaseContainer = new RestGestContainer();
            this.estadoFiltro = databaseContainer.Estados.Find(1);
        }

        private void ActivationFuntion(bool active)
        {
            bt_cancelar.Enabled = active;
            Selecionar_BTN.Enabled = !active;
            bt_concluidos.Visible = active;
            bt_pendente.Visible = active;
            bt_cancelados.Visible = active;
            bt_all.Enabled = active;
        }
        
        private void FormGestaoPedidos_Shown(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(ReloadDataGridView);
            loadingThread.Start();
        }

        private void ReloadDataGridView()
        {
            databaseContainer = new RestGestContainer();
            pedidos_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                pedidos_DataGridView.Rows.Clear();
                //Inizializa os pedidos
                List<Pedido> list_pedidos;
                //Carrega os dados em função de se existir um filtro de estado ou não
                if(estadoFiltro == null)
                    list_pedidos = databaseContainer.Pedidos.ToList();
                else
                    list_pedidos = databaseContainer.Pedidos.Where(x => x.Estado.Id == estadoFiltro.Id).ToList();
                //Lee os pedidos e controe a tabela de dados
                foreach (Pedido pedido in list_pedidos)
                {
                    string[] row = BuildDataGridRow(pedido);
                    pedidos_DataGridView.Rows.Add(row);
                }

                if (pedidos_DataGridView.Rows.Count > 0)
                    pedidos_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private string[] BuildDataGridRow(Pedido pedido)
        {
            string[] row = { pedido.Id.ToString(), pedido.Estado.TipoEstado, pedido.Restaurante.Nome, pedido.Cliente.Nome, pedido.Trabalhador.Nome, pedido.GetTotalValue().ToString() };
            return row;
        }

        private void filtrar_BTN_Click(object sender, EventArgs e)
        {
            pedidos_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Pedido> pedidos = databaseContainer.Pedidos.Where(p => p.Restaurante.Nome.ToUpper().Contains(tb_filter.Text.ToUpper()) && p.Estado == estadoFiltro).ToList();

                pedidos_DataGridView.Rows.Clear();
                foreach (Pedido pedido in pedidos)
                {
                    string[] row = BuildDataGridRow(pedido);
                    pedidos_DataGridView.Rows.Add(row);
                }

                if (pedidos_DataGridView.Rows.Count > 0)
                    pedidos_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void bt_pendente_Click(object sender, EventArgs e)
        {
            estadoFiltro = databaseContainer.Estados.Find(1);
            ReloadDataGridView();
        }

        private void bt_concluidos_Click(object sender, EventArgs e)
        {
            estadoFiltro = databaseContainer.Estados.Find(2);
            ReloadDataGridView();
        }

        private void bt_cancelados_Click(object sender, EventArgs e)
        {
            estadoFiltro = databaseContainer.Estados.Find(3);
            ReloadDataGridView();
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            estadoFiltro = null;
            ReloadDataGridView();
        }
        
        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            if (pedidos_DataGridView.SelectedRows.Count == 1)
            {
                int row = pedidos_DataGridView.SelectedRows[0].Index;
                int idPedido = int.Parse(pedidos_DataGridView.Rows[row].Cells[0].Value.ToString());
                Pedido remove_pedido = this.databaseContainer.Pedidos.Where(p => p.Id == idPedido).First();
                if (remove_pedido.Estado.Id == 2)
                {
                    MessageBox.Show("Pedido já concluido. Não pode ser cancelado", "Cancelar Pedido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (remove_pedido.Estado.Id == 3)
                {
                    MessageBox.Show("Pedido já cancelado. Não pode ser cancelado outra vez", "Cancelar Pedido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Tem a certeza que quere cancelar o pedido Nº" + remove_pedido.Id + " ?", "Cancelar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            return;
                        //Update pedido estate
                        remove_pedido.Estado = this.databaseContainer.Estados.Find(3);
                        this.databaseContainer.SaveChanges();
                        MessageBox.Show("Pedido Nº" + remove_pedido.Id + " cancelado!", "Cancelar Pedido",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }catch (Exception ex)
                    {
                        //TODO Delete ex part of the message once finish
                        MessageBox.Show("Erro cancelando pedido Nº" + remove_pedido.Id + "\nEntrar em contacto com administrador\n" + ex.Message, 
                            "Erro Cancelar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            ReloadDataGridView();
        }

        private void FormGestaoPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
            this.FormBack.Show();
        }

        private void Detalhes_BTN_Click(object sender, EventArgs e)
        {
            if (pedidos_DataGridView.SelectedRows.Count == 1)
            {
                int row = pedidos_DataGridView.SelectedRows[0].Index;
                int idPedido = int.Parse(pedidos_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormPedido(idPedido).ShowDialog();
            }
        }

        private void Selecionar_BTN_Click(object sender, EventArgs e)
        {
            if (pedidos_DataGridView.SelectedRows.Count == 1)
            {
                int row = pedidos_DataGridView.SelectedRows[0].Index;
                int idPedido = int.Parse(pedidos_DataGridView.Rows[row].Cells[0].Value.ToString());
                this.returnPedido = this.databaseContainer.Pedidos.Find(idPedido);
                this.Close();
            }
        }

        private void bt_filter_Click(object sender, EventArgs e)
        {
            pedidos_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Pedido> pedidos = databaseContainer.Pedidos.
                Where(p => p.Restaurante.Nome.ToUpper().Contains(tb_filter.Text.ToUpper()) || 
                    p.Cliente.Nome.ToUpper().Contains(tb_filter.Text.ToUpper()) || 
                    p.Trabalhador.Nome.ToUpper().Contains(tb_filter.Text.ToUpper())).ToList();

                pedidos_DataGridView.Rows.Clear();

                foreach (Pedido cliente in pedidos)
                    pedidos_DataGridView.Rows.Add(BuildDataGridRow(cliente));

                if (pedidos_DataGridView.Rows.Count > 0)
                    pedidos_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void LimparFiltro_BTN_Click(object sender, EventArgs e)
        {
            tb_filter.Text = "";
            ReloadDataGridView();
        }

        private void pedidos_DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = pedidos_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                pedidos_DataGridView.ClearSelection();
                pedidos_DataGridView.Rows[hit.RowIndex].Selected = true;
                //
                if (this.FormGestao)
                    Detalhes_BTN_Click(sender, e);
                else
                    Selecionar_BTN_Click(sender, e);
            }
        }

    }
}
