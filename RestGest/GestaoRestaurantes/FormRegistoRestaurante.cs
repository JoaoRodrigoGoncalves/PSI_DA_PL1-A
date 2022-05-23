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

        private void Registar_BTN_Click(object sender, EventArgs e)
        {
            Morada moradaRestaurante = new Morada();

            moradaRestaurante.Rua = Rua_TextBox.Text;
            moradaRestaurante.Codigo_Postal = CodigoPostal_MaskedTextBox.Text;
            moradaRestaurante.Cidade = Cidade_TextBox.Text;
            moradaRestaurante.Pais = Pais_TextBox.Text;

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
                Restaurante novoRestaurante = new Restaurante();
                novoRestaurante.Nome = Nome_TextBox.Text;
                novoRestaurante.NumContribuinte = NIF_MaskedTextBox.Text;

                moradaRestaurante = databaseContainer.Moradas.Add(moradaRestaurante);
                novoRestaurante.Morada = moradaRestaurante;
                
                databaseContainer.Restaurantes.Add(novoRestaurante);
            }

            databaseContainer.SaveChanges();
            databaseContainer.Dispose();
            Close();
        }
    }
}
