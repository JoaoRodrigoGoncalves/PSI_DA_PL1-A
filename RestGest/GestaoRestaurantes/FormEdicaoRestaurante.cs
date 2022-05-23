using System;
using System.Linq;
using System.Windows.Forms;

namespace RestGest.GestaoRestaurantes
{
    public partial class FormEdicaoRestaurante : Form
    {
        private RestGestContainer databaseContainer;
        private Restaurante dadosRestaurante;

        public FormEdicaoRestaurante(int restaurante_id)
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            dadosRestaurante = databaseContainer.Restaurantes.Find(restaurante_id);

            Nome_TextBox.Text = dadosRestaurante.Nome;
            NIF_MaskedTextBox.Text = dadosRestaurante.NumContribuinte;
            Rua_TextBox.Text = dadosRestaurante.Morada.Rua;
            CodigoPostal_MaskedTextBox.Text = dadosRestaurante.Morada.Codigo_Postal;
            Cidade_TextBox.Text = dadosRestaurante.Morada.Cidade;
            Pais_TextBox.Text = dadosRestaurante.Morada.Pais;
        }

        private void Guardar_BTN_Click(object sender, EventArgs e)
        {
            
            dadosRestaurante.Nome = Nome_TextBox.Text;
            dadosRestaurante.NumContribuinte = NIF_MaskedTextBox.Text;
            dadosRestaurante.Morada.Rua = Rua_TextBox.Text;
            dadosRestaurante.Morada.Codigo_Postal = CodigoPostal_MaskedTextBox.Text;
            dadosRestaurante.Morada.Cidade = Cidade_TextBox.Text;
            dadosRestaurante.Morada.Pais = Pais_TextBox.Text;

            if(databaseContainer.Restaurantes.Where(x => x.NumContribuinte == NIF_MaskedTextBox.Text && x.Id != dadosRestaurante.Id).Count() == 1)
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

        private void Cancelar_BTN_Click(object sender, EventArgs e)
        {
            databaseContainer.Dispose();
            Close();
        }
    }
}
