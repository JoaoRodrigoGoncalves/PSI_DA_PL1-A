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
        RestGestContainer databaseContainer;
        decimal ToalValueToPay;
        List<Pagamento> PaymentList = new List<Pagamento>();
        public FormPagamento(int valueToPay)
        {
            InitializeComponent();
            this.databaseContainer = new RestGestContainer();
            this.ToalValueToPay = valueToPay;
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            cb_MetodosPagamentos.Items.AddRange(this.databaseContainer.MetodosPagamento.Where(mt => mt.Ativo).ToArray());
            tb_valor_to_pay.Text = this.ToalValueToPay.ToString();

        }
    }
}
