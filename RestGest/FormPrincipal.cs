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
        private Pedido Update_Pedido;

        public FormPrincipal()
        {
            InitializeComponent();
        }


        #region ToolStripMenu
        private void registarRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRestaurante().ShowDialog();
        }

        private void listaDeRestaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestaoRestaurantes(this, true).ShowDialog();
        }

        private void registarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFuncionario().ShowDialog();
        }

        private void listaDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestaoFuncionarios(this, true).ShowDialog();
        }

        private void registarMétodoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormMetodoPagamento().ShowDialog();
        }

        private void listaDeMétodosDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestaoMetodosPagamentos(this).ShowDialog();
        }

        private void registarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
            LoadCategorias();
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestaoProdutos(this).ShowDialog();
            LoadCategorias();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestaoCategorias(this, true).ShowDialog();
            LoadCategorias();
        }

        private void registarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCliente().ShowDialog();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestaoClientes(this, true).ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestaoPedidos(this, true).ShowDialog();
        }
        #endregion


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.databaseContainer = new RestGestContainer();
            ClearPedidoData();
            LoadCategorias();
        }

        private void LoadCategorias()
        {
            RestGestContainer dataGestContainer = new RestGestContainer();
            flowLayoutPanel1.Controls.Clear();
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
            flowLayoutPanel2.Controls.Clear();

            RestGestContainer dataGestContainer = new RestGestContainer();
            foreach (ItemMenu itemMenu in dataGestContainer.ItemsMenus.Where(c => c.Ativo &&
                c.CategoriaId == categoria.Id &&
                c.Restaurante.Any(r => r.Id == Sel_Trabalhador.RestauranteId)
            ))
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
            GetTotal();
        }

        private void GetTotal()
        {
            decimal total = 0;
            foreach (ItemMenu itemMenu in lb_items.Items.Cast<ItemMenu>().ToList())
                total += itemMenu.Preco;
            tb_total.Text = total.ToString();
        }

        private void ClearPedidoData()
        {
            tb_cliente.Clear();
            tb_empregado.Clear();
            tb_Restaurante.Clear();
            lb_items.Items.Clear();
            tb_total.Clear();
            flowLayoutPanel2.Controls.Clear(); // Limpar itens da seleção de produto
            flowLayoutPanel1.Enabled = false;
            this.Update_Pedido = null;
        }

        private bool ValidatePedido()
        {
            if (String.IsNullOrEmpty(tb_cliente.Text))
            {
                MessageBox.Show("Por favor, selecione um cliente", "Selecione um cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(tb_empregado.Text))
            {
                MessageBox.Show("Por favor, selecione um funcionário", "Selecione um funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lb_items.Items.Count <= 0)
            {
                MessageBox.Show("Por favor, adicione produtos à lista antes de finalizar o pedido", "Pedido Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadUpdatePedido()
        {
            gb_fatura.Text = "Pedido Nº" + this.Update_Pedido.Id.ToString();
            tb_cliente.Text = this.Update_Pedido.Cliente.ToString();
            tb_empregado.Text = this.Update_Pedido.Trabalhador.ToString();
            tb_Restaurante.Text = this.Update_Pedido.Restaurante.Nome;
            lb_items.Items.AddRange(databaseContainer.ItemPedidos.Where(itemPedidos => itemPedidos.PedidoId == this.Update_Pedido.Id) != null ? this.Update_Pedido.ItemPedido.Where(itemPedidos => itemPedidos.PedidoId == this.Update_Pedido.Id).ToArray() : new List<ItemPedido>().ToArray());
            tb_total.Text = this.Update_Pedido.GetTotalValue().ToString();
            flowLayoutPanel1.Enabled = true;
        }

        private int ProcessarPedido()
        {
            if (ValidatePedido())
            {
                if (Update_Pedido == null)
                {

                    Pedido new_pedido = new Pedido();
                    new_pedido.Estado = databaseContainer.Estados.Find(1); // Estado "Aberto"
                    new_pedido.Restaurante = databaseContainer.Restaurantes.Find(Sel_Trabalhador.Restaurante.Id);
                    new_pedido.Cliente = databaseContainer.Pessoas.OfType<Cliente>().Where(c => c.Id == Sel_Cliente.Id).First();
                    new_pedido.Trabalhador = databaseContainer.Pessoas.OfType<Trabalhador>().Where(t => t.Id == Sel_Trabalhador.Id).First();

                    databaseContainer.Pedidos.Add(new_pedido);
                    databaseContainer.SaveChanges();


                    foreach (ItemMenu item in lb_items.Items)
                    {
                        ItemPedido itemPedido = new ItemPedido();
                        itemPedido.ItemMenuId = item.Id;
                        itemPedido.PedidoId = new_pedido.Id;

                        databaseContainer.ItemPedidos.Add(itemPedido);
                    }

                    // Guardar Pedido
                    try
                    {
                        databaseContainer.SaveChanges();
                        ClearPedidoData();
                        return new_pedido.Id;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Ocurreu um erro ao registar o pedido.", "Erro Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Pedido já aberto

                    // Atualizar dados
                    Update_Pedido.Restaurante = databaseContainer.Restaurantes.Find(Sel_Trabalhador.Restaurante.Id);
                    Update_Pedido.Cliente = databaseContainer.Pessoas.OfType<Cliente>().Where(c => c.Id == Sel_Cliente.Id).First();
                    Update_Pedido.Trabalhador = databaseContainer.Pessoas.OfType<Trabalhador>().Where(t => t.Id == Sel_Trabalhador.Id).First();

                    Update_Pedido.ItemPedido.Clear();
                    foreach (ItemMenu item in lb_items.Items.Cast<ItemMenu>().ToList())
                    {
                        Update_Pedido.ItemPedido.Add(databaseContainer.ItemPedidos.Find(item.Id));
                    }

                    // Guardar Pedido
                    try
                    {
                        databaseContainer.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Ocurreu um erro ao registar o pedido.", "Erro Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    int id = Update_Pedido.Id;
                    Update_Pedido = null;
                    ClearPedidoData();
                    return id;
                }
            }
            return -1;
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (lb_items.SelectedItem == null)
            {
                MessageBox.Show("Selecione o item que pretende eliminar", "Remover item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lb_items.Items.Remove(lb_items.SelectedItem);
            GetTotal();
        }

        private void selectClient_Click(object sender, EventArgs e)
        {
            FormGestaoClientes formCliente = new FormGestaoClientes(this, false);
            formCliente.ShowDialog();
            Cliente sel_cliente = formCliente.returnCliente;
            if (sel_cliente != null)
            {
                Sel_Cliente = sel_cliente;
                tb_cliente.Text = Sel_Cliente.ToString();
            }
        }

        private void selectFuncionario_Click(object sender, EventArgs e)
        {
            FormGestaoFuncionarios formFunc = new FormGestaoFuncionarios(this, false);
            formFunc.ShowDialog();
            Trabalhador sel_trabalhador = formFunc.returnTrabalhador;
            if (sel_trabalhador != null)
            {
                this.Sel_Trabalhador = sel_trabalhador;
                tb_empregado.Text = Sel_Trabalhador.ToString();
                tb_Restaurante.Text = Sel_Trabalhador.Restaurante.Nome;
                flowLayoutPanel1.Enabled = true;
                flowLayoutPanel2.Controls.Clear();
            }
        }

        private void bt_concluir_pedido_Click(object sender, EventArgs e)
        {
            int id = ProcessarPedido();

            if (id == -1)
                return;

            // Abir janela de pagamentos para realizar pagamento
            FormPagamento pay_form = new FormPagamento(id);
            pay_form.ShowDialog();
        }

        private void bt_pendente_pedido_Click(object sender, EventArgs e)
        {
            ProcessarPedido();
        }

        private void BTN_continuarPedido_Click(object sender, EventArgs e)
        {
            FormGestaoPedidos form = new FormGestaoPedidos(this, false);
            form.ShowDialog();

            if(form.returnPedido != null)
            {
                Update_Pedido = databaseContainer.Pedidos.Find(form.returnPedido.Id);
                if (Update_Pedido == null)
                {
                    return;
                }
                else
                {
                    LoadUpdatePedido();
                }
            }
        }
    }
}
