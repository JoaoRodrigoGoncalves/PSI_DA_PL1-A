﻿using RestGest.GestaoRestaurantes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGestaoFuncionarios : Form
    {
        private RestGestContainer databaseContainer;

        public FormGestaoFuncionarios()
        {
            InitializeComponent();
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
                foreach (Trabalhador funcionario in databaseContainer.Pessoas.OfType<Trabalhador>().Where(x => x.Ativo == true))
                {
                    string[] row = { funcionario.Id.ToString(), funcionario.Nome, funcionario.Posicao, funcionario.Salario.ToString(), funcionario.Restaurante.Nome};
                    funcionarios_DataGridView.Rows.Add(row);
                }

                if (funcionarios_DataGridView.Rows.Count > 0)
                    funcionarios_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void Adicionar_BTN_Click(object sender, EventArgs e)
        {
            new FormRegistoRestaurante().ShowDialog();
            ReloadDataGridView();
        }

        private void filtrar_BTN_Click(object sender, EventArgs e)
        {
            funcionarios_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Trabalhador> funcionarios = databaseContainer.Pessoas.OfType<Trabalhador>().Where(funcionario => funcionario.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper())).ToList();

                funcionarios_DataGridView.Rows.Clear();
                foreach (Trabalhador funcionario in funcionarios)
                {
                    string[] row = { funcionario.Id.ToString(), funcionario.Nome, funcionario.Posicao, funcionario.Salario.ToString(), funcionario.Restaurante.Nome };
                    funcionarios_DataGridView.Rows.Add(row);
                }

                if (funcionarios_DataGridView.Rows.Count > 0)
                    funcionarios_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
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
                Editar_BTN_Click(sender, e);
            }
        }

        private void restaurantes_DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = funcionarios_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                funcionarios_DataGridView.ClearSelection();
                funcionarios_DataGridView.Rows[hit.RowIndex].Selected = true;
            }
        }

        private void Editar_BTN_Click(object sender, EventArgs e)
        {
            if (funcionarios_DataGridView.SelectedRows.Count == 1)
            {
                int row = funcionarios_DataGridView.SelectedRows[0].Index;
                int idTrabalhador = int.Parse(funcionarios_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormFuncionario(idTrabalhador).ShowDialog();
                ReloadDataGridView();
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
                    if(databaseContainer.Pedidos.Where(p => p.TrabalhadorId == id_funcionario).Count() > 0)
                    {
                        trabalhadorARemover.Ativo = false;
                    }
                    else
                    {
                        databaseContainer.Pessoas.Remove(trabalhadorARemover);
                    }

                    databaseContainer.SaveChanges();
                    ReloadDataGridView();
                }
            }
        }

        private void LimparFiltro_BTN_Click(object sender, EventArgs e)
        {
            filtrar_TextBox.Clear();
            ReloadDataGridView();
        }
    }
}