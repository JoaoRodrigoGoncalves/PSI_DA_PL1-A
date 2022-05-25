
namespace RestGest
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_produtos = new System.Windows.Forms.Button();
            this.bt_categoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_produtos
            // 
            this.bt_produtos.Location = new System.Drawing.Point(403, 99);
            this.bt_produtos.Name = "bt_produtos";
            this.bt_produtos.Size = new System.Drawing.Size(175, 86);
            this.bt_produtos.TabIndex = 1;
            this.bt_produtos.Text = "Gestão Produtos";
            this.bt_produtos.UseVisualStyleBackColor = true;
            this.bt_produtos.Click += new System.EventHandler(this.bt_produtos_Click);
            // 
            // bt_categoria
            // 
            this.bt_categoria.Location = new System.Drawing.Point(84, 99);
            this.bt_categoria.Name = "bt_categoria";
            this.bt_categoria.Size = new System.Drawing.Size(175, 86);
            this.bt_categoria.TabIndex = 2;
            this.bt_categoria.Text = "Gestão de Categorias";
            this.bt_categoria.UseVisualStyleBackColor = true;
            this.bt_categoria.Click += new System.EventHandler(this.bt_categoria_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 312);
            this.Controls.Add(this.bt_produtos);
            this.Controls.Add(this.bt_categoria);
            this.Name = "FormProdutos";
            this.Text = "FromProdutos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_produtos;
        private System.Windows.Forms.Button bt_categoria;
    }
}