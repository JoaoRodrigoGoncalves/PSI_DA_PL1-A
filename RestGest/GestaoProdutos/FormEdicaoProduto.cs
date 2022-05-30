using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RestGest.GestaoRestaurantes
{
    public partial class FormEdicaoProduto : Form
    {
        private RestGestContainer databaseContainer;
        private int ProdutoID;
        private ItemMenu dadosProduto; // Global para que possa ser editada;

        public FormEdicaoProduto(int idProduto)
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            ProdutoID = idProduto;
        }

        private void FormRegistoProduto_Load(object sender, EventArgs e)
        {
            dadosProduto = databaseContainer.ItemsMenus.Find(ProdutoID);

            Nome_TextBox.Text = dadosProduto.Nome;
            Preco_TextBox.Text = dadosProduto.Preco.ToString();

            Categoria[] categorias = databaseContainer.Categorias.Where(x => x.Ativo == true).OrderBy(x => x.Nome).ToArray();

            if (categorias.Length == 0)
            {
                MessageBox.Show("Não existem categorias registadas. Crie categorias para produtos na respetiva janela antes de registar um produto!");
                Close();
            }

            Categoria_ComboBox.Items.AddRange(categorias);

            if (!Categoria_ComboBox.Items.Contains(dadosProduto.Categoria))
                Categoria_ComboBox.Items.Add(dadosProduto.Categoria);

            Categoria_ComboBox.SelectedItem = dadosProduto.Categoria;

            Ativo_CheckBox.Checked = dadosProduto.Ativo;

            ImageConverter imageConverter = new ImageConverter();
            
            //TODO Check null validation

            if(dadosProduto.Fotografia != null)
                Imagem_PictureBox.Image = (Image)imageConverter.ConvertFrom(dadosProduto.Fotografia);

            if(!String.IsNullOrEmpty(dadosProduto.Ingredientes))
                Ingredientes_ListBox.Items.AddRange(JsonConvert.DeserializeObject<List<string>>(dadosProduto.Ingredientes).ToArray());

            Restaurante[] restaurantes = databaseContainer.Restaurantes.Where(x => x.Ativo == true).OrderBy(x => x.Nome).ToArray();

            if(restaurantes.Length == 0)
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

            foreach (Restaurante item in dadosProduto.Restaurante)
            {
                Restaurantes_ListBox.Items.Add(item);
            }
        }

        private void Guardar_BTN_Click(object sender, EventArgs e)
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
            List<ItemMenu> matches = databaseContainer.ItemsMenus.Where(produtos => produtos.Nome.Contains(Nome_TextBox.Text) && produtos.Id != ProdutoID).ToList();

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

            dadosProduto.Ativo = Ativo_CheckBox.Checked;
            dadosProduto.Nome = Nome_TextBox.Text;
            dadosProduto.Preco = val;

            ImageConverter converter = new ImageConverter();
            byte[] novaImagem = (byte[])converter.ConvertTo(Imagem_PictureBox.Image, typeof(byte[]));
            string hash_original;
            string hash_novaImagem;

            using(SHA1 sha1 = SHA1.Create())
            {
                hash_original = BitConverter.ToString(sha1.ComputeHash(dadosProduto.Fotografia));
                hash_novaImagem = BitConverter.ToString(sha1.ComputeHash(novaImagem));
            }

            dadosProduto.Fotografia = (hash_novaImagem != hash_original ? novaImagem : null);
            dadosProduto.Ingredientes = (Ingredientes_ListBox.Items.Count > 0 ? JsonConvert.SerializeObject(Ingredientes_ListBox.Items) : null);
            dadosProduto.Categoria = (Categoria)Categoria_ComboBox.SelectedItem;

            if(Restaurantes_ListBox.Enabled && Restaurantes_ListBox.Items.Count > 0)
            {
                foreach (Restaurante restaurante in Restaurantes_ListBox.Items)
                {
                    dadosProduto.Restaurante.Add(restaurante);
                }
            }
            
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
            if(Ingredientes_ListBox.SelectedItems.Count == 1)
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

            if(openFileDialog.ShowDialog() == DialogResult.OK)
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
