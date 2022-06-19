using System;
using System.Linq;
using System.Windows.Forms;

namespace RestGest.GestaoClientes
{
    public partial class FormCliente : Form
    {
        private RestGestContainer databaseContainer;
        private Cliente cliente;

        public FormCliente()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            btnRegistar.Enabled = true;
        }

        public FormCliente(int idCliente)
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
            //
            btn_Update.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tb_Nome.Text = "";
            tb_telemovel.Text = "";
            tb_nif.Text = "";
            tb_rua.Text = "";
            tb_cidade.Text = "";
            tb_codPostal.Text = "";
            tb_pais.Text = "";
        }

        private bool ValidateFields()
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

        private void btn_Registar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de continuar!",
                    "Campos vazios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            /* Cria um novo Cliente com os respetivos dados presentes nos campos a baixo */
            /*Guarda na Tabela Morada*/
            Morada Moradas = new Morada();

            Moradas.Rua = tb_rua.Text;
            Moradas.Cidade = tb_cidade.Text;
            Moradas.Codigo_Postal = tb_codPostal.Text;
            Moradas.Pais = tb_pais.Text;

            databaseContainer.Moradas.Add(Moradas);
            databaseContainer.SaveChanges();

            /* Guarda na tabela Cliente */
            Cliente Clientes = new Cliente();

            Clientes.Nome = tb_Nome.Text;
            Clientes.Telemovel = tb_telemovel.Text;
            Clientes.NumContribuinte = tb_nif.Text;
            Clientes.Morada = Moradas;

            databaseContainer.Pessoas.Add(Clientes);
            databaseContainer.SaveChanges();

            /* Limpa as texboxs */
            tb_Nome.Text = "";
            tb_Nome.Focus();// Foca no texbox quando se abre esta janela

            tb_telemovel.Text = "";
            tb_nif.Text = "";
            tb_rua.Text = "";
            tb_cidade.Text = "";
            tb_codPostal.Text = "";
            tb_pais.Text = "";

            Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
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
    }
}