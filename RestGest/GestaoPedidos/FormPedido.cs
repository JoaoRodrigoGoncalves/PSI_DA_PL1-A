using RestGest.GestaoRestaurantes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            if(this.pedido.ItemPedido != null)
            {
                this.pedido.ItemPedido.ToArray();

                foreach (ItemPedido itemPedido in this.pedido.ItemPedido)
                {
                    lb_items.Items.Add(itemPedido.ItemMenu);
                }
            }
            else
            {
                new List<ItemPedido>().ToArray();
            }

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

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            
            //Conteúdo que fará parte do ficheiro TXT
            //Dados do Restaurante (Nome e NIF)
            var content = tb_nome_rt.Text + Environment.NewLine + Environment.NewLine + "NIF: " + tb_nif_rt.Text + Environment.NewLine + Environment.NewLine + "Opr.: " + tb_nome_emp.Text + Environment.NewLine + Environment.NewLine;
            content += "____________________________________________________________Original" + Environment.NewLine + Environment.NewLine;

            //Data e Hora que foi "extraído" o ficheiro TXT
            content += "Fatura-Recibo" + Environment.NewLine + Environment.NewLine + "Data/ Hora: " + DateTime.Now + Environment.NewLine + Environment.NewLine;
            content += "____________________________________________________________________" + Environment.NewLine + Environment.NewLine;
            
            //Dados do Cliente
            content += "Nome: " + tb_nome_clt.Text + Environment.NewLine + Environment.NewLine + "Contribuinte n.: " + tb_nif_clt.Text + Environment.NewLine + Environment.NewLine;
            content += "____________________________________________________________________" + Environment.NewLine + Environment.NewLine;

            //Dados do Pedido
            content += "Produto" + Environment.NewLine + Environment.NewLine;
            foreach (ItemPedido itemPedido in lb_items.Items)
            {
                content += "- " + itemPedido + Environment.NewLine + Environment.NewLine;
            }
            content += "____________________________________________________________________" + Environment.NewLine + Environment.NewLine;

            //Dados do Pagamento do Pedido
            content += "Total(Euros): " + Environment.NewLine + Environment.NewLine;
            foreach (Pagamento pagamento in lb_pagamentos.Items)
            { 
                content += "- " + pagamento + Environment.NewLine + Environment.NewLine;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = $"{tb_nome_clt.Text}({tb_nif_clt.Text})"; // Default file name
            dlg.Filter = "txt files(*.txt) |*.txt"; // Default file extensions
            dlg.FilterIndex= 1; // Default filter index
            // Show save file dialog box e process save file dialog box results
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                //Guardar o documento
                File.WriteAllText(dlg.FileName, content);

                MessageBox.Show("Os dados do pedido foram exportados com sucesso!");
            }
        }
    }
}
