using System;
using System.Windows.Forms;

namespace RestGest.GestaoMetodosPagamentos
{
    public partial class FormMetodoPagamento : Form
    {
        private RestGestContainer databaseContainer;
        private MetodoPagamento MetodoPagamento;
        public FormMetodoPagamento()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            btn_Create.Enabled = true;
        }
        
        public FormMetodoPagamento(int idMetodoPagamento)
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            this.MetodoPagamento = databaseContainer.MetodosPagamento.Find(idMetodoPagamento);
            tbMetodoPagamento.Text = this.MetodoPagamento.Metodo;
            cbAtivo.Checked = this.MetodoPagamento.Ativo;
            btn_Update.Enabled = true;
        }

        private void btn_Create_Click(object sender, EventArgs e)
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

        private void btn_Update_Click(object sender, EventArgs e)
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

            this.MetodoPagamento.Metodo = tbMetodoPagamento.Text;
            this.MetodoPagamento.Ativo = cbAtivo.Checked;

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
