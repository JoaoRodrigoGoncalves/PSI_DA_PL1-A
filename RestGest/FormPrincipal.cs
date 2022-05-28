using RestGest.GestaoCategorias;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoRestaurantes(this, true).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoFuncionarios(this).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoCategorias(this, true).ShowDialog();
            /*FormGestaoCategorias cat_form = new FormGestaoCategorias(this, false);
            cat_form.ShowDialog();
            MessageBox.Show("Categoria: " + cat_form.returnCategoriaMenu.Nome, "Test");*/
        }

        private void menuItem_gr_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoRestaurantes(this, true).ShowDialog();
        }

        private void menuItem_gf_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoFuncionarios(this).ShowDialog();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            new FormGestaoClientes().ShowDialog();
        }

        private void btnMetodoPagamento_Click(object sender, EventArgs e)
        {
            new FormGestaoMetodosPagamentos().ShowDialog();
        }
    }
}
