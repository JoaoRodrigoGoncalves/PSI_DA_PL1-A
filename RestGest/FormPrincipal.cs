﻿using RestGest.GestaoCategorias;
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
        private Cliente Sel_Cliente;
        private Trabalhador Sel_Trabalhador;
        private Restaurante Sel_Restaurante;
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
        }

        private void bt_del_item_Click(object sender, EventArgs e)
        {
            if (lb_items.SelectedItem == null)
                return;

            lb_items.Items.Remove(lb_items.SelectedItem);
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
    }
}
