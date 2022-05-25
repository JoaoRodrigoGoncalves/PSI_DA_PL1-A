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
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void bt_categoria_Click(object sender, EventArgs e)
        {
            new FormGestaoCategorias(true).ShowDialog();
        }

        private void bt_produtos_Click(object sender, EventArgs e)
        {
            //new FormGestaoProdutos().ShowDialog();
        }
    }
}
