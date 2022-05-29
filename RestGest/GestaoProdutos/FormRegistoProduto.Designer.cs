namespace RestGest.GestaoRestaurantes
{
    partial class FormRegistoProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.Registar_BTN = new System.Windows.Forms.Button();
            this.Nome_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddRestaurante_BTN = new System.Windows.Forms.Button();
            this.Restaurantes_ComboBox = new System.Windows.Forms.ComboBox();
            this.RmRestaurante_BTN = new System.Windows.Forms.Button();
            this.Restaurantes_ListBox = new System.Windows.Forms.ListBox();
            this.Categoria_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddItem_BTN = new System.Windows.Forms.Button();
            this.RmItem_BTN = new System.Windows.Forms.Button();
            this.Ingrediente_TextBox = new System.Windows.Forms.TextBox();
            this.Ingredientes_ListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReporImagem_BTN = new System.Windows.Forms.Button();
            this.AlterarImagem_BTN = new System.Windows.Forms.Button();
            this.Imagem_PictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Preco_TextBox = new System.Windows.Forms.TextBox();
            this.Ativo_CheckBox = new System.Windows.Forms.CheckBox();
            this.Limpar_BTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto";
            // 
            // Registar_BTN
            // 
            this.Registar_BTN.Location = new System.Drawing.Point(709, 307);
            this.Registar_BTN.Name = "Registar_BTN";
            this.Registar_BTN.Size = new System.Drawing.Size(75, 23);
            this.Registar_BTN.TabIndex = 10;
            this.Registar_BTN.Text = "Registar";
            this.Registar_BTN.UseVisualStyleBackColor = true;
            this.Registar_BTN.Click += new System.EventHandler(this.Registar_BTN_Click);
            // 
            // Nome_TextBox
            // 
            this.Nome_TextBox.Location = new System.Drawing.Point(104, 13);
            this.Nome_TextBox.Name = "Nome_TextBox";
            this.Nome_TextBox.Size = new System.Drawing.Size(406, 20);
            this.Nome_TextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.Categoria_ComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Preco_TextBox);
            this.groupBox1.Controls.Add(this.Ativo_CheckBox);
            this.groupBox1.Controls.Add(this.Limpar_BTN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Registar_BTN);
            this.groupBox1.Controls.Add(this.Nome_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AddRestaurante_BTN);
            this.groupBox4.Controls.Add(this.Restaurantes_ComboBox);
            this.groupBox4.Controls.Add(this.RmRestaurante_BTN);
            this.groupBox4.Controls.Add(this.Restaurantes_ListBox);
            this.groupBox4.Location = new System.Drawing.Point(516, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 288);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Restaurantes";
            // 
            // AddRestaurante_BTN
            // 
            this.AddRestaurante_BTN.Location = new System.Drawing.Point(210, 255);
            this.AddRestaurante_BTN.Name = "AddRestaurante_BTN";
            this.AddRestaurante_BTN.Size = new System.Drawing.Size(23, 23);
            this.AddRestaurante_BTN.TabIndex = 10;
            this.AddRestaurante_BTN.Text = "+";
            this.AddRestaurante_BTN.UseVisualStyleBackColor = true;
            this.AddRestaurante_BTN.Click += new System.EventHandler(this.AddRestaurante_BTN_Click);
            // 
            // Restaurantes_ComboBox
            // 
            this.Restaurantes_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Restaurantes_ComboBox.FormattingEnabled = true;
            this.Restaurantes_ComboBox.Location = new System.Drawing.Point(6, 256);
            this.Restaurantes_ComboBox.Name = "Restaurantes_ComboBox";
            this.Restaurantes_ComboBox.Size = new System.Drawing.Size(198, 21);
            this.Restaurantes_ComboBox.TabIndex = 1;
            // 
            // RmRestaurante_BTN
            // 
            this.RmRestaurante_BTN.Location = new System.Drawing.Point(239, 255);
            this.RmRestaurante_BTN.Name = "RmRestaurante_BTN";
            this.RmRestaurante_BTN.Size = new System.Drawing.Size(23, 23);
            this.RmRestaurante_BTN.TabIndex = 11;
            this.RmRestaurante_BTN.Text = "-";
            this.RmRestaurante_BTN.UseVisualStyleBackColor = true;
            this.RmRestaurante_BTN.Click += new System.EventHandler(this.RmRestaurante_BTN_Click);
            // 
            // Restaurantes_ListBox
            // 
            this.Restaurantes_ListBox.FormattingEnabled = true;
            this.Restaurantes_ListBox.Location = new System.Drawing.Point(6, 19);
            this.Restaurantes_ListBox.Name = "Restaurantes_ListBox";
            this.Restaurantes_ListBox.Size = new System.Drawing.Size(256, 225);
            this.Restaurantes_ListBox.TabIndex = 0;
            // 
            // Categoria_ComboBox
            // 
            this.Categoria_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categoria_ComboBox.FormattingEnabled = true;
            this.Categoria_ComboBox.ItemHeight = 13;
            this.Categoria_ComboBox.Location = new System.Drawing.Point(256, 38);
            this.Categoria_ComboBox.Name = "Categoria_ComboBox";
            this.Categoria_ComboBox.Size = new System.Drawing.Size(152, 21);
            this.Categoria_ComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Categoria";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddItem_BTN);
            this.groupBox3.Controls.Add(this.RmItem_BTN);
            this.groupBox3.Controls.Add(this.Ingrediente_TextBox);
            this.groupBox3.Controls.Add(this.Ingredientes_ListBox);
            this.groupBox3.Location = new System.Drawing.Point(179, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 236);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingredientes";
            // 
            // AddItem_BTN
            // 
            this.AddItem_BTN.Location = new System.Drawing.Point(273, 204);
            this.AddItem_BTN.Name = "AddItem_BTN";
            this.AddItem_BTN.Size = new System.Drawing.Size(23, 23);
            this.AddItem_BTN.TabIndex = 8;
            this.AddItem_BTN.Text = "+";
            this.AddItem_BTN.UseVisualStyleBackColor = true;
            this.AddItem_BTN.Click += new System.EventHandler(this.AddItem_BTN_Click);
            // 
            // RmItem_BTN
            // 
            this.RmItem_BTN.Location = new System.Drawing.Point(302, 204);
            this.RmItem_BTN.Name = "RmItem_BTN";
            this.RmItem_BTN.Size = new System.Drawing.Size(23, 23);
            this.RmItem_BTN.TabIndex = 9;
            this.RmItem_BTN.Text = "-";
            this.RmItem_BTN.UseVisualStyleBackColor = true;
            this.RmItem_BTN.Click += new System.EventHandler(this.RmItem_BTN_Click);
            // 
            // Ingrediente_TextBox
            // 
            this.Ingrediente_TextBox.Location = new System.Drawing.Point(6, 205);
            this.Ingrediente_TextBox.Name = "Ingrediente_TextBox";
            this.Ingrediente_TextBox.Size = new System.Drawing.Size(261, 20);
            this.Ingrediente_TextBox.TabIndex = 7;
            // 
            // Ingredientes_ListBox
            // 
            this.Ingredientes_ListBox.FormattingEnabled = true;
            this.Ingredientes_ListBox.Location = new System.Drawing.Point(6, 19);
            this.Ingredientes_ListBox.Name = "Ingredientes_ListBox";
            this.Ingredientes_ListBox.Size = new System.Drawing.Size(319, 173);
            this.Ingredientes_ListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReporImagem_BTN);
            this.groupBox2.Controls.Add(this.AlterarImagem_BTN);
            this.groupBox2.Controls.Add(this.Imagem_PictureBox);
            this.groupBox2.Location = new System.Drawing.Point(11, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 236);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagem";
            // 
            // ReporImagem_BTN
            // 
            this.ReporImagem_BTN.Location = new System.Drawing.Point(7, 204);
            this.ReporImagem_BTN.Name = "ReporImagem_BTN";
            this.ReporImagem_BTN.Size = new System.Drawing.Size(149, 23);
            this.ReporImagem_BTN.TabIndex = 6;
            this.ReporImagem_BTN.Text = "Repor Imagem";
            this.ReporImagem_BTN.UseVisualStyleBackColor = true;
            this.ReporImagem_BTN.Click += new System.EventHandler(this.ReporImagem_BTN_Click);
            // 
            // AlterarImagem_BTN
            // 
            this.AlterarImagem_BTN.Location = new System.Drawing.Point(7, 175);
            this.AlterarImagem_BTN.Name = "AlterarImagem_BTN";
            this.AlterarImagem_BTN.Size = new System.Drawing.Size(149, 23);
            this.AlterarImagem_BTN.TabIndex = 5;
            this.AlterarImagem_BTN.Text = "Alterar Imagem";
            this.AlterarImagem_BTN.UseVisualStyleBackColor = true;
            this.AlterarImagem_BTN.Click += new System.EventHandler(this.AlterarImagem_BTN_Click);
            // 
            // Imagem_PictureBox
            // 
            this.Imagem_PictureBox.Image = global::RestGest.Properties.Resources.produto_placeholder;
            this.Imagem_PictureBox.Location = new System.Drawing.Point(6, 19);
            this.Imagem_PictureBox.MaximumSize = new System.Drawing.Size(150, 150);
            this.Imagem_PictureBox.MinimumSize = new System.Drawing.Size(150, 150);
            this.Imagem_PictureBox.Name = "Imagem_PictureBox";
            this.Imagem_PictureBox.Size = new System.Drawing.Size(150, 150);
            this.Imagem_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem_PictureBox.TabIndex = 12;
            this.Imagem_PictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preço";
            // 
            // Preco_TextBox
            // 
            this.Preco_TextBox.Location = new System.Drawing.Point(104, 39);
            this.Preco_TextBox.Name = "Preco_TextBox";
            this.Preco_TextBox.Size = new System.Drawing.Size(88, 20);
            this.Preco_TextBox.TabIndex = 2;
            // 
            // Ativo_CheckBox
            // 
            this.Ativo_CheckBox.AutoSize = true;
            this.Ativo_CheckBox.Checked = true;
            this.Ativo_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ativo_CheckBox.Location = new System.Drawing.Point(414, 42);
            this.Ativo_CheckBox.Name = "Ativo_CheckBox";
            this.Ativo_CheckBox.Size = new System.Drawing.Size(96, 17);
            this.Ativo_CheckBox.TabIndex = 4;
            this.Ativo_CheckBox.Text = "Produto Ativo?";
            this.Ativo_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Limpar_BTN
            // 
            this.Limpar_BTN.Location = new System.Drawing.Point(628, 307);
            this.Limpar_BTN.Name = "Limpar_BTN";
            this.Limpar_BTN.Size = new System.Drawing.Size(75, 23);
            this.Limpar_BTN.TabIndex = 11;
            this.Limpar_BTN.Text = "Limpar";
            this.Limpar_BTN.UseVisualStyleBackColor = true;
            this.Limpar_BTN.Click += new System.EventHandler(this.Limpar_BTN_Click);
            // 
            // FormRegistoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 363);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(562, 402);
            this.Name = "FormRegistoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registar Produto";
            this.Load += new System.EventHandler(this.FormRegistoProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Imagem_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Registar_BTN;
        private System.Windows.Forms.TextBox Nome_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Limpar_BTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddItem_BTN;
        private System.Windows.Forms.Button RmItem_BTN;
        private System.Windows.Forms.TextBox Ingrediente_TextBox;
        private System.Windows.Forms.ListBox Ingredientes_ListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Imagem_PictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Preco_TextBox;
        private System.Windows.Forms.CheckBox Ativo_CheckBox;
        private System.Windows.Forms.Button ReporImagem_BTN;
        private System.Windows.Forms.Button AlterarImagem_BTN;
        private System.Windows.Forms.ComboBox Categoria_ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AddRestaurante_BTN;
        private System.Windows.Forms.ComboBox Restaurantes_ComboBox;
        private System.Windows.Forms.Button RmRestaurante_BTN;
        private System.Windows.Forms.ListBox Restaurantes_ListBox;
    }
}