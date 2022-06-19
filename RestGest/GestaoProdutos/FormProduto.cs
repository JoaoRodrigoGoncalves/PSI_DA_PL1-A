using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RestGest.GestaoRestaurantes
{
    public partial class FormProduto : Form
    {
        private RestGestContainer databaseContainer;
        private ItemMenu dadosProduto; // Global para que possa ser editada;

        public FormProduto()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            this.dadosProduto = null;
            bt_update.Enabled = false;
            Guardar_BTN.Enabled = true;
        }
        public FormProduto(int idProduto, bool edit)
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            dadosProduto = databaseContainer.ItemsMenus.Find(idProduto);
            bt_update.Enabled = edit;
            Guardar_BTN.Enabled = false;
            Limpar_BTN.Enabled = edit;
            Edit_Mode(edit);
        }

        private void Edit_Mode(bool edit)
        {
            Nome_TextBox.Enabled = edit;
            Preco_TextBox.Enabled = edit;
            Categoria_ComboBox.Enabled = edit;
            Ativo_CheckBox.Enabled = edit;
            AlterarImagem_BTN.Enabled = edit;
            ReporImagem_BTN.Enabled = edit;
            Ingrediente_TextBox.Enabled = edit;
            AddItem_BTN.Enabled = edit;
            RmItem_BTN.Enabled = edit;
            Restaurantes_ComboBox.Enabled = edit;
            AddRestaurante_BTN.Enabled = edit;
            RmRestaurante_BTN.Enabled = edit;
        }

        private void FormRegistoProduto_Load(object sender, EventArgs e)
        {           

            //Adiciona informação categortias
            Categoria[] categorias = databaseContainer.Categorias.Where(x => x.Ativo == true).OrderBy(x => x.Nome).ToArray();

            Categoria_ComboBox.Items.AddRange(categorias);

            if (categorias.Length == 0)
            {
                MessageBox.Show("Não existem categorias registadas. Crie categorias para produtos na respetiva janela antes de registar um produto!");
                Close();
            }

            //Adiciona informação restaurantes
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

            //Valida se o form vai editar ou adicionar um novo produto

            if (this.dadosProduto == null)
                return;

            Nome_TextBox.Text = dadosProduto.Nome;
            Preco_TextBox.Text = dadosProduto.Preco.ToString();

            if (!Categoria_ComboBox.Items.Contains(dadosProduto.Categoria))
                Categoria_ComboBox.Items.Add(dadosProduto.Categoria);

            Categoria_ComboBox.SelectedItem = dadosProduto.Categoria;

            Ativo_CheckBox.Checked = dadosProduto.Ativo;

            ImageConverter imageConverter = new ImageConverter();

            if (dadosProduto.Fotografia != null)
                Imagem_PictureBox.Image = (Image)imageConverter.ConvertFrom(dadosProduto.Fotografia);

            if (!String.IsNullOrEmpty(dadosProduto.Ingredientes))
                Ingredientes_ListBox.Items.AddRange(JsonConvert.DeserializeObject<List<string>>(dadosProduto.Ingredientes).ToArray());

            //Order Restaurantes
            foreach (Restaurante item in dadosProduto.Restaurante.OrderBy(r => r.Nome))
            {
                Restaurantes_ListBox.Items.Add(item);
            }
        }

        private void Guardar_BTN_Click(object sender, EventArgs e)
        {
            if (Filtrar())
                return;

            // Verificar se não existe já um item semelhante (Pura UX)
            List<ItemMenu> matches = databaseContainer.ItemsMenus.Where(produtos => produtos.Nome.Contains(Nome_TextBox.Text) && produtos.Id != dadosProduto.Id).ToList();

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
            dadosProduto.Preco = decimal.Parse(Preco_TextBox.Text);

            ImageConverter converter = new ImageConverter();
            byte[] novaImagem = (byte[])converter.ConvertTo(Imagem_PictureBox.Image, typeof(byte[]));
            string hash_original;
            string hash_novaImagem;

            if (dadosProduto.Fotografia != null)
            {
                using (SHA1 sha1 = SHA1.Create())
                {
                    hash_original = BitConverter.ToString(sha1.ComputeHash(dadosProduto.Fotografia));
                    hash_novaImagem = BitConverter.ToString(sha1.ComputeHash(novaImagem));
                }

                dadosProduto.Fotografia = (hash_novaImagem != hash_original ? novaImagem : null);
            }
            dadosProduto.Ingredientes = (Ingredientes_ListBox.Items.Count > 0 ? JsonConvert.SerializeObject(Ingredientes_ListBox.Items) : null);
            dadosProduto.Categoria = (Categoria)Categoria_ComboBox.SelectedItem;

            if (Restaurantes_ListBox.Enabled && Restaurantes_ListBox.Items.Count > 0)
            {
                foreach (Restaurante restaurante in Restaurantes_ListBox.Items)
                    dadosProduto.Restaurante.Add(restaurante);
                
            }
            databaseContainer.SaveChanges();
            databaseContainer.Dispose();
            Close();
        }

        private bool Filtrar()
        {
            if (String.IsNullOrWhiteSpace(Nome_TextBox.Text) || String.IsNullOrWhiteSpace(Preco_TextBox.Text))
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de continuar!",
                    "Campos vazios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return true;
            }

            Preco_TextBox.Text = Preco_TextBox.Text.Replace('.', ','); // Trocar '.' por ',' (Pura UX)
            if (!decimal.TryParse(Preco_TextBox.Text, out decimal val))
            {
                MessageBox.Show(
                    "Indique um preço válido!",
                    "Preço Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
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
            if (Restaurantes_ComboBox.SelectedItem == null || Restaurantes_ListBox.Items.Contains(Restaurantes_ComboBox.SelectedItem))
                return;


            //Get the restaurantes list form listbox 
            List<Restaurante> rest_list = new List<Restaurante>();
            rest_list.AddRange(Restaurantes_ListBox.Items.Cast<Restaurante>().ToList());
            //Add the new restaurante from comboBox
            rest_list.Add((Restaurante)Restaurantes_ComboBox.SelectedItem);
            //Clear the old data
            Restaurantes_ListBox.Items.Clear();
            //Order the update list
            rest_list.Sort((x,y) => {
                int ret = String.Compare(x.Nome, y.Nome);
                return ret;
            });
            //Set the update listBox
            Restaurantes_ListBox.Items.AddRange(rest_list.ToArray());
        }

        private void RmRestaurante_BTN_Click(object sender, EventArgs e)
        {
            if (Restaurantes_ListBox.SelectedItem == null)
                return;            
            //
            Restaurantes_ListBox.Items.Remove(Restaurantes_ListBox.SelectedItem);
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_BTN_Click_1(object sender, EventArgs e)
        {
            if (Filtrar())
                return;

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
            novoProduto.Preco = decimal.Parse(Preco_TextBox.Text);


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
                foreach (Restaurante restaurante in Restaurantes_ListBox.Items)
                    novoProduto.Restaurante.Add(restaurante);

            databaseContainer.ItemsMenus.Add(novoProduto);

            databaseContainer.SaveChanges();
            databaseContainer.Dispose();
            Close();
        }
    }
}
