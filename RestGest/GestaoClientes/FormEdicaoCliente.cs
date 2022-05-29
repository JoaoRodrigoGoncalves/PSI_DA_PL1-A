using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RestGest.GestaoClientes
{
    public partial class FormEdicaoCliente : Form
    {
        private RestGestContainer databaseContainer;
        private Cliente cliente;

        public FormEdicaoCliente()
        {
            InitializeComponent();
        }

        public FormEdicaoCliente(int idCliente)
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            this.cliente = databaseContainer.Pessoas.OfType<Cliente>().Where(t => t.Id == idCliente).First();
            //Identificação do Cliente
            tb_Nome.Text = cliente.Nome;
            tb_telemovel.Text = cliente.Telemovel;
            tb_nif.Text = cliente.NumContribuinte;
            //Identificação da morada do Cliente
            tb_rua.Text = cliente.Morada.Rua;
            tb_cidade.Text = cliente.Morada.Cidade;
            tb_codPostal.Text = cliente.Morada.Codigo_Postal;
            tb_pais.Text = cliente.Morada.Pais;
        }

        private bool validateFields()
        {
            if (String.IsNullOrWhiteSpace(tb_Nome.Text))
                return false;

            if (!String.IsNullOrWhiteSpace(tb_nif.Text))
            {
                if (!int.TryParse(tb_nif.Text, out _))
                    return false;
            }
            else
            {
                return false;
            }

            if (!String.IsNullOrWhiteSpace(tb_telemovel.Text))
            {
                if (!int.TryParse(tb_telemovel.Text, out _))
                    return false;
            }
            else
            {
                return false;
            }

            if (String.IsNullOrWhiteSpace(tb_rua.Text))
                return false;

            if (String.IsNullOrWhiteSpace(tb_codPostal.Text))
                return false;

            if (String.IsNullOrWhiteSpace(tb_cidade.Text))
                return false;

            if (String.IsNullOrWhiteSpace(tb_pais.Text))
                return false;

            return true;
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de continuar!",
                    "Campos vazios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            cliente.Nome = tb_Nome.Text;
            cliente.NumContribuinte = tb_nif.Text;
            cliente.Telemovel = tb_telemovel.Text;
            cliente.Morada.Rua = tb_rua.Text;
            cliente.Morada.Codigo_Postal = tb_codPostal.Text;
            cliente.Morada.Cidade = tb_cidade.Text;
            cliente.Morada.Pais = tb_pais.Text;

            databaseContainer.SaveChanges();
            databaseContainer.Dispose();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
