namespace RestGest.GestaoClientes
{
    partial class FormRegistoCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_telemovel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nif = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tb_codPostal = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_rua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_telemovel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_nif);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.tb_codPostal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_pais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_cidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_rua);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRegistar);
            this.groupBox1.Controls.Add(this.tb_Nome);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(695, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // tb_telemovel
            // 
            this.tb_telemovel.Location = new System.Drawing.Point(164, 142);
            this.tb_telemovel.Margin = new System.Windows.Forms.Padding(4);
            this.tb_telemovel.Mask = "000000000";
            this.tb_telemovel.Name = "tb_telemovel";
            this.tb_telemovel.Size = new System.Drawing.Size(89, 22);
            this.tb_telemovel.TabIndex = 12;
            this.tb_telemovel.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telemóvel";
            // 
            // tb_nif
            // 
            this.tb_nif.Location = new System.Drawing.Point(589, 16);
            this.tb_nif.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nif.Mask = "000000000";
            this.tb_nif.Name = "tb_nif";
            this.tb_nif.Size = new System.Drawing.Size(89, 22);
            this.tb_nif.TabIndex = 2;
            this.tb_nif.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "NIF";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(472, 144);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // tb_codPostal
            // 
            this.tb_codPostal.Location = new System.Drawing.Point(164, 80);
            this.tb_codPostal.Margin = new System.Windows.Forms.Padding(4);
            this.tb_codPostal.Mask = "0000-999";
            this.tb_codPostal.Name = "tb_codPostal";
            this.tb_codPostal.Size = new System.Drawing.Size(185, 22);
            this.tb_codPostal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "País";
            // 
            // tb_pais
            // 
            this.tb_pais.Location = new System.Drawing.Point(164, 112);
            this.tb_pais.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(515, 22);
            this.tb_pais.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(420, 80);
            this.tb_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(259, 22);
            this.tb_cidade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código Postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rua";
            // 
            // tb_rua
            // 
            this.tb_rua.Location = new System.Drawing.Point(164, 48);
            this.tb_rua.Margin = new System.Windows.Forms.Padding(4);
            this.tb_rua.Name = "tb_rua";
            this.tb_rua.Size = new System.Drawing.Size(515, 22);
            this.tb_rua.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(580, 144);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistar.TabIndex = 7;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(164, 16);
            this.tb_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(376, 22);
            this.tb_Nome.TabIndex = 1;
            // 
            // FormRegistoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 220);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistoCliente";
            this.Text = "Registar Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tb_telemovel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tb_nif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox tb_codPostal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_rua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox tb_Nome;
    }
}