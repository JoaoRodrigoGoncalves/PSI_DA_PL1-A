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
        public FormFuncionario()
        {
            InitializeComponent();
            bt_create.Enabled = true;
        }

        public FormFuncionario(Trabalhador trabalhador)
        {
            InitializeComponent();
            //Identificação do trabalhador
            tb_id.Text = trabalhador.Id.ToString();
            tb_name.Text = trabalhador.Nome;
            tb_salario.Text = trabalhador.Salario.ToString();
            tb_position.Text = trabalhador.Posicao;
            //Identificação da morada do trabalhador
            tb_rua.Text = trabalhador.Morada.Rua ?? "";
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
                MessageBox.Show("Preencha todos os campos", "Criação de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TODO Criar Trabalhador constructor
            Trabalhador trabalhardor_edit = new Trabalhador();
            trabalhardor_edit.Id = Convert.ToInt16(tb_id.Text);
            trabalhardor_edit.Nome = tb_name.Text;
            trabalhardor_edit.Salario = Convert.ToInt16(tb_salario.Text);
            trabalhardor_edit.Posicao = tb_position.Text;
            trabalhardor_edit.Morada.Rua = tb_rua.Text;
            trabalhardor_edit.Morada.Cidade = tb_cidade.Text;
            trabalhardor_edit.Morada.Codigo_Postal = tb_cp.Text;
            trabalhardor_edit.Morada.Pais = tb_pais.Text;
            // TODO Update the date base
            this.Close();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            if (inputValidation())
            {
                MessageBox.Show("Preencha todos os campos", "Edição de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TODO Criar Trabalhador constructor
            Trabalhador trabalhardor_edit = new Trabalhador();
            trabalhardor_edit.Id = Convert.ToInt16(tb_id.Text);
            trabalhardor_edit.Nome = tb_name.Text;
            trabalhardor_edit.Salario = Convert.ToInt16(tb_salario.Text);
            trabalhardor_edit.Posicao = tb_position.Text;
            trabalhardor_edit.Morada.Rua = tb_rua.Text;
            trabalhardor_edit.Morada.Cidade = tb_cidade.Text;
            trabalhardor_edit.Morada.Codigo_Postal = tb_cp.Text;
            trabalhardor_edit.Morada.Pais = tb_pais.Text;
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
