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
            this.btn_GestaoRestaurantes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_gr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gp = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_GestaoFuncionarios = new System.Windows.Forms.Button();
            this.btn_GestaoCategorias = new System.Windows.Forms.Button();
            this.btn_GestaoClientes = new System.Windows.Forms.Button();
            this.btn_MetodoPagamento = new System.Windows.Forms.Button();
            this.btn_Pedidos = new System.Windows.Forms.Button();
            this.btn_Produtos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GestaoRestaurantes
            // 
            this.btn_GestaoRestaurantes.Location = new System.Drawing.Point(55, 92);
            this.btn_GestaoRestaurantes.Name = "btn_GestaoRestaurantes";
            this.btn_GestaoRestaurantes.Size = new System.Drawing.Size(175, 86);
            this.btn_GestaoRestaurantes.TabIndex = 0;
            this.btn_GestaoRestaurantes.Text = "Gestão Restaurantes";
            this.btn_GestaoRestaurantes.UseVisualStyleBackColor = true;
            this.btn_GestaoRestaurantes.Click += new System.EventHandler(this.btn_GestaoRestaurantes_Click);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(722, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_gr
            // 
            this.menuItem_gr.Name = "menuItem_gr";
            this.menuItem_gr.Size = new System.Drawing.Size(164, 25);
            this.menuItem_gr.Text = "Gestão Restaurantes";
            this.menuItem_gr.Click += new System.EventHandler(this.menuItem_gr_Click);
            // 
            // menuItem_gc
            // 
            this.menuItem_gc.Name = "menuItem_gc";
            this.menuItem_gc.Size = new System.Drawing.Size(129, 25);
            this.menuItem_gc.Text = "Gestão Clientes";
            // 
            // menuItem_gf
            // 
            this.menuItem_gf.Name = "menuItem_gf";
            this.menuItem_gf.Size = new System.Drawing.Size(184, 25);
            this.menuItem_gf.Text = "Gestão de Funcionários";
            this.menuItem_gf.Click += new System.EventHandler(this.menuItem_gf_Click);
            // 
            // menuItem_gp
            // 
            this.menuItem_gp.Name = "menuItem_gp";
            this.menuItem_gp.Size = new System.Drawing.Size(149, 25);
            this.menuItem_gp.Text = "Gestão de Pedidos";
            // 
            // btn_GestaoFuncionarios
            // 
            this.btn_GestaoFuncionarios.Location = new System.Drawing.Point(260, 92);
            this.btn_GestaoFuncionarios.Name = "btn_GestaoFuncionarios";
            this.btn_GestaoFuncionarios.Size = new System.Drawing.Size(175, 86);
            this.btn_GestaoFuncionarios.TabIndex = 0;
            this.btn_GestaoFuncionarios.Text = "Gestão de Funcionarios";
            this.btn_GestaoFuncionarios.UseVisualStyleBackColor = true;
            this.btn_GestaoFuncionarios.Click += new System.EventHandler(this.btn_GestaoFuncionarios_Click);
            // 
            // btn_GestaoCategorias
            // 
            this.btn_GestaoCategorias.Location = new System.Drawing.Point(260, 219);
            this.btn_GestaoCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GestaoCategorias.Name = "btn_GestaoCategorias";
            this.btn_GestaoCategorias.Size = new System.Drawing.Size(175, 86);
            this.btn_GestaoCategorias.TabIndex = 0;
            this.btn_GestaoCategorias.Text = "Gestão Categorias";
            this.btn_GestaoCategorias.UseVisualStyleBackColor = true;
            this.btn_GestaoCategorias.Click += new System.EventHandler(this.btn_GestaoCategorias_Click);
            // 
            // btn_GestaoClientes
            // 
            this.btn_GestaoClientes.Location = new System.Drawing.Point(464, 92);
            this.btn_GestaoClientes.Name = "btn_GestaoClientes";
            this.btn_GestaoClientes.Size = new System.Drawing.Size(175, 86);
            this.btn_GestaoClientes.TabIndex = 2;
            this.btn_GestaoClientes.Text = "Gestão de Clientes";
            this.btn_GestaoClientes.UseVisualStyleBackColor = true;
            this.btn_GestaoClientes.Click += new System.EventHandler(this.btn_GestaoClientes_Click);
            // 
            // btn_MetodoPagamento
            // 
            this.btn_MetodoPagamento.Location = new System.Drawing.Point(55, 219);
            this.btn_MetodoPagamento.Name = "btn_MetodoPagamento";
            this.btn_MetodoPagamento.Size = new System.Drawing.Size(175, 86);
            this.btn_MetodoPagamento.TabIndex = 3;
            this.btn_MetodoPagamento.Text = "Registar Métodos de Pagamento";
            this.btn_MetodoPagamento.UseVisualStyleBackColor = true;
            this.btn_MetodoPagamento.Click += new System.EventHandler(this.btn_MetodoPagamento_Click);
            // 
            // btn_Pedidos
            // 
            this.btn_Pedidos.Location = new System.Drawing.Point(464, 219);
            this.btn_Pedidos.Name = "btn_Pedidos";
            this.btn_Pedidos.Size = new System.Drawing.Size(175, 86);
            this.btn_Pedidos.TabIndex = 4;
            this.btn_Pedidos.Text = "Pedidos (N/I)";
            this.btn_Pedidos.UseVisualStyleBackColor = true;
            // 
            // btn_Produtos
            // 
            this.btn_Produtos.Location = new System.Drawing.Point(260, 333);
            this.btn_Produtos.Name = "btn_Produtos";
            this.btn_Produtos.Size = new System.Drawing.Size(175, 86);
            this.btn_Produtos.TabIndex = 5;
            this.btn_Produtos.Text = "Produtos";
            this.btn_Produtos.UseVisualStyleBackColor = true;
            this.btn_Produtos.Click += new System.EventHandler(this.btn_Produtos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.btn_Produtos);
            this.Controls.Add(this.btn_Pedidos);
            this.Controls.Add(this.btn_GestaoCategorias);
            this.Controls.Add(this.btn_MetodoPagamento);
            this.Controls.Add(this.btn_GestaoClientes);
            this.Controls.Add(this.btn_GestaoFuncionarios);
            this.Controls.Add(this.btn_GestaoRestaurantes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestGest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GestaoRestaurantes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gr;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gc;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gf;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gp;
        private System.Windows.Forms.Button btn_GestaoFuncionarios;
        private System.Windows.Forms.Button btn_GestaoCategorias;
        private System.Windows.Forms.Button btn_GestaoClientes;
        private System.Windows.Forms.Button btn_MetodoPagamento;
        private System.Windows.Forms.Button btn_Pedidos;
        private System.Windows.Forms.Button btn_Produtos;
    }
}