using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormFuncionario : Form
    {
        private RestGestContainer databaseContainer;

        private Trabalhador trabalhador;
        public FormFuncionario()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            bt_create.Enabled = true;
        }

        public FormFuncionario(int idTrabalhador)
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            this.trabalhador = databaseContainer.Pessoas.OfType<Trabalhador>().Where(t => t.Id == idTrabalhador).First();
            //Identificação do trabalhador
            tb_id.Text = trabalhador.Id.ToString();
            tb_name.Text = trabalhador.Nome;
            tb_telemovel.Text = trabalhador.Telemovel;
            tb_salario.Text = trabalhador.Salario.ToString();
            tb_position.Text = trabalhador.Posicao;
            //Identificação da morada do trabalhador
            tb_rua.Text = trabalhador.Morada.Rua;
            tb_cidade.Text = trabalhador.Morada.Cidade;
            tb_cp.Text = trabalhador.Morada.Codigo_Postal;
            tb_pais.Text = trabalhador.Morada.Pais;
            bt_edit.Enabled = true;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (inputValidation())
            {
                MessageBox.Show("Preencha todos os campos", "Criação de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tb_salario.Text = tb_salario.Text.Replace(",", ".");
            if(!decimal.TryParse(tb_salario.Text, out decimal salario))
            {
                MessageBox.Show("Indique um salário válido", "Salário inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO Criar Trabalhador constructor
            trabalhador.Id = Convert.ToInt32(tb_id.Text);
            trabalhador.Nome = tb_name.Text;
            trabalhador.Telemovel = tb_telemovel.Text;
            trabalhador.Salario = salario;
            trabalhador.Posicao = tb_position.Text;
            trabalhador.Morada.Rua = tb_rua.Text;
            trabalhador.Morada.Cidade = tb_cidade.Text;
            trabalhador.Morada.Codigo_Postal = tb_cp.Text;
            trabalhador.Morada.Pais = tb_pais.Text;
            //trabalhador.Restaurante = databaseContainer.Restaurantes.Find(trabalhador.RestauranteId);
            //
            try
            {
                databaseContainer.SaveChanges();
            }catch(Exception ex)
            {
                MessageBox.Show("Saving changes fail...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
            //
            this.Close();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            if (inputValidation())
            {
                MessageBox.Show("Preencha todos os campos", "Edição de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tb_salario.Text = tb_salario.Text.Replace(".", ",");
            if (!decimal.TryParse(tb_salario.Text, out decimal salario))
            {
                MessageBox.Show("Indique um salário válido", "Salário inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Morada moradaTrabalhador = new Morada();

            moradaTrabalhador.Rua = tb_rua.Text;
            moradaTrabalhador.Cidade = tb_cidade.Text;
            moradaTrabalhador.Codigo_Postal = tb_cp.Text;
            moradaTrabalhador.Pais = tb_pais.Text;

            moradaTrabalhador = databaseContainer.Moradas.Add(moradaTrabalhador);
            databaseContainer.SaveChanges();

            Trabalhador novoTrabalhador = new Trabalhador();

            novoTrabalhador.Nome = tb_name.Text;
            novoTrabalhador.Telemovel = tb_telemovel.Text;
            novoTrabalhador.Salario = salario;
            novoTrabalhador.Posicao = tb_position.Text;
            novoTrabalhador.Morada = moradaTrabalhador;
            novoTrabalhador.RestauranteId = null;
            novoTrabalhador.Restaurante = null;
            
            databaseContainer.Pessoas.Add(novoTrabalhador);
            databaseContainer.SaveChanges();

            this.Close();
        }

        // Text Box input validadtion
        private bool inputValidation()
        { 
            return (String.IsNullOrEmpty(tb_name.Text) || String.IsNullOrEmpty(tb_salario.Text) ||
                String.IsNullOrEmpty(tb_position.Text) || String.IsNullOrEmpty(tb_rua.Text) || String.IsNullOrEmpty(tb_cidade.Text) ||
                String.IsNullOrEmpty(tb_cp.Text) || String.IsNullOrEmpty(tb_pais.Text));
        }
    }
}
