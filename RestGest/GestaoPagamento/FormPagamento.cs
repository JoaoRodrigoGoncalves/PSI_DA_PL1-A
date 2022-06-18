using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest.GestaoPagamento
{
    public partial class FormPagamento : Form
    {
        private RestGestContainer databaseContainer;
        private Pedido Working_Pedido;
        public List<Pagamento> resturnPaymentList;
        public FormPagamento(Pedido working_pedido)
        {
            InitializeComponent();
            this.databaseContainer = new RestGestContainer();
            this.Working_Pedido = working_pedido;
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            cb_MetodosPagamentos.Items.AddRange(this.databaseContainer.MetodosPagamento.Where(mt => mt.Ativo).ToArray());
            if (cb_MetodosPagamentos.Items.Count > 0)
                cb_MetodosPagamentos.SelectedIndex = 0;
            tb_valor_to_pay.Text = this.Working_Pedido.GetTotalValue().ToString();
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            //Validation
            if (cb_MetodosPagamentos.SelectedItem == null)
            {
                MessageBox.Show("Select a Pay method","Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (decimal.Parse(tb_valor_to_pay.Text) == 0)
            {
                MessageBox.Show("Pagamento concluido.\nFinalize o pagamento", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nb_value.Value <= 0)
                return;
    
            if (decimal.Parse(tb_valor_to_pay.Text) < nb_value.Value)
            {
                MessageBox.Show("Valor de pagamento superior ao valor em falta", "Pagemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Create Payment
            Pagamento new_payment = new Pagamento();
            new_payment.Valor = nb_value.Value;
            tb_valor_to_pay.Text = (decimal.Parse(tb_valor_to_pay.Text) - new_payment.Valor).ToString();
            new_payment.MetodoPagamento = (MetodoPagamento)cb_MetodosPagamentos.SelectedItem;
            new_payment.PedidoId = this.Working_Pedido.Id;
            //Add payment
            lb_pagamentos.Items.Add(new_payment);
            //Clear added value
            nb_value.Value = 0;
        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(tb_valor_to_pay.Text) > 0)
            {
                MessageBox.Show("Valor " + tb_valor_to_pay.Text + "€ em debida.\nEfetuar pagamento para concluir!", 
                    "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.resturnPaymentList = lb_pagamentos.Items.Cast<Pagamento>().ToList();
            this.Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_remove_payment_Click(object sender, EventArgs e)
        {
            if (lb_pagamentos.SelectedItem == null)
                return;

            tb_valor_to_pay.Text = (decimal.Parse(tb_valor_to_pay.Text) + ((Pagamento)lb_pagamentos.SelectedItem).Valor).ToString();

            lb_pagamentos.Items.Remove(lb_pagamentos.SelectedItem);
        }
        
        private void AddValue(decimal value)
        {
            nb_value.Value = nb_value.Value * 10 + value;
        }
        
        private void bt_num_1_Click(object sender, EventArgs e)
        {
            AddValue(0.01M);
        }

        private void bt_num_2_Click(object sender, EventArgs e)
        {
            AddValue(0.02M);
        }

        private void bt_num_3_Click(object sender, EventArgs e)
        {
            AddValue(0.03M);
        }

        private void bt_num_4_Click(object sender, EventArgs e)
        {
            AddValue(0.04M);
        }

        private void bt_num_5_Click(object sender, EventArgs e)
        {
            AddValue(0.05M);
        }

        private void bt_num_6_Click(object sender, EventArgs e)
        {
            AddValue(0.06M);
        }

        private void bt_num_7_Click(object sender, EventArgs e)
        {
            AddValue(0.07M);
        }

        private void bt_num_8_Click(object sender, EventArgs e)
        {
            AddValue(0.08M);
        }

        private void bt_num_9_Click(object sender, EventArgs e)
        {
            AddValue(0.09M);
        }

        private void bt_num_0_Click(object sender, EventArgs e)
        {
            AddValue(0.00M);
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            nb_value.Value = 0;
        }
    }
}
