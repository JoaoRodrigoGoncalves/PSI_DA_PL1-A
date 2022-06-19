using System;
using System.Linq;
using System.Windows.Forms;

namespace RestGest.GestaoRestaurantes
{
    public partial class FormRestaurante : Form
    {
        private RestGestContainer databaseContainer;
        private Restaurante dadosRestaurante;

        public FormRestaurante()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            Create_BTN.Enabled = true;
        }

        public FormRestaurante(int restaurante_id)
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            Guardar_BTN.Enabled = true;
            dadosRestaurante = databaseContainer.Restaurantes.Find(restaurante_id);

            Nome_TextBox.Text = dadosRestaurante.Nome;
            NIF_MaskedTextBox.Text = dadosRestaurante.NumContribuinte;
            Rua_TextBox.Text = dadosRestaurante.Morada.Rua;
            CodigoPostal_MaskedTextBox.Text = dadosRestaurante.Morada.Codigo_Postal;
            Cidade_TextBox.Text = dadosRestaurante.Morada.Cidade;
            Pais_TextBox.Text = dadosRestaurante.Morada.Pais;
        }

        private bool ValidationFields()
        {
            if (String.IsNullOrWhiteSpace(Nome_TextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(NIF_MaskedTextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(Rua_TextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(CodigoPostal_MaskedTextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(Cidade_TextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(Pais_TextBox.Text))
                return false;

            return true;
        }

        private void Guardar_BTN_Click(object sender, EventArgs e)
        {
            if (!ValidationFields())
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de continuar!",
                    "Campos vazios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            dadosRestaurante.Nome = Nome_TextBox.Text;
            dadosRestaurante.NumContribuinte = NIF_MaskedTextBox.Text;
            dadosRestaurante.Morada.Rua = Rua_TextBox.Text;
            dadosRestaurante.Morada.Codigo_Postal = CodigoPostal_MaskedTextBox.Text;
            dadosRestaurante.Morada.Cidade = Cidade_TextBox.Text;
            dadosRestaurante.Morada.Pais = Pais_TextBox.Text;

            if (databaseContainer.Restaurantes.Where(x => x.NumContribuinte == NIF_MaskedTextBox.Text && x.Id != dadosRestaurante.Id).Count() == 1)
            {
                Restaurante match = databaseContainer.Restaurantes.First(x => x.NumContribuinte == NIF_MaskedTextBox.Text && x.Id != dadosRestaurante.Id);
                MessageBox.Show(
                    "Número de Contribuinte indicado já se encontra em utilização pelo restaurante \"" + match.Nome + "\". Operação abortada.",
                    "Número de Contribuinte indicado em utilização",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            databaseContainer.SaveChanges();
            databaseContainer.Dispose();
            Close();
        }

        private void Registar_BTN_Click(object sender, EventArgs e)
        {
            if (!ValidationFields())
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de continuar!",
                    "Campos vazios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            Morada moradaRestaurante = new Morada(Rua_TextBox.Text, Cidade_TextBox.Text, CodigoPostal_MaskedTextBox.Text, Pais_TextBox.Text);

            if (databaseContainer.Restaurantes.Where(x => x.NumContribuinte == NIF_MaskedTextBox.Text).Count() > 0)
            {
                Restaurante match = databaseContainer.Restaurantes.First(x => x.NumContribuinte == NIF_MaskedTextBox.Text);
                if (match.Ativo)
                {
                    MessageBox.Show(
                        "O restaurante \"" + match.Nome + "\" já está registado com o número de contribuinte indicado.",
                        "Número de Contribuinte em uso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "O número de contribuinte indicado está associado a um restaurante desativado. Os dados serão atualizados e o restaurante ativado.",
                        "Número de contribuinte associado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    match.Ativo = true;
                    match.Nome = Nome_TextBox.Text;

                    Morada antigaMorada = databaseContainer.Moradas.Find(match.Morada.Id);
                    databaseContainer.Moradas.Remove(antigaMorada);

                    moradaRestaurante = databaseContainer.Moradas.Add(moradaRestaurante);
                    match.Morada = moradaRestaurante;
                }
            }
            else
            {
                Restaurante newRestaurante = new Restaurante();
                newRestaurante.Nome = Nome_TextBox.Text;
                newRestaurante.NumContribuinte = NIF_MaskedTextBox.Text;

                moradaRestaurante = databaseContainer.Moradas.Add(moradaRestaurante);
                newRestaurante.Morada = moradaRestaurante;

                databaseContainer.Restaurantes.Add(newRestaurante);
            }

            databaseContainer.SaveChanges();
            databaseContainer.Dispose();
            Close();
        }

        private void Cancelar_BTN_Click(object sender, EventArgs e)
        {
            databaseContainer.Dispose();
            Close();
        }
    }
}
