using System;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
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
            tb_name.Text = trabalhador.Nome;
            tb_num_contribuinte.Text = trabalhador.NumContribuinte;
            tb_telemovel.Text = trabalhador.Telemovel;
            tb_salario.Text = trabalhador.Salario.ToString();
            tb_position.Text = trabalhador.Posicao;
            //Identificação da morada do trabalhador
            tb_rua.Text = trabalhador.Morada.Rua;
            tb_cidade.Text = trabalhador.Morada.Cidade;
            tb_cp.Text = trabalhador.Morada.Codigo_Postal;
            tb_pais.Text = trabalhador.Morada.Pais;
            //Identificação do restaurante asociado ao trabalhador
            if (this.trabalhador.Restaurante != null)
                tb_restaurante.Text = trabalhador.Restaurante.Id + " - " + trabalhador.Restaurante.Nome;
            //
            bt_edit.Enabled = true;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                MessageBox.Show("Preencha todos os campos", "Edição de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SalarioValidation())
            {
                MessageBox.Show("Indique um salário válido", "Salário inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Morada moradaTrabalhador = new Morada(tb_rua.Text, tb_cidade.Text, tb_cp.Text, tb_pais.Text);

            moradaTrabalhador = databaseContainer.Moradas.Add(moradaTrabalhador);
            databaseContainer.SaveChanges();

            Trabalhador novoTrabalhador = new Trabalhador();

            novoTrabalhador.Nome = tb_name.Text;
            novoTrabalhador.NumContribuinte = tb_num_contribuinte.Text;
            novoTrabalhador.Telemovel = tb_telemovel.Text;
            novoTrabalhador.Salario = decimal.Parse(tb_salario.Text);
            novoTrabalhador.Posicao = tb_position.Text;
            novoTrabalhador.RestauranteId = null;
            novoTrabalhador.Restaurante = null;
            novoTrabalhador.Morada = moradaTrabalhador;
            //
            if (!String.IsNullOrEmpty(tb_restaurante.Text))
            {
                int idRestaurante = tb_restaurante.Text[0] - '0';
                novoTrabalhador.Restaurante = databaseContainer.Restaurantes.Find(idRestaurante);
                novoTrabalhador.RestauranteId = idRestaurante;
            }
            //
            databaseContainer.Pessoas.Add(novoTrabalhador);
            try
            {
                databaseContainer.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("Erro guardando dados", "Add Worker Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                foreach (var ev in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type " + ev.Entry.Entity.GetType().Name + " in state " + ev.Entry.State + " has the following validation errors:");
                    foreach (var ve in ev.ValidationErrors)
                        Console.WriteLine("- Property: " + ve.PropertyName + ", Error: " + ve.ErrorMessage);
                }
            }

            this.Close();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                MessageBox.Show("Preencha todos os campos", "Criação de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SalarioValidation())
            {
                MessageBox.Show("Indique um salário válido", "Salário inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            trabalhador.Nome = tb_name.Text;
            trabalhador.NumContribuinte = tb_num_contribuinte.Text;
            trabalhador.Telemovel = tb_telemovel.Text;
            trabalhador.Salario = decimal.Parse(tb_salario.Text);
            trabalhador.Posicao = tb_position.Text;
            trabalhador.Morada = new Morada(tb_rua.Text, tb_cidade.Text, tb_cp.Text, tb_pais.Text);

            if (String.IsNullOrEmpty(tb_restaurante.Text))
            {
                trabalhador.Restaurante.Nome = "";
                trabalhador.Restaurante.NumContribuinte = "";
            }
            else
            {
                int idRestaurante = tb_restaurante.Text[0] - '0';
                trabalhador.Restaurante = databaseContainer.Restaurantes.Find(idRestaurante);
                trabalhador.RestauranteId = idRestaurante;
            }

            //
            try
            {
                databaseContainer.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("Saving changes fail...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (var ev in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type " + ev.Entry.Entity.GetType().Name + " in state " + ev.Entry.State + " has the following validation errors:");
                    foreach (var ve in ev.ValidationErrors)
                        Console.WriteLine("- Property: " + ve.PropertyName + ", Error: " + ve.ErrorMessage);
                }
            }
            //
            this.Close();
        }

        // Text Box input validadtion
        private bool InputValidation()
        {
            return (String.IsNullOrEmpty(tb_name.Text) || String.IsNullOrEmpty(tb_salario.Text) ||
                String.IsNullOrEmpty(tb_position.Text) || String.IsNullOrEmpty(tb_rua.Text) || String.IsNullOrEmpty(tb_cidade.Text) ||
                String.IsNullOrEmpty(tb_cp.Text) || String.IsNullOrEmpty(tb_pais.Text));
        }

        private bool SalarioValidation()
        {
            tb_salario.Text = tb_salario.Text.Replace(".", ",");
            return !decimal.TryParse(tb_salario.Text, out decimal salario);
        }

        private void tb_restaurante_MouseClick(object sender, MouseEventArgs e)
        {
            FormGestaoRestaurantes form = new FormGestaoRestaurantes(this, false);
            form.ShowDialog();
            if (form.returnRestaurante != null)
                tb_restaurante.Text = form.returnRestaurante.Id + " - " + form.returnRestaurante.Nome;
        }
    }
}
