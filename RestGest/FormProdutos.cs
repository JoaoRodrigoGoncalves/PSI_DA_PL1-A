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
    public partial class FormProdutos : Form
    {
        private Form FormBack;
        public FormProdutos(Form formBack)
        {
            InitializeComponent();
            this.FormBack = formBack;
        }

        private void bt_categoria_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormGestaoCategorias(this.FormBack, true).ShowDialog();
        }

        private void bt_produtos_Click(object sender, EventArgs e)
        {
            //new FormGestaoProdutos().ShowDialog();
        }
    }
}
