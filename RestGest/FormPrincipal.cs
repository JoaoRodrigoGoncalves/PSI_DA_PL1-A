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
            if (lb_items.SelectedItem == null) {
                MessageBox.Show("Selecione o item que quere eliminar","Delete Pedido Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

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

        //Constroe um novo pedido
        private Pedido BuildPedido(Estado estado)
        {
            Pedido new_pedido = new Pedido();

            //Set estado
            new_pedido.Estado = estado;

            //TODO Make Select Restaurant method
            //Get restaurante
            Restaurante sel_restaurante = this.databaseContainer.Restaurantes.Find(1);
            //Build restaurante
            Restaurante set_restaurante = new Restaurante();
            set_restaurante.Id = sel_restaurante.Id;
            set_restaurante.Nome = sel_restaurante.Nome;
            set_restaurante.NumContribuinte = sel_restaurante.NumContribuinte;

            //Set the restaurant
            new_pedido.Restaurante = set_restaurante;

            //Build Cliente
            Cliente set_Cliente = new Cliente();
            set_Cliente.Id = this.Sel_Cliente.Id;
            set_Cliente.Nome = this.Sel_Cliente.Nome;
            set_Cliente.Telemovel = this.Sel_Cliente.Telemovel;
            set_Cliente.NumContribuinte = this.Sel_Cliente.NumContribuinte;
            //Set cliente
            new_pedido.Cliente = set_Cliente;

            //Build Trabalhador
            Trabalhador set_trabalhador = new Trabalhador();
            set_trabalhador.Id = this.Sel_Trabalhador.Id;
            set_trabalhador.Nome = this.Sel_Trabalhador.Nome;
            set_trabalhador.Telemovel = this.Sel_Trabalhador.Telemovel;
            set_trabalhador.NumContribuinte = this.Sel_Trabalhador.NumContribuinte;
            set_trabalhador.Posicao = this.Sel_Trabalhador.Posicao;
            //Set trabalhador
            new_pedido.Trabalhador = set_trabalhador;

            new_pedido.ItemMenu = new List<ItemMenu>();
            //Set list items
            foreach (ItemMenu item in lb_items.Items.Cast<ItemMenu>().ToList())
            {
                //Build ItemMenu
                ItemMenu set_item = new ItemMenu();
                set_item.Id = item.Id;
                set_item.Nome = item.Nome;
                set_item.Preco = item.Preco;
                set_item.Categoria = item.Categoria;

                //Build Categoria
                /*Categoria set_categoria = new Categoria();
                set_categoria.Id = item.Categoria.Id;
                set_categoria.Nome = item.Categoria.Nome
                //Set Categoria
                set_item.Categoria = set_categoria;*/

                //Set Item
                new_pedido.ItemMenu.Add(set_item);
            }

            return new_pedido;
        }

        private void bt_concluir_pedido_Click(object sender, EventArgs e)
        {
            if (!ValidatePedido())
                return;


            //Get pedido estado
            Estado default_estado = this.databaseContainer.Estados.Find(2);

            if (this.Update_Pedido == null)
            {
                Pedido new_pedido = BuildPedido(default_estado);                

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
                    //TODO WARNING It Duplicate Cliente, Empregado, Restaurante, ItemMenu, Categoria data on de dataBase
                    if (MessageBox.Show("WARNING!\nVai criar um novo pedido. Isto ira duplicar dados na base de dados até corregir o bug.\nTem a certeza que quere concluir o pedido?", "Criação de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;
                    new_pedido = this.databaseContainer.Pedidos.Add(new_pedido);
                    this.databaseContainer.SaveChanges();
                    //Add payment list to pedido
                    listaPagamentos.ForEach(p => p.Pedido = new_pedido);
                    this.databaseContainer.Pagamentos.AddRange(listaPagamentos);
                    this.databaseContainer.SaveChanges();
                    ClearPedidoData();
                }
                catch (Exception ex)
                {
                    //TODO Delete ex message once code debug
                    MessageBox.Show("Error a concluir o pedido.\nContactar administrador\n" + ex.Message, 
                        "Erro Finalizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //TODO Atualizar Pedidos já existentes

            }
        }

        private void bt_pendente_pedido_Click(object sender, EventArgs e)
        {
            if (this.Update_Pedido == null)
            {

            }
            else
            {

            }
        }
        
        private void ClearPedidoData()
        {
            tb_cliente.Text = "";
            tb_empregado.Text = "";
            lb_items.Items.Clear();
            this.Update_Pedido = null;
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

        private void continuarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestaoPedidos form = new FormGestaoPedidos(this, false);
            form.ShowDialog();
            Pedido tmp_pedido = form.returnPedido;
            if (tmp_pedido == null)
                return;
            this.Update_Pedido = tmp_pedido;
            LoadUpdatePedido();
        }

        private void LoadUpdatePedido()
        {
            gb_fatura.Text = "Pedido Nº" + this.Update_Pedido.Id.ToString();
            tb_cliente.Text = this.Update_Pedido.Cliente.ToString();
            tb_empregado.Text = this.Update_Pedido.Trabalhador.ToString();
            lb_items.Items.AddRange(this.Update_Pedido.ItemMenu != null ? this.Update_Pedido.ItemMenu.ToArray() : new List<ItemMenu>().ToArray());
            tb_total.Text = this.Update_Pedido.GetTotalValue().ToString();
        }

    }
}
