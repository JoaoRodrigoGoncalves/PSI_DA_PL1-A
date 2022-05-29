using RestGest.GestaoCategorias;
using System;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_GestaoRestaurantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoRestaurantes(this, true).ShowDialog();
        }

        private void btn_GestaoFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoFuncionarios(this).ShowDialog();
        }

        private void btn_GestaoCategorias_Click(object sender, EventArgs e)
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

        private void btn_GestaoClientes_Click(object sender, EventArgs e)
        {
            new FormGestaoClientes().ShowDialog();
        }

        private void btn_MetodoPagamento_Click(object sender, EventArgs e)
        {
            new FormGestaoMetodosPagamentos().ShowDialog();
        }

        private void btn_Produtos_Click(object sender, EventArgs e)
        {
            new FormGestaoProdutos().ShowDialog();
        }
    }
}
