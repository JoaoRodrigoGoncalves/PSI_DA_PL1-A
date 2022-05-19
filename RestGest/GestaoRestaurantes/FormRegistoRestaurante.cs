using System;
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

            moradaRestaurante = databaseContainer.Moradas.Add(moradaRestaurante);

            databaseContainer.SaveChanges();

            Restaurante novoRestaurante = new Restaurante();
            novoRestaurante.Nome = Nome_TextBox.Text;
            novoRestaurante.Morada = moradaRestaurante;

            databaseContainer.Restaurantes.Add(novoRestaurante);
            databaseContainer.SaveChanges();

            databaseContainer.Dispose();
            Close();
        }
    }
}
