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
            activeFuntion(this.FormGestao);
            databaseContainer = new RestGestContainer();
            estadoFiltro = databaseContainer.Estados.Find(1);
        }

        private void activeFuntion(bool active)
        {
            Adicionar_BTN.Enabled = active;
            Editar_BTN.Enabled = active;
            Remover_BTN.Enabled = active;
            Selecionar_BTN.Enabled = !active;
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
                foreach (Pedido pedido in databaseContainer.Pedidos.Where(x => x.Estado.Id == estadoFiltro.Id))
                {
                    string[] row = buildDataGridRow(pedido);
                    pedidos_DataGridView.Rows.Add(row);
                }

                if (pedidos_DataGridView.Rows.Count > 0)
                    pedidos_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private string[] buildDataGridRow(Pedido pedido)
        {
            string[] row = { pedido.Id.ToString(), pedido.Estado.TipoEstado, pedido.GetTotalValue().ToString() ,pedido.Cliente.Nome, pedido.Trabalhador.Nome, pedido.Restaurante.Nome };
            return row;
        }

        private void filtrar_BTN_Click(object sender, EventArgs e)
        {
            pedidos_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Pedido> pedidos = databaseContainer.Pedidos.Where(p => p.Restaurante.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper()) && p.Estado == estadoFiltro).ToList();

                pedidos_DataGridView.Rows.Clear();
                foreach (Pedido pedido in pedidos)
                {
                    string[] row = buildDataGridRow(pedido);
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

        private void Adicionar_BTN_Click(object sender, EventArgs e)
        {
            
        }
    }
}
