﻿using System;
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
    public partial class FormGestaoFuncionarios : Form
    {
        private RestGestContainer databaseContainer;

        public FormGestaoFuncionarios()
        {
            InitializeComponent();
        }

        private void FormGestaoFuncionarios_Load(object sender, EventArgs e)
        {
            LoadFuncionariosData();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // Open new form to create new Trabalhador
            new FormFuncionario().ShowDialog();
            //Update DataGridView
            LoadFuncionariosData();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (dataGrid_Funcionarios.SelectedRows.Count == 1)
            {
                int row = dataGrid_Funcionarios.SelectedRows[0].Index;
                int idTrabalhador = int.Parse(dataGrid_Funcionarios.Rows[row].Cells[0].Value.ToString());
                //Send to the new form
                new FormFuncionario(idTrabalhador).ShowDialog();
                //Update DataGridView
                LoadFuncionariosData();
            }
        }

        private void LoadFuncionariosData()
        {
            databaseContainer = new RestGestContainer();

            dataGrid_Funcionarios.Invoke(new MethodInvoker(delegate
            {
                //LoadingPopUp_Panel.Visible = true;

                dataGrid_Funcionarios.Rows.Clear();
                foreach (Trabalhador trabalhador in databaseContainer.Pessoas.OfType<Trabalhador>())
                {
                    string[] row = { trabalhador.Id.ToString(), trabalhador.Nome, trabalhador.Telemovel, 
                        trabalhador.Morada.ToString(), trabalhador.Salario.ToString(), trabalhador.Posicao, 
                        databaseContainer.Restaurantes.Find(trabalhador.RestauranteId).Nome};
                    dataGrid_Funcionarios.Rows.Add(row);
                }

                if (dataGrid_Funcionarios.Rows.Count > 0)
                    dataGrid_Funcionarios.Rows[0].Selected = true;

                //LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void dataGrid_Funcionarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = dataGrid_Funcionarios.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                dataGrid_Funcionarios.ClearSelection();
                dataGrid_Funcionarios.Rows[hit.RowIndex].Selected = true;
                bt_edit_Click(sender, e);
            }
        }

        private void dataGrid_Funcionarios_MouseClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = dataGrid_Funcionarios.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                dataGrid_Funcionarios.ClearSelection();
                dataGrid_Funcionarios.Rows[hit.RowIndex].Selected = true;
            }
        }
    }
}