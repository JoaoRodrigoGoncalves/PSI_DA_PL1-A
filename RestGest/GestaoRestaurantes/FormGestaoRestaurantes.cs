﻿using RestGest.GestaoRestaurantes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGestaoRestaurantes : Form
    {
        public Categoria returnRestaurante;
        private RestGestContainer databaseContainer;
        private bool FormGestao;

        public FormGestaoRestaurantes(bool gestao)
        {
            InitializeComponent();
            this.FormGestao = gestao;
            activeFuntion(this.FormGestao);
        }

        private void activeFuntion(bool active)
        {
            Adicionar_BTN.Enabled = active;
            Editar_BTN.Enabled = active;
            Remover_BTN.Enabled = active;
            Selecionar_BTN.Enabled = !active;
        }

        private void FormGestaoRestaurantes_Shown(object sender, EventArgs e)
        {
            Thread loadingThread = new Thread(ReloadDataGridView);
            loadingThread.Start();
        }

        private void ReloadDataGridView()
        {
            databaseContainer = new RestGestContainer();


            restaurantes_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                restaurantes_DataGridView.Rows.Clear();
                foreach (Categoria restaurante in databaseContainer.Restaurantes.Where(x => x.Ativo == true))
                {
                    string[] row = { restaurante.Id.ToString(), restaurante.Nome, restaurante.Morada.ToString(), "0", "0" };
                    restaurantes_DataGridView.Rows.Add(row);
                }

                if (restaurantes_DataGridView.Rows.Count > 0)
                    restaurantes_DataGridView.Rows[0].Selected = true;

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
            restaurantes_DataGridView.Invoke(new MethodInvoker(delegate
            {
                LoadingPopUp_Panel.Visible = true;

                List<Categoria> restaurantes = databaseContainer.Restaurantes.Where(restaurante => restaurante.Nome.ToUpper().Contains(filtrar_TextBox.Text.ToUpper()) && restaurante.Ativo == true).ToList();

                restaurantes_DataGridView.Rows.Clear();
                foreach (Categoria restaurante in restaurantes)
                {
                    string[] row = { restaurante.Id.ToString(), restaurante.Nome, restaurante.Morada.ToString(), "0", "0" };
                    restaurantes_DataGridView.Rows.Add(row);
                }

                if (restaurantes_DataGridView.Rows.Count > 0)
                    restaurantes_DataGridView.Rows[0].Selected = true;

                LoadingPopUp_Panel.Visible = false;
            }));
        }

        private void FormGestaoRestaurantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
        }

        private void restaurantes_DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = restaurantes_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                restaurantes_DataGridView.ClearSelection();
                restaurantes_DataGridView.Rows[hit.RowIndex].Selected = true;
                //Filtra o tipo de ação 
                if (this.FormGestao)
                    Editar_BTN_Click(sender, e);
                else
                    Selecionar_BTN_Click(sender, e);
            }
        }

        private void restaurantes_DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            // Adaptado de https://github.com/JoaoRodrigoGoncalves/Summaries/blob/36888d50c8dc7f1f9a9d257123688d23de7ce6b9/Summaries/administration/AdministrationMenu.cs#L759
            // Acedido em 19/05/2022
            var hit = restaurantes_DataGridView.HitTest(e.X, e.Y);
            if (hit.RowIndex != -1)
            {
                restaurantes_DataGridView.ClearSelection();
                restaurantes_DataGridView.Rows[hit.RowIndex].Selected = true;
            }
        }

        private void Editar_BTN_Click(object sender, EventArgs e)
        {
            if (restaurantes_DataGridView.SelectedRows.Count == 1)
            {
                int row = restaurantes_DataGridView.SelectedRows[0].Index;
                int idRestaurante = int.Parse(restaurantes_DataGridView.Rows[row].Cells[0].Value.ToString());
                new FormEdicaoRestaurante(idRestaurante).ShowDialog();
                ReloadDataGridView();
            }
        }

        private void Remover_BTN_Click(object sender, EventArgs e)
        {
            if (restaurantes_DataGridView.SelectedRows.Count == 1)
            {
                string nome = restaurantes_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show("Tem a certeza que pertende remover o restaurante \"" + nome + "\"?", "Remover restaurante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int restaurante_id = int.Parse(restaurantes_DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    Categoria restauranteRemover = databaseContainer.Restaurantes.Find(restaurante_id);
                    if(databaseContainer.Pedidos.Where(p => p.RestauranteId == restaurante_id).Count() > 0)
                    {
                        restauranteRemover.Ativo = false;
                    }
                    else
                    {
                        databaseContainer.Restaurantes.Remove(restauranteRemover);
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

        private void Selecionar_BTN_Click(object sender, EventArgs e)
        {
            if (restaurantes_DataGridView.SelectedRows.Count == 1)
            {
                int row = restaurantes_DataGridView.SelectedRows[0].Index;
                int idRestaurante = int.Parse(restaurantes_DataGridView.Rows[row].Cells[0].Value.ToString());
                this.returnRestaurante = databaseContainer.Restaurantes.Find(idRestaurante);
                this.Close();
            }
        }
    }
}
