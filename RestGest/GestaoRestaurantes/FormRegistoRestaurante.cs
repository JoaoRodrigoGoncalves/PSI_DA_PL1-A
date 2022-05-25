using System;
using System.Linq;
using System.Windows.Forms;

namespace RestGest.GestaoRestaurantes
{
    public partial class FormRegistoRestaurante : Form
    {
        private RestGestContainer databaseContainer;

        public FormRegistoRestaurante()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
        }

        private bool validateFields()
        {
            if(String.IsNullOrWhiteSpace(Nome_TextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(NIF_MaskedTextBox.Text))
                return false;

            if(String.IsNullOrWhiteSpace(Rua_TextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(CodigoPostal_MaskedTextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(Cidade_TextBox.Text))
                return false;

            if (String.IsNullOrWhiteSpace(Pais_TextBox.Text))
                return false;

            return true;
        }

        private void Registar_BTN_Click(object sender, EventArgs e)
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

            Morada moradaRestaurante = new Morada(Rua_TextBox.Text, CodigoPostal_MaskedTextBox.Text, Cidade_TextBox.Text, Pais_TextBox.Text);

            if(databaseContainer.Restaurantes.Where(x => x.NumContribuinte == NIF_MaskedTextBox.Text).Count() == 1)
            {
                Restaurante match = databaseContainer.Restaurantes.Where(x => x.NumContribuinte == NIF_MaskedTextBox.Text).First();
                if(match.Ativo)
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

            Restaurante novoRestaurante = new Restaurante();
            novoRestaurante.Nome = Nome_TextBox.Text;
            novoRestaurante.NumContribuinte = NIF_MaskedTextBox.Text;
            novoRestaurante.Morada = moradaRestaurante;

            if(databaseContainer.Restaurantes.Where(x => x.NumContribuinte == NIF_MaskedTextBox.Text).Count() == 1)
            {
                Restaurante match = databaseContainer.Restaurantes.Where(x => x.NumContribuinte == NIF_MaskedTextBox.Text).First();
                if(match.Ativo)
                {
                    MessageBox.Show(
                        "O restaurante " + match.Nome + " já está registado com o número de contribuinte indicado.",
                        "Número de Contribuinte em uso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                        "O número de contribuinte indicado está associado a um restaurante dasativado. Os dados serão atualizados e o restaurante ativado.",
                        "Número de contribuinte associado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    match = novoRestaurante;
                    match.Ativo = true;
                    databaseContainer.SaveChanges();
                }
            }
            else
            {
                databaseContainer.Restaurantes.Add(novoRestaurante);
                databaseContainer.SaveChanges();
            }

            databaseContainer.Dispose();
            Close();
        }
    }
}
