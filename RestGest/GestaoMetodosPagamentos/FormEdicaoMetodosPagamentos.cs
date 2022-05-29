using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RestGest.GestaoMetodosPagamentos
{
    public partial class FormEdicaoMetodosPagamentos : Form
    {
        private RestGestContainer databaseContainer;
        private MetodoPagamento metodo;

        public FormEdicaoMetodosPagamentos()
        {
            InitializeComponent();
        }

        public FormEdicaoMetodosPagamentos(int idMetodo)
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            this.metodo = databaseContainer.MetodosPagamento.OfType<MetodoPagamento>().Where(t => t.Id == idMetodo).First();
            //Identificação do Metodo de Pagamento
            tbMetodoPagamento.Text = metodo.Metodo;
            cbAtivo.Checked = metodo.Ativo;
        }

        private void btnAddMetodoPagamento_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbMetodoPagamento.Text))
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de continuar!",
                    "Campos vazios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            metodo.Metodo = tbMetodoPagamento.Text;
            metodo.Ativo = cbAtivo.Checked;

            databaseContainer.SaveChanges();
            databaseContainer.Dispose();
            Close();
        }

        private void btnCleanMetodoPagamento_Click(object sender, EventArgs e)
        {
            tbMetodoPagamento.Text = "";
            cbAtivo.Checked = false;
        }
    }
}
