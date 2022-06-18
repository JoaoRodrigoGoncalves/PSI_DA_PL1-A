using RestGest.GestaoCategorias;
using RestGest.GestaoClientes;
using RestGest.GestaoMetodosPagamentos;
using RestGest.GestaoPagamento;
using RestGest.GestaoPedidos;
using RestGest.GestaoRestaurantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormPrincipal : Form
    {
        private RestGestContainer databaseContainer;
        private Cliente Sel_Cliente;
        private Trabalhador Sel_Trabalhador;
        private Restaurante Sel_Restaurante;
        private Pedido Update_Pedido;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void registarRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRestaurante().ShowDialog();
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
            new FormMetodoPagamento().ShowDialog();
        }

        private void listaDeMétodosDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoMetodosPagamentos(this).ShowDialog();
        }

        private void registarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
            LoadCategorias();
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoProdutos(this).ShowDialog();
            LoadCategorias();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormGestaoCategorias(this, true).ShowDialog();
            LoadCategorias();
        }

        private void registarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCliente().ShowDialog();
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
            this.databaseContainer = new RestGestContainer();
            LoadCategorias();
        }

        private void LoadCategorias()
        {
            RestGestContainer dataGestContainer = new RestGestContainer();
            foreach (Categoria categoria in dataGestContainer.Categorias.Where(c => c.Ativo))
            {
                Button button = new Button();
                button.Text = categoria.Nome;
                button.Tag = categoria;
                button.Size = new System.Drawing.Size(75, flowLayoutPanel1.Size.Height - 5);
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
            //
            GetTotal();
        }

        private void bt_del_item_Click(object sender, EventArgs e)
        {
            if (lb_items.SelectedItem == null)
                return;

            lb_items.Items.Remove(lb_items.SelectedItem);
            //
            GetTotal();
        }

        private void GetTotal()
        {
            //
            decimal total = 0;
            foreach (ItemMenu itemMenu in lb_items.Items.Cast<ItemMenu>().ToList())
                total += itemMenu.Preco;
            //
            tb_total.Text = total.ToString();
        }

        private void bt_select_cliente_Click(object sender, EventArgs e)
        {
            FormGestaoClientes formCliente = new FormGestaoClientes(this, false);
            formCliente.ShowDialog();
            Cliente sel_cliente = formCliente.returnCliente;
            if(sel_cliente != null)
            {
                this.Sel_Cliente = sel_cliente;
                tb_cliente.Text = this.Sel_Cliente.Id + " | " + this.Sel_Cliente.Nome;
            }
        }

        private void bt_select_empregado_Click(object sender, EventArgs e)
        {
            FormGestaoFuncionarios formFunc = new FormGestaoFuncionarios(this, false);
            formFunc.ShowDialog();
            Trabalhador sel_trabalhador = formFunc.returnTrabalhador;
            if (sel_trabalhador != null)
            {
                this.Sel_Trabalhador = sel_trabalhador;
                tb_empregado.Text = this.Sel_Trabalhador.Id + " | " + this.Sel_Trabalhador.Nome;
            }
        }

        private void bt_concluir_pedido_Click(object sender, EventArgs e)
        {
            if (!ValidatePedido())
                return;

            if(this.Update_Pedido == null)
            {
                Pedido new_pedido = new Pedido();
                //Set pedido estado
                Estado sel_Estado = this.databaseContainer.Estados.Find(2);
                new_pedido.Estado = sel_Estado;
                new_pedido.EstadoId = sel_Estado.Id;
                //TODO Make Select Restaurant method
                //Set restaurante
                Restaurante sel_restaurante = this.databaseContainer.Restaurantes.Find(1);
                new_pedido.Restaurante = sel_restaurante; //this.Sel_Restaurante;
                new_pedido.RestauranteId = sel_restaurante.Id;
                //Set cliente info
                new_pedido.Cliente = this.Sel_Cliente;
                new_pedido.ClienteId = this.Sel_Cliente.Id;
                //Set trabalhador info
                new_pedido.Trabalhador = this.Sel_Trabalhador;
                new_pedido.TrabalhadorId = this.Sel_Trabalhador.Id;
                //Set list items
                foreach (ItemMenu item in lb_items.Items.Cast<ItemMenu>().ToList())
                    new_pedido.ItemMenu.Add(item);
                //Initialize payment list
                new_pedido.Pagamento = new List<Pagamento>();
                //Get payment method
                FormPagamento pay_form = new FormPagamento(new_pedido); 
                pay_form.ShowDialog();
                List<Pagamento> listaPagamentos = pay_form.resturnPaymentList;
                //Validate list
                if (listaPagamentos == null || listaPagamentos.Count <= 0)
                    return;
                //Save Pedido
                try
                {
                    new_pedido = this.databaseContainer.Pedidos.Add(new_pedido);
                    this.databaseContainer.SaveChanges();
                    //Add payment list to pedido
                    listaPagamentos.ForEach(p => p.Pedido = new_pedido);
                    this.databaseContainer.Pagamentos.AddRange(listaPagamentos);                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error a concluir o pedido.\nContactar administrador\n" + ex.Message, 
                        "Erro Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
        }

        private bool ValidatePedido()
        {
            if (String.IsNullOrEmpty(tb_cliente.Text))
            {
                MessageBox.Show("Valida o cliente do pedido", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (String.IsNullOrEmpty(tb_empregado.Text))
            {
                MessageBox.Show("Valida o trabalhador do pedido", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (lb_items.Items.Count <= 0)
            {
                MessageBox.Show("Sem items no pedido.\nInsira items para criar um pedido.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void listaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestaoPedidos(this, true).ShowDialog();
        }
    }
}
