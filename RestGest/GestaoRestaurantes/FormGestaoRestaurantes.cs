using RestGest.GestaoRestaurantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGestaoRestaurantes : Form
    {
        private RestGestContainer databaseContainer;

        public FormGestaoRestaurantes()
        {
            InitializeComponent();
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
                foreach (Restaurante restaurante in databaseContainer.Restaurantes)
                {
                    string[] row = { restaurante.Id.ToString(), restaurante.Nome, restaurante.Morada.ToString(), "0", "0" };
                    restaurantes_DataGridView.Rows.Add(row);
                }

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
            LoadingPopUp_Panel.Visible = !LoadingPopUp_Panel.Visible;
        }

        private void FormGestaoRestaurantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseContainer.Dispose();
        }
    }
}
