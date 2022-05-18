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
    public partial class FormGestaoFuncionarios : Form
    {
        public FormGestaoFuncionarios()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // Open new form to create new Trabalhador
            new FormFuncionario().ShowDialog();
            //Update DataGridView
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            //Get selected element from the GridView and cast
            Trabalhador trabalhador = new Trabalhador();
            //Send to the new form
            new FormFuncionario(trabalhador).ShowDialog();
            //Update DataGridView
        }

    }
}
