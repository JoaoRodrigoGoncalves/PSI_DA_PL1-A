using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RestGest.GestaoRestaurantes
{
    public partial class FormRegistoProduto : Form
    {
        private RestGestContainer databaseContainer;

        public FormRegistoProduto()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
        }

        private void FormRegistoProduto_Load(object sender, EventArgs e)
        {
            Categoria[] categorias = databaseContainer.Categorias.Where(x => x.Ativo == true).OrderBy(x => x.Nome).ToArray();

            if (categorias.Length == 0)
            {
                MessageBox.Show("Não existem categorias registadas. Crie categorias para produtos na respetiva janela antes de registar um produto!");
                Close();
            }

            Categoria_ComboBox.Items.AddRange(categorias);

            Restaurante[] restaurantes = databaseContainer.Restaurantes.Where(x => x.Ativo == true).OrderBy(x => x.Nome).ToArray();

            if (restaurantes.Length == 0)
            {
                // Não existem restaurantes registados / ativos, vamos desativar a utilização da secção de associação a restaurantes
                Restaurantes_ListBox.Enabled = false;
                Restaurantes_ComboBox.Enabled = false;
                AddRestaurante_BTN.Enabled = false;
                RmRestaurante_BTN.Enabled = false;
            }
            else
            {
                Restaurantes_ComboBox.Items.AddRange(restaurantes);
            }
        }

        private void Registar_BTN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Nome_TextBox.Text) || String.IsNullOrWhiteSpace(Preco_TextBox.Text))
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de continuar!",
                    "Campos vazios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            Preco_TextBox.Text = Preco_TextBox.Text.Replace('.', ','); // Trocar '.' por ',' (Pura UX)
            if (!decimal.TryParse(Preco_TextBox.Text, out decimal val))
            {
                MessageBox.Show(
                    "Indique um preço válido!",
                    "Preço Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            // Verificar se não existe já um item semelhante (Pura UX)
            List<ItemMenu> matches = databaseContainer.ItemsMenus.Where(produtos => produtos.Nome.Contains(Nome_TextBox.Text)).ToList();

            if (matches.Count > 0)
            {
                string msgboxMatches = "";

                foreach (ItemMenu item in matches)
                {
                    msgboxMatches += (item.Ativo ? "[Ativo] " : "[Inativo] ") + "Nome: " + item.Nome + " - " + item.Preco + "€ - " + item.Categoria.Nome + Environment.NewLine;
                }

                DialogResult result = MessageBox.Show(
                    "O item que está a tentar adicionar foi identificado como possível duplicado dos seguintes produtos já registados: " + Environment.NewLine +
                    msgboxMatches + "Deseja continuar com o registo do produto?",
                    "Possível duplicação de itens",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            ItemMenu novoProduto = new ItemMenu();
            novoProduto.Ativo = Ativo_CheckBox.Checked;
            novoProduto.Nome = Nome_TextBox.Text;
            novoProduto.Preco = val;


            ImageConverter converter = new ImageConverter();
            byte[] novaImagem = (byte[])converter.ConvertTo(Imagem_PictureBox.Image, typeof(byte[]));
            string hash_padrao, hash_novaImagem;

            using (SHA1 sha1 = SHA1.Create())
            {
                hash_padrao = BitConverter.ToString(sha1.ComputeHash((byte[])converter.ConvertTo(Properties.Resources.produto_placeholder, typeof(byte[]))));
                hash_novaImagem = BitConverter.ToString(sha1.ComputeHash(novaImagem));
            }

            novoProduto.Fotografia = (hash_novaImagem != hash_padrao ? novaImagem : null);

            if (Ingredientes_ListBox.Items.Count > 0)
            {
                List<string> ingredientes = new List<string>();

                foreach (string item in Ingredientes_ListBox.Items)
                {
                    ingredientes.Add(item);
                }

                novoProduto.Ingredientes = JsonConvert.SerializeObject(ingredientes);
            }
            else
            {
                novoProduto.Ingredientes = null;
            }

            novoProduto.Categoria = (Categoria)Categoria_ComboBox.SelectedItem;

            if (Restaurantes_ListBox.Enabled && Restaurantes_ListBox.Items.Count > 0)
            {
                foreach (Restaurante restaurante in Restaurantes_ListBox.Items)
                {
                    novoProduto.Restaurante.Add(restaurante);
                }
            }

            databaseContainer.ItemsMenus.Add(novoProduto);

            databaseContainer.SaveChanges();
            databaseContainer.Dispose();
            Close();
        }

        private void Limpar_BTN_Click(object sender, EventArgs e)
        {
            Nome_TextBox.Clear();
            Preco_TextBox.Clear();
            Imagem_PictureBox.Image = Properties.Resources.produto_placeholder;
            Ativo_CheckBox.Checked = true;
            Ingredientes_ListBox.Items.Clear();
            Ingrediente_TextBox.Clear();
            Restaurantes_ListBox.Items.Clear();
        }

        private void ReporImagem_BTN_Click(object sender, EventArgs e)
        {
            Imagem_PictureBox.Image = Properties.Resources.produto_placeholder;
        }

        private void AddItem_BTN_Click(object sender, EventArgs e)
        {
            Ingredientes_ListBox.Items.Add(Ingrediente_TextBox.Text);
            Ingrediente_TextBox.Clear();
            Ingrediente_TextBox.Focus();
        }

        private void RmItem_BTN_Click(object sender, EventArgs e)
        {
            if (Ingredientes_ListBox.SelectedItems.Count == 1)
            {
                Ingredientes_ListBox.Items.RemoveAt(Ingredientes_ListBox.SelectedIndex);
            }
        }

        private void AlterarImagem_BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione uma imagem";
            openFileDialog.Filter = "PNG (*.png)|*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ficheiro = openFileDialog.FileName;
                Imagem_PictureBox.Image = new Bitmap(ficheiro);
            }
        }

        private void AddRestaurante_BTN_Click(object sender, EventArgs e)
        {
            if (Restaurantes_ComboBox.SelectedItem == null)
                return;

            Restaurantes_ListBox.Items.Add(Restaurantes_ComboBox.SelectedItem);
            Restaurantes_ComboBox.Items.Remove(Restaurantes_ComboBox.SelectedItem);
            OrderItems();
        }

        private void RmRestaurante_BTN_Click(object sender, EventArgs e)
        {
            if (Restaurantes_ListBox.SelectedItem == null)
                return;

            Restaurantes_ComboBox.Items.Add(Restaurantes_ListBox.SelectedItem);
            Restaurantes_ListBox.Items.Remove(Restaurantes_ListBox.SelectedItem);
            OrderItems();
        }

        private void OrderItems()
        {
            // TODO: Criar função que ordena os items da listbox e da combo box
        }
    }
}
