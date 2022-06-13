using RestGest.GestaoCategorias;
using RestGest.GestaoClientes;
using RestGest.GestaoMetodosPagamentos;
using RestGest.GestaoRestaurantes;
using System;
using System.Linq;
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
            new FormGestaoFuncionarios(this, true).ShowDialog();
        }

        private void registarMétodoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistarMetodosPagamento().ShowDialog();
        }

        private void listaDeMétodosDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoMetodosPagamentos(this).ShowDialog();
        }

        private void registarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoProdutos(this).ShowDialog();
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
            new FormGestaoClientes(this, true).ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            RestGestContainer dataGestContainer = new RestGestContainer();
            foreach (Categoria categoria in dataGestContainer.Categorias.Where(c => c.Ativo))
            {
                Button button = new Button();
                button.Text = categoria.Nome;
                button.Tag = categoria;
                button.Size = new System.Drawing.Size(75, flowLayoutPanel1.Size.Height -1);
                button.Click += LoadProdutos;
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void LoadProdutos(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Categoria categoria = (Categoria)button.Tag;
            //
            flowLayoutPanel2.Controls.Clear();
            //
            RestGestContainer dataGestContainer = new RestGestContainer();
            foreach (ItemMenu itemMenu in dataGestContainer.ItemsMenus.Where(c => c.Ativo && c.CategoriaId == categoria.Id))
            {
                Button button_item = new Button();
                button_item.Text = itemMenu.Nome;
                button_item.Tag = itemMenu;
                button_item.Size = new System.Drawing.Size(75, 75);
                button_item.Click += AddToList;
                flowLayoutPanel2.Controls.Add(button_item);
            }
        }

        private void AddToList(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ItemMenu itemMenu = (ItemMenu)button.Tag;

            lb_items.Items.Add(itemMenu);
            lb_items.TopIndex = lb_items.Items.Count - 1;
        }
    }
}
