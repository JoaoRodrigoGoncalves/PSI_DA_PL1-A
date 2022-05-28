namespace RestGest
{
    partial class FormPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_gr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gp = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btnMetodoPagamento = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 106);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestão Restaurantes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_gr,
            this.menuItem_gc,
            this.menuItem_gf,
            this.menuItem_gp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_gr
            // 
            this.menuItem_gr.Name = "menuItem_gr";
            this.menuItem_gr.Size = new System.Drawing.Size(202, 32);
            this.menuItem_gr.Text = "Gestão Restaurantes";
            this.menuItem_gr.Click += new System.EventHandler(this.menuItem_gr_Click);
            // 
            // menuItem_gc
            // 
            this.menuItem_gc.Name = "menuItem_gc";
            this.menuItem_gc.Size = new System.Drawing.Size(160, 32);
            this.menuItem_gc.Text = "Gestão Clientes";
            // 
            // menuItem_gf
            // 
            this.menuItem_gf.Name = "menuItem_gf";
            this.menuItem_gf.Size = new System.Drawing.Size(230, 32);
            this.menuItem_gf.Text = "Gestão de Funcionários";
            this.menuItem_gf.Click += new System.EventHandler(this.menuItem_gf_Click);
            // 
            // menuItem_gp
            // 
            this.menuItem_gp.Name = "menuItem_gp";
            this.menuItem_gp.Size = new System.Drawing.Size(188, 32);
            this.menuItem_gp.Text = "Gestão de Pedidos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 113);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 106);
            this.button2.TabIndex = 0;
            this.button2.Text = "Gestão de Funcionarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 86);
            this.button3.TabIndex = 0;
            this.button3.Text = "Gestão Categorias";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(618, 113);
            this.btn_Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(233, 106);
            this.btn_Clientes.TabIndex = 2;
            this.btn_Clientes.Text = "Gestão de Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btnMetodoPagamento
            // 
            this.btnMetodoPagamento.Location = new System.Drawing.Point(73, 269);
            this.btnMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnMetodoPagamento.Name = "btnMetodoPagamento";
            this.btnMetodoPagamento.Size = new System.Drawing.Size(233, 106);
            this.btnMetodoPagamento.TabIndex = 3;
            this.btnMetodoPagamento.Text = "Registar Métodos de Pagamento";
            this.btnMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnMetodoPagamento.Click += new System.EventHandler(this.btnMetodoPagamento_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.ClientSize = new System.Drawing.Size(962, 554);
            this.Controls.Add(this.btnMetodoPagamento);
            this.Controls.Add(this.btn_Clientes);

            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestGest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gr;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gc;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gf;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btnMetodoPagamento;
    }
}