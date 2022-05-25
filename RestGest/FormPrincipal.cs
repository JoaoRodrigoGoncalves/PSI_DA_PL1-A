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
    }
}
