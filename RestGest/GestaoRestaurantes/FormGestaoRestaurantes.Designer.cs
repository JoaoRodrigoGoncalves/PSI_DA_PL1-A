namespace RestGest
{
    partial class FormGestaoRestaurantes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.restaurantes_DataGridView = new System.Windows.Forms.DataGridView();
            this.IDRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoradaRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidosRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrabalhadoresRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Remover_BTN = new System.Windows.Forms.Button();
            this.Editar_BTN = new System.Windows.Forms.Button();
            this.Adicionar_BTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.filtrar_TextBox = new System.Windows.Forms.TextBox();
            this.filtrar_BTN = new System.Windows.Forms.Button();
            this.LimparFiltro_BTN = new System.Windows.Forms.Button();
            this.LoadingPopUp_Panel = new System.Windows.Forms.Panel();
            this.LoadingPopUp_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LoadingPopUp_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantes_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.LoadingPopUp_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.restaurantes_DataGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // restaurantes_DataGridView
            // 
            this.restaurantes_DataGridView.AllowUserToAddRows = false;
            this.restaurantes_DataGridView.AllowUserToDeleteRows = false;
            this.restaurantes_DataGridView.AllowUserToResizeRows = false;
            this.restaurantes_DataGridView.CausesValidation = false;
            this.restaurantes_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantes_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRestaurante,
            this.NomeRestaurante,
            this.MoradaRestaurante,
            this.PedidosRestaurante,
            this.TrabalhadoresRestaurante});
            this.restaurantes_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restaurantes_DataGridView.Location = new System.Drawing.Point(23, 23);
            this.restaurantes_DataGridView.Name = "restaurantes_DataGridView";
            this.restaurantes_DataGridView.ReadOnly = true;
            this.restaurantes_DataGridView.Size = new System.Drawing.Size(804, 424);
            this.restaurantes_DataGridView.TabIndex = 0;
            this.restaurantes_DataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.restaurantes_DataGridView_MouseClick);
            this.restaurantes_DataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.restaurantes_DataGridView_MouseDoubleClick);
            // 
            // IDRestaurante
            // 
            this.IDRestaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IDRestaurante.HeaderText = "ID";
            this.IDRestaurante.Name = "IDRestaurante";
            this.IDRestaurante.ReadOnly = true;
            this.IDRestaurante.Width = 43;
            // 
            // NomeRestaurante
            // 
            this.NomeRestaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeRestaurante.HeaderText = "Nome";
            this.NomeRestaurante.Name = "NomeRestaurante";
            this.NomeRestaurante.ReadOnly = true;
            // 
            // MoradaRestaurante
            // 
            this.MoradaRestaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoradaRestaurante.HeaderText = "Morada";
            this.MoradaRestaurante.Name = "MoradaRestaurante";
            this.MoradaRestaurante.ReadOnly = true;
            // 
            // PedidosRestaurante
            // 
            this.PedidosRestaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PedidosRestaurante.HeaderText = "Pedidos";
            this.PedidosRestaurante.Name = "PedidosRestaurante";
            this.PedidosRestaurante.ReadOnly = true;
            this.PedidosRestaurante.Width = 70;
            // 
            // TrabalhadoresRestaurante
            // 
            this.TrabalhadoresRestaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TrabalhadoresRestaurante.HeaderText = "Trabalhadores";
            this.TrabalhadoresRestaurante.Name = "TrabalhadoresRestaurante";
            this.TrabalhadoresRestaurante.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Remover_BTN);
            this.groupBox1.Controls.Add(this.Editar_BTN);
            this.groupBox1.Controls.Add(this.Adicionar_BTN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(853, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 424);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // Remover_BTN
            // 
            this.Remover_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Remover_BTN.Location = new System.Drawing.Point(3, 62);
            this.Remover_BTN.Name = "Remover_BTN";
            this.Remover_BTN.Size = new System.Drawing.Size(78, 23);
            this.Remover_BTN.TabIndex = 2;
            this.Remover_BTN.Text = "Remover";
            this.Remover_BTN.UseVisualStyleBackColor = true;
            this.Remover_BTN.Click += new System.EventHandler(this.Remover_BTN_Click);
            // 
            // Editar_BTN
            // 
            this.Editar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Editar_BTN.Location = new System.Drawing.Point(3, 39);
            this.Editar_BTN.Name = "Editar_BTN";
            this.Editar_BTN.Size = new System.Drawing.Size(78, 23);
            this.Editar_BTN.TabIndex = 1;
            this.Editar_BTN.Text = "Editar";
            this.Editar_BTN.UseVisualStyleBackColor = true;
            this.Editar_BTN.Click += new System.EventHandler(this.Editar_BTN_Click);
            // 
            // Adicionar_BTN
            // 
            this.Adicionar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Adicionar_BTN.Location = new System.Drawing.Point(3, 16);
            this.Adicionar_BTN.Name = "Adicionar_BTN";
            this.Adicionar_BTN.Size = new System.Drawing.Size(78, 23);
            this.Adicionar_BTN.TabIndex = 0;
            this.Adicionar_BTN.Text = "Adicionar";
            this.Adicionar_BTN.UseVisualStyleBackColor = true;
            this.Adicionar_BTN.Click += new System.EventHandler(this.Adicionar_BTN_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.filtrar_TextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.filtrar_BTN, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LimparFiltro_BTN, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 473);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 31);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // filtrar_TextBox
            // 
            this.filtrar_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtrar_TextBox.Location = new System.Drawing.Point(3, 3);
            this.filtrar_TextBox.Name = "filtrar_TextBox";
            this.filtrar_TextBox.Size = new System.Drawing.Size(637, 20);
            this.filtrar_TextBox.TabIndex = 0;
            // 
            // filtrar_BTN
            // 
            this.filtrar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtrar_BTN.Location = new System.Drawing.Point(646, 3);
            this.filtrar_BTN.Name = "filtrar_BTN";
            this.filtrar_BTN.Size = new System.Drawing.Size(74, 23);
            this.filtrar_BTN.TabIndex = 1;
            this.filtrar_BTN.Text = "Filtrar";
            this.filtrar_BTN.UseVisualStyleBackColor = true;
            this.filtrar_BTN.Click += new System.EventHandler(this.filtrar_BTN_Click);
            // 
            // LimparFiltro_BTN
            // 
            this.LimparFiltro_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LimparFiltro_BTN.Location = new System.Drawing.Point(726, 3);
            this.LimparFiltro_BTN.Name = "LimparFiltro_BTN";
            this.LimparFiltro_BTN.Size = new System.Drawing.Size(75, 23);
            this.LimparFiltro_BTN.TabIndex = 2;
            this.LimparFiltro_BTN.Text = "Limpar Filtro";
            this.LimparFiltro_BTN.UseVisualStyleBackColor = true;
            this.LimparFiltro_BTN.Click += new System.EventHandler(this.LimparFiltro_BTN_Click);
            // 
            // LoadingPopUp_Panel
            // 
            this.LoadingPopUp_Panel.Controls.Add(this.LoadingPopUp_ProgressBar);
            this.LoadingPopUp_Panel.Controls.Add(this.LoadingPopUp_Label);
            this.LoadingPopUp_Panel.Location = new System.Drawing.Point(265, 195);
            this.LoadingPopUp_Panel.Name = "LoadingPopUp_Panel";
            this.LoadingPopUp_Panel.Size = new System.Drawing.Size(393, 99);
            this.LoadingPopUp_Panel.TabIndex = 1;
            // 
            // LoadingPopUp_ProgressBar
            // 
            this.LoadingPopUp_ProgressBar.Location = new System.Drawing.Point(20, 43);
            this.LoadingPopUp_ProgressBar.Name = "LoadingPopUp_ProgressBar";
            this.LoadingPopUp_ProgressBar.Size = new System.Drawing.Size(353, 23);
            this.LoadingPopUp_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingPopUp_ProgressBar.TabIndex = 1;
            // 
            // LoadingPopUp_Label
            // 
            this.LoadingPopUp_Label.AutoSize = true;
            this.LoadingPopUp_Label.Location = new System.Drawing.Point(17, 27);
            this.LoadingPopUp_Label.Name = "LoadingPopUp_Label";
            this.LoadingPopUp_Label.Size = new System.Drawing.Size(65, 13);
            this.LoadingPopUp_Label.TabIndex = 0;
            this.LoadingPopUp_Label.Text = "A carregar...";
            // 
            // FormGestaoRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 528);
            this.Controls.Add(this.LoadingPopUp_Panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(978, 567);
            this.Name = "FormGestaoRestaurantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Restaurantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestaoRestaurantes_FormClosing);
            this.Shown += new System.EventHandler(this.FormGestaoRestaurantes_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantes_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.LoadingPopUp_Panel.ResumeLayout(false);
            this.LoadingPopUp_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView restaurantes_DataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Adicionar_BTN;
        private System.Windows.Forms.Button Remover_BTN;
        private System.Windows.Forms.Button Editar_BTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox filtrar_TextBox;
        private System.Windows.Forms.Button filtrar_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoradaRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidosRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrabalhadoresRestaurante;
        private System.Windows.Forms.Panel LoadingPopUp_Panel;
        private System.Windows.Forms.ProgressBar LoadingPopUp_ProgressBar;
        private System.Windows.Forms.Label LoadingPopUp_Label;
        private System.Windows.Forms.Button LimparFiltro_BTN;
    }
}