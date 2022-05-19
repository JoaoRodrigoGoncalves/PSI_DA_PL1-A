namespace RestGest.GestaoRestaurantes
{
    partial class FormEdicaoRestaurante
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
            this.Guardar_BTN = new System.Windows.Forms.Button();
            this.Nome_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodigoPostal_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pais_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cidade_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rua_TextBox = new System.Windows.Forms.TextBox();
            this.Cancelar_BTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Restaurante";
            // 
            // Guardar_BTN
            // 
            this.Guardar_BTN.Location = new System.Drawing.Point(435, 117);
            this.Guardar_BTN.Name = "Guardar_BTN";
            this.Guardar_BTN.Size = new System.Drawing.Size(75, 23);
            this.Guardar_BTN.TabIndex = 6;
            this.Guardar_BTN.Text = "Guardar";
            this.Guardar_BTN.UseVisualStyleBackColor = true;
            this.Guardar_BTN.Click += new System.EventHandler(this.Guardar_BTN_Click);
            // 
            // Nome_TextBox
            // 
            this.Nome_TextBox.Location = new System.Drawing.Point(123, 13);
            this.Nome_TextBox.Name = "Nome_TextBox";
            this.Nome_TextBox.Size = new System.Drawing.Size(387, 20);
            this.Nome_TextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancelar_BTN);
            this.groupBox1.Controls.Add(this.CodigoPostal_MaskedTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Pais_TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cidade_TextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Rua_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Guardar_BTN);
            this.groupBox1.Controls.Add(this.Nome_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // CodigoPostal_MaskedTextBox
            // 
            this.CodigoPostal_MaskedTextBox.Location = new System.Drawing.Point(123, 65);
            this.CodigoPostal_MaskedTextBox.Mask = "0000-999";
            this.CodigoPostal_MaskedTextBox.Name = "CodigoPostal_MaskedTextBox";
            this.CodigoPostal_MaskedTextBox.Size = new System.Drawing.Size(140, 20);
            this.CodigoPostal_MaskedTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "País";
            // 
            // Pais_TextBox
            // 
            this.Pais_TextBox.Location = new System.Drawing.Point(123, 91);
            this.Pais_TextBox.Name = "Pais_TextBox";
            this.Pais_TextBox.Size = new System.Drawing.Size(387, 20);
            this.Pais_TextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade";
            // 
            // Cidade_TextBox
            // 
            this.Cidade_TextBox.Location = new System.Drawing.Point(315, 65);
            this.Cidade_TextBox.Name = "Cidade_TextBox";
            this.Cidade_TextBox.Size = new System.Drawing.Size(195, 20);
            this.Cidade_TextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código Postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rua";
            // 
            // Rua_TextBox
            // 
            this.Rua_TextBox.Location = new System.Drawing.Point(123, 39);
            this.Rua_TextBox.Name = "Rua_TextBox";
            this.Rua_TextBox.Size = new System.Drawing.Size(387, 20);
            this.Rua_TextBox.TabIndex = 2;
            // 
            // Cancelar_BTN
            // 
            this.Cancelar_BTN.Location = new System.Drawing.Point(354, 117);
            this.Cancelar_BTN.Name = "Cancelar_BTN";
            this.Cancelar_BTN.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_BTN.TabIndex = 7;
            this.Cancelar_BTN.Text = "Cancelar";
            this.Cancelar_BTN.UseVisualStyleBackColor = true;
            this.Cancelar_BTN.Click += new System.EventHandler(this.Cancelar_BTN_Click);
            // 
            // FormEdicaoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 179);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(562, 218);
            this.MinimumSize = new System.Drawing.Size(562, 218);
            this.Name = "FormEdicaoRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Restaurante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardar_BTN;
        private System.Windows.Forms.TextBox Nome_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pais_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cidade_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rua_TextBox;
        private System.Windows.Forms.MaskedTextBox CodigoPostal_MaskedTextBox;
        private System.Windows.Forms.Button Cancelar_BTN;
    }
}