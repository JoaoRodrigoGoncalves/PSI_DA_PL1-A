using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGestaoFuncionarios : Form
    {
        private RestGestContainer databaseContainer;
        private Form FormBack;
        public Trabalhador returnTrabalhador;
        private bool Gestao;
        private int IdRestauranteFiltro;

        public FormGestaoFuncionarios(Form formBack, bool gestao)
        {
            InitializeComponent();
            this.FormBack = formBack;
            this.Gestao = gestao;
            this.IdRestauranteFiltro = 0;
        }

        public FormGestaoFuncionarios(Form formBack, bool gestao, int idRestauranteFiltro)
        {
            InitializeComponent();
            this.FormBack = formBack;
            this.Gestao = gestao;
            this.IdRestauranteFiltro = idRestauranteFiltro;
            activeFuntion(this.Gestao);
        }
        private void activeFuntion(bool active)
        {
            Adicionar_BTN.Enabled = active;
            Editar_BTN.Enabled = active;
            Remover_BTN.Enabled = active;
            Selecionar_BTN.Enabled = !active;
        }

        private void FormGestaoFuncionarios_Shown(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(ReloadDataGridView);
            loadingThread.Start();
        }

        private void ReloadDataGridView()
        {
            databaseContainer = new RestGestContainer();


            funcionarios_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                funcionarios_DataGridView.Rows.Clear();
                List<Trabalhador> funcionarios = (IdRestauranteFiltro < 1 ? databaseContainer.Pessoas.OfType<Trabalhador>().Where(x => x.Ativo) : databaseContainer.Pessoas.OfType<Trabalhador>().Where(x => x.Ativo && x.Restaurante.Id == IdRestauranteFiltro)).ToList();
                foreach (Trabalhador funcionario in funcionarios)
                {
                    //Prevenção de bug
                    if (funcionario.Restaurante == null)
                        funcionario.Restaurante = new Restaurante();

                    string[] row = buildDataGridRow(funcionario);
                    funcionarios_DataGridView.Rows.Add(row);
                }

                if (funcionarios_DataGridView.Rows.Count > 0)
                    funcionarios_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void Adicionar_BTN_Click(object sender, EventArgs e)
        {
            new FormFuncionario().ShowDialog();
            if (filtrar_TextBox.Text.Length > 0)
            {
                filtrar_BTN_Click(sender, e);
            }
            else
            {
                ReloadDataGridView();
            }
        }

        private void filtrar_BTN_Click(object sender, EventArgs e)
        {
            funcionarios_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Trabalhador> funcionarios = (IdRestauranteFiltro < 1 ?
                    databaseContainer.Pessoas.OfType<Trabalhador>().Where(funcionario => funcionario.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper()) && funcionario.Ativo) :
                    databaseContainer.Pessoas.OfType<Trabalhador>().Where(funcionario => funcionario.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper()) && funcionario.Ativo && funcionario.RestauranteId == this.IdRestauranteFiltro)).ToList();

                funcionarios_DataGridView.Rows.Clear();
                foreach (Trabalhador funcionario in funcionarios)
                {
                    //Prevenção de bug
                    if (funcionario.Restaurante == null)
                        funcionario.Restaurante = new Restaurante();

                    string[] row = buildDataGridRow(funcionario);
                    funcionarios_DataGridView.Rows.Add(row);
                }

                if (funcionarios_DataGridView.Rows.Count > 0)
                    funcionarios_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private string[] buildDataGridRow(Trabalhador funcionario)
        {
            string[] row = { funcionario.Id.ToString(), funcionario.Nome, funcionario.NumContribuinte, funcionario.Posicao, funcionario.Salario.ToString(), funcionario.Restaurante.Nome };
            return row;
        }

        private void FormGestaoFuncionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
        }

        private void restaurantes_DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = funcionarios_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                funcionarios_DataGridView.ClearSelection();
                funcionarios_DataGridView.Rows[hit.RowIndex].Selected = true;
                
                if(this.Gestao)
                    Editar_BTN_Click(sender, e);
                else
                    Select_Trabalhador(sender, e);

            }
        }

        private void Select_Trabalhador(object sender, EventArgs e)
        {
            if (funcionarios_DataGridView.SelectedRows.Count == 1)
            {
                int row = funcionarios_DataGridView.SelectedRows[0].Index;
                int idTrabalhador = int.Parse(funcionarios_DataGridView.Rows[row].Cells[0].Value.ToString());
                this.returnTrabalhador = this.databaseContainer.Pessoas.OfType<Trabalhador>().Where(t => t.Id == idTrabalhador).First();
                this.Close();
            }
        }

        private void Editar_BTN_Click(object sender, EventArgs e)
        {
            if (funcionarios_DataGridView.SelectedRows.Count == 1)
            {
                int row = funcionarios_DataGridView.SelectedRows[0].Index;
                int idTrabalhador = int.Parse(funcionarios_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormFuncionario(idTrabalhador).ShowDialog();
                if (filtrar_TextBox.Text.Length > 0)
                {
                    filtrar_BTN_Click(sender, e);
                }
                else
                {
                    ReloadDataGridView();
                }
            }
        }

        private void Remover_BTN_Click(object sender, EventArgs e)
        {
            if (funcionarios_DataGridView.SelectedRows.Count == 1)
            {
                string nome = funcionarios_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show("Tem a certeza que pertende remover o funcionario \"" + nome + "\"?", "Remover funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id_funcionario = int.Parse(funcionarios_DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    Trabalhador trabalhadorARemover = databaseContainer.Pessoas.OfType<Trabalhador>().First(funcionario => funcionario.Id == id_funcionario);
                    if (validarFuncionario(id_funcionario))
                    {
                        trabalhadorARemover.Ativo = false;
                    }
                    else
                    {
                        if (trabalhadorARemover.Restaurante.Nome == null)
                        {
                            trabalhadorARemover.Restaurante.Nome = "";
                            trabalhadorARemover.Restaurante.NumContribuinte = "";
                        }
                        //
                        databaseContainer.Pessoas.Remove(trabalhadorARemover);
                    }

                    try
                    {
                        databaseContainer.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        MessageBox.Show("Erro guardando dados", "Remoce Worker Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        foreach (var ev in ex.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type " + ev.Entry.Entity.GetType().Name + " in state " + ev.Entry.State + " has the following validation errors:");
                            foreach (var ve in ev.ValidationErrors)
                                Console.WriteLine("- Property: " + ve.PropertyName + ", Error: " + ve.ErrorMessage);
                        }
                    }
                    //
                    if (filtrar_TextBox.Text.Length > 0)
                    {
                        filtrar_BTN_Click(sender, e);
                    }
                    else
                    {
                        ReloadDataGridView();
                    };
                }
            }
        }

        private bool validarFuncionario(int id_funcionario)
        {
            bool result = false;

            result = databaseContainer.Pedidos.Where(p => p.TrabalhadorId == id_funcionario).Count() > 0;

            return result;
        }

        private void LimparFiltro_BTN_Click(object sender, EventArgs e)
        {
            filtrar_TextBox.Clear();
            ReloadDataGridView();
        }

        private void FormGestaoFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormBack.Show();
        }
    }
}
