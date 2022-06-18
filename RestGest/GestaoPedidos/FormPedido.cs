using RestGest.GestaoRestaurantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest.GestaoPedidos
{
    public partial class FormPedido : Form
    {
        private Pedido pedido;
        private RestGestContainer databaseContainer;
        public FormPedido(int idPedido)
        {
            InitializeComponent();
            this.databaseContainer = new RestGestContainer();
            //Load dados do pedido
            this.pedido = this.databaseContainer.Pedidos.Find(idPedido);
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            //Load Pedido data
            this.Text = "Pedido Nº" + this.pedido.Id + " - " + this.pedido.Estado.TipoEstado;
            //Load Restaurante data
            tb_nome_rt.Text = this.pedido.Restaurante.Nome;
            tb_nif_rt.Text = this.pedido.Restaurante.NumContribuinte;
            //Load Client data
            tb_nome_clt.Text = this.pedido.Cliente.Nome;
            tb_nif_clt.Text = this.pedido.Cliente.NumContribuinte;
            //Load Empregado data
            tb_nome_emp.Text = this.pedido.Trabalhador.Nome;
            tb_nif_emp.Text = this.pedido.Trabalhador.NumContribuinte;
            //Load Item list
            lb_items.Items.AddRange(this.pedido.ItemMenu != null ? this.pedido.ItemMenu.ToArray() : new List<ItemMenu>().ToArray());
            //Load Payment list
            lb_pagamentos.Items.AddRange(this.pedido.Pagamento != null ? this.pedido.Pagamento.ToArray() : new List<Pagamento>().ToArray());
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_items_MouseClick(object sender, MouseEventArgs e)
        {
            if (lb_items.SelectedItem == null)
                return;

            new FormProduto(((ItemMenu)lb_items.SelectedItem).Id, false).ShowDialog();
        }
    }
}
