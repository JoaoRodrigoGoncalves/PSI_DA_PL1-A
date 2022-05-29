using System;
using System.Windows.Forms;

namespace RestGest.GestaoMetodosPagamentos
{
    public partial class RegistarMetodosPagamento : Form
    {
        private RestGestContainer databaseContainer;

        public RegistarMetodosPagamento()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
        }

        private void btnAddMetodoPagamento_Click(object sender, EventArgs e)
        {
            /* Verificação do campo nome */
            if (tbMetodoPagamento.Text.Trim() == "")
            {
                MessageBox.Show("Insira um Nome!");
                return;
            }

            /* Cria um novo Método com os respetivos dados presentes nos campos a baixo */
            /* Guarda na tabela Métodos Pgamento */
            MetodoPagamento metodoPagamento = new MetodoPagamento();

            metodoPagamento.Metodo = tbMetodoPagamento.Text;
            metodoPagamento.Ativo = cbAtivo.Checked;

            databaseContainer.MetodosPagamento.Add(metodoPagamento);
            databaseContainer.SaveChanges();

            /* Limpa as texboxs */
            tbMetodoPagamento.Text = "";
            tbMetodoPagamento.Focus();// Foca no texbox quando se abre esta janela

            cbAtivo.Checked = false;

            Close();
        }

        private void btnCleanMetodoPagamento_Click(object sender, EventArgs e)
        {
            tbMetodoPagamento.Text = "";
            cbAtivo.Checked = false;
        }
    }
}
