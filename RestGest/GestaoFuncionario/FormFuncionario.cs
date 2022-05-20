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
            tb_salario.Text = decimalText(trabalhador.Salario);
            tb_position.Text = trabalhador.Posicao;
            //Identificação da morada do trabalhador
            tb_rua.Text = trabalhador.Morada.Rua;
            tb_cidade.Text = trabalhador.Morada.Cidade;
            tb_cp.Text = trabalhador.Morada.Codigo_Postal;
            tb_pais.Text = trabalhador.Morada.Pais;
            bt_edit.Enabled = true;
        }

        private string decimalText(decimal salario)
        {
            string salario_string = salario.ToString();
            int mask_size = tb_salario.Mask.Length - 3;
            for (int i = salario_string.Length; i < mask_size; i++)
                salario_string = "0" + salario_string;
            return salario_string;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (inputValidation())
            {
                MessageBox.Show("Preencha todos os campos", "Criação de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TODO Criar Trabalhador constructor
            trabalhador.Id = Convert.ToInt16(tb_id.Text);
            trabalhador.Nome = tb_name.Text;
            trabalhador.Telemovel = tb_telemovel.Text;
            trabalhador.Salario = Convert.ToDecimal(tb_salario.Text);
            trabalhador.Posicao = tb_position.Text;
            trabalhador.Morada.Rua = tb_rua.Text;
            trabalhador.Morada.Cidade = tb_cidade.Text;
            trabalhador.Morada.Codigo_Postal = tb_cp.Text;
            trabalhador.Morada.Pais = tb_pais.Text;
            trabalhador.Restaurante = databaseContainer.Restaurantes.Find(trabalhador.RestauranteId);
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
            databaseContainer = new RestGestContainer();
            // TODO Criar Trabalhador constructor
            Trabalhador trabalhardor_edit = new Trabalhador();
            trabalhardor_edit.Nome = tb_name.Text;
            trabalhardor_edit.Telemovel = tb_telemovel.Text;
            trabalhardor_edit.Salario = Convert.ToDecimal(tb_salario.Text);
            trabalhardor_edit.Posicao = tb_position.Text;
            trabalhardor_edit.Morada.Rua = tb_rua.Text;
            trabalhardor_edit.Morada.Cidade = tb_cidade.Text;
            trabalhardor_edit.Morada.Codigo_Postal = tb_cp.Text;
            trabalhardor_edit.Morada.Pais = tb_pais.Text;
            //TODO Make database 0..1
            //Can create a worker with out a restaurant
            trabalhardor_edit.Restaurante = databaseContainer.Restaurantes.Find(1);
            //
            try
            {
                databaseContainer.Pessoas.Add(trabalhardor_edit);
                databaseContainer.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving worker fail...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
            // TODO Insert the date base
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
