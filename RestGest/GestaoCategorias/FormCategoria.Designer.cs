namespace RestGest.GestaoCategorias
{
    partial class FormCategoria
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
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.bt_create = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_categoria
            // 
            this.tb_categoria.Location = new System.Drawing.Point(30, 25);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(231, 20);
            this.tb_categoria.TabIndex = 0;
            // 
            // bt_create
            // 
            this.bt_create.Enabled = false;
            this.bt_create.Location = new System.Drawing.Point(30, 68);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(108, 23);
            this.bt_create.TabIndex = 1;
            this.bt_create.Text = "Criar";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(31, 97);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(230, 23);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Enabled = false;
            this.bt_edit.Location = new System.Drawing.Point(153, 68);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(108, 23);
            this.bt_edit.TabIndex = 1;
            this.bt_edit.Text = "Editar";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 144);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.tb_categoria);
            this.Name = "FormCategoria";
            this.Text = "Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_edit;
    }
}