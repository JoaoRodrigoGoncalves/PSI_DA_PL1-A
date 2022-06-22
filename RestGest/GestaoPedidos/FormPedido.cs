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
            // Mudar nome da janela para o número do pedido e o estado atual
            this.Text = "Pedido Nº" + this.pedido.Id + " - " + this.pedido.Estado.TipoEstado;
            // Mostrar dados do restaurante
            tb_nome_rt.Text = this.pedido.Restaurante.Nome;
            tb_nif_rt.Text = this.pedido.Restaurante.NumContribuinte;
            // Mostrar dados do cliente
            tb_nome_clt.Text = this.pedido.Cliente.Nome;
            tb_nif_clt.Text = this.pedido.Cliente.NumContribuinte;
            // Mostrar dados do funcionário
            tb_nome_emp.Text = this.pedido.Trabalhador.Nome;
            tb_nif_emp.Text = this.pedido.Trabalhador.NumContribuinte;
            // Mostrar produtos do pedido
            foreach (ItemPedido itemPedido in this.pedido.ItemPedido)
            {
                lb_items.Items.Add(itemPedido.ItemMenu);
            }

            // Mostrar pagamentos associados ao pedido
            foreach(Pagamento pagamento in pedido.Pagamento)
            {
                lb_pagamentos.Items.Add(pagamento);
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            databaseContainer.Dispose();
            this.Close();
        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            //Conteúdo que fará parte do ficheiro TXT
            //Dados do Restaurante (Nome e NIF)
            var content = tb_nome_rt.Text + Environment.NewLine;
            content += "NIF: " + tb_nif_rt.Text + Environment.NewLine;
            content += "Opr.: " + tb_nome_emp.Text + Environment.NewLine;
            content += "____________________________________________________________Original" + Environment.NewLine + Environment.NewLine;

            //Data e Hora que foi "extraído" o ficheiro TXT
            content += "Detalhes pedido Nº" + pedido.Id + Environment.NewLine;
            content += "Estado: " + pedido.Estado.TipoEstado + Environment.NewLine;
            content += "Data/Hora Exportação: " + DateTime.Now + Environment.NewLine;
            content += "____________________________________________________________________" + Environment.NewLine + Environment.NewLine;

            //Dados do Cliente
            content += "Nome: " + tb_nome_clt.Text + Environment.NewLine;
            content += "Contribuinte Nº: " + tb_nif_clt.Text + Environment.NewLine;
            content += "____________________________________________________________________" + Environment.NewLine + Environment.NewLine;

            //Dados do Pedido
            content += "Produto" + Environment.NewLine;
            if(lb_items.Items.Count > 0)
            {
                foreach (ItemMenu itemMenu in lb_items.Items.Cast<ItemMenu>())
                {
                    content += "- " + itemMenu + Environment.NewLine;
                }
            }
            else
            {
                content += "*** Sem itens a mostrar ***" + Environment.NewLine;
            }
            content += "____________________________________________________________________" + Environment.NewLine + Environment.NewLine;

            //Dados do Pagamento do Pedido
            content += "Total(Euros): " + pedido.GetTotalValue() + Environment.NewLine;
            if(lb_pagamentos.Items.Count > 0)
            {
                foreach (Pagamento pagamento in lb_pagamentos.Items)
                { 
                    content += "- " + pagamento + Environment.NewLine;
                }
            }
            else
            {
                content += "*** Pedido não pago ***";
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = $"{pedido.Id}_{tb_nome_clt.Text}({tb_nif_clt.Text})"; // Default file name
            dlg.Filter = "txt files(*.txt) |*.txt"; // Default file extensions
            dlg.FilterIndex= 1; // Default filter index
            // Show save file dialog box e process save file dialog box results
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                //Guardar o documento
                File.WriteAllText(dlg.FileName, content);
                System.Diagnostics.Process.Start(dlg.FileName);
            }
        }
    }
}
