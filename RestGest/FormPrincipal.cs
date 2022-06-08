using RestGest.GestaoCategorias;
using RestGest.GestaoClientes;
using RestGest.GestaoMetodosPagamentos;
using RestGest.GestaoRestaurantes;
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

        private void registarRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRegistoRestaurante().ShowDialog();
        }

        private void listaDeRestaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoRestaurantes(this, true).ShowDialog();
        }

        private void registarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFuncionario().ShowDialog();
        }

        private void listaDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoFuncionarios(this).ShowDialog();
        }

        private void registarMétodoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistarMetodosPagamento().ShowDialog();
        }

        private void listaDeMétodosDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoMetodosPagamentos().ShowDialog();
        }

        private void registarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRegistoProduto().ShowDialog();
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoProdutos().ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoCategorias(this, true).ShowDialog();
        }

        private void registarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRegistoCliente().ShowDialog();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoClientes().ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
