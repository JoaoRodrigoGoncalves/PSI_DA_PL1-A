using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest.GestaoCategorias
{
    public partial class FormCategoria : Form
    {
        private RestGestContainer databaseContainer;
        private Categoria categoria_edit;
        public FormCategoria()
        {
            InitializeComponent();
            databaseContainer = new RestGestContainer();
            bt_create.Enabled = true;
        }
        public FormCategoria(int categoria_id)
        {
            InitializeComponent();
            this.databaseContainer = new RestGestContainer();
            this.categoria_edit = databaseContainer.Categorias.Find(categoria_id);
            tb_categoria.Text = categoria_edit.Nome;
            bt_edit.Enabled = true;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool inputValidation()
        {
            return String.IsNullOrEmpty(tb_categoria.Text);
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            if (inputValidation())
            {
                MessageBox.Show("Preencha todos os campos", "Criação de Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Categoria new_categoria = new Categoria();
            new_categoria.Nome = tb_categoria.Text;
            //
            databaseContainer.Categorias.Add(new_categoria);
            //
            try
            {
                databaseContainer.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("Saving changes fail...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (var ev in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type " + ev.Entry.Entity.GetType().Name + " in state " + ev.Entry.State + " has the following validation errors:");
                    foreach (var ve in ev.ValidationErrors)
                        Console.WriteLine("- Property: " + ve.PropertyName + ", Error: " + ve.ErrorMessage);
                }
            }
            //
            this.Close();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (inputValidation())
            {
                MessageBox.Show("Preencha todos os campos", "Criação de Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.categoria_edit.Nome = tb_categoria.Text;

            //
            try
            {
                databaseContainer.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("Saving changes fail...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (var ev in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type " + ev.Entry.Entity.GetType().Name + " in state " + ev.Entry.State + " has the following validation errors:");
                    foreach (var ve in ev.ValidationErrors)
                        Console.WriteLine("- Property: " + ve.PropertyName + ", Error: " + ve.ErrorMessage);
                }
            }
            //
            this.Close();
        }
    }
}
