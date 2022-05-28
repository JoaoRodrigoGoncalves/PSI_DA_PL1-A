namespace RestGest
{
    partial class FormGestaoClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Remover_BTN = new System.Windows.Forms.Button();
            this.Editar_BTN = new System.Windows.Forms.Button();
            this.Adicionar_BTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Clientes_DataGridView = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nifCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadingPopUp_Label = new System.Windows.Forms.Label();
            this.LoadingPopUp_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LoadingPopUp_Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_DataGridView)).BeginInit();
            this.LoadingPopUp_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Clientes_DataGridView, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Remover_BTN);
            this.groupBox1.Controls.Add(this.Editar_BTN);
            this.groupBox1.Controls.Add(this.Adicionar_BTN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1138, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(112, 521);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // Remover_BTN
            // 
            this.Remover_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Remover_BTN.Location = new System.Drawing.Point(4, 75);
            this.Remover_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.Remover_BTN.Name = "Remover_BTN";
            this.Remover_BTN.Size = new System.Drawing.Size(104, 50);
            this.Remover_BTN.TabIndex = 2;
            this.Remover_BTN.Text = "Remover";
            this.Remover_BTN.UseVisualStyleBackColor = true;
            this.Remover_BTN.Click += new System.EventHandler(this.Remover_BTN_Click_1);
            // 
            // Editar_BTN
            // 
            this.Editar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Editar_BTN.Location = new System.Drawing.Point(4, 47);
            this.Editar_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.Editar_BTN.Name = "Editar_BTN";
            this.Editar_BTN.Size = new System.Drawing.Size(104, 28);
            this.Editar_BTN.TabIndex = 1;
            this.Editar_BTN.Text = "Editar";
            this.Editar_BTN.UseVisualStyleBackColor = true;
            this.Editar_BTN.Click += new System.EventHandler(this.Editar_BTN_Click_1);
            // 
            // Adicionar_BTN
            // 
            this.Adicionar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Adicionar_BTN.Location = new System.Drawing.Point(4, 19);
            this.Adicionar_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.Adicionar_BTN.Name = "Adicionar_BTN";
            this.Adicionar_BTN.Size = new System.Drawing.Size(104, 28);
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
            this.tableLayoutPanel2.Controls.Add(this.tbFiltrar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFiltrar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLimpar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(31, 583);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1072, 38);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFiltrar.Location = new System.Drawing.Point(4, 4);
            this.tbFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(849, 22);
            this.tbFiltrar.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiltrar.Location = new System.Drawing.Point(861, 4);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(99, 28);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLimpar.Location = new System.Drawing.Point(968, 4);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar Filtro";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Clientes_DataGridView
            // 
            this.Clientes_DataGridView.AllowUserToAddRows = false;
            this.Clientes_DataGridView.AllowUserToDeleteRows = false;
            this.Clientes_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clientes_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.nomeClient,
            this.telCliente,
            this.nifCliente,
            this.moradaClient});
            this.Clientes_DataGridView.Location = new System.Drawing.Point(30, 28);
            this.Clientes_DataGridView.Name = "Clientes_DataGridView";
            this.Clientes_DataGridView.ReadOnly = true;
            this.Clientes_DataGridView.RowHeadersWidth = 51;
            this.Clientes_DataGridView.RowTemplate.Height = 24;
            this.Clientes_DataGridView.Size = new System.Drawing.Size(1074, 522);
            this.Clientes_DataGridView.TabIndex = 3;
            this.Clientes_DataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clientes_DataGridView_MouseClick);
            this.Clientes_DataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Clientes_DataGridView_MouseDoubleClick_1);
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 48;
            // 
            // nomeClient
            // 
            this.nomeClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeClient.HeaderText = "Nome";
            this.nomeClient.MinimumWidth = 6;
            this.nomeClient.Name = "nomeClient";
            this.nomeClient.ReadOnly = true;
            // 
            // telCliente
            // 
            this.telCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telCliente.HeaderText = "Telemóvel";
            this.telCliente.MinimumWidth = 6;
            this.telCliente.Name = "telCliente";
            this.telCliente.ReadOnly = true;
            this.telCliente.Width = 102;
            // 
            // nifCliente
            // 
            this.nifCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nifCliente.HeaderText = "NIF";
            this.nifCliente.MinimumWidth = 6;
            this.nifCliente.Name = "nifCliente";
            this.nifCliente.ReadOnly = true;
            this.nifCliente.Width = 58;
            // 
            // moradaClient
            // 
            this.moradaClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moradaClient.HeaderText = "Morada";
            this.moradaClient.MinimumWidth = 6;
            this.moradaClient.Name = "moradaClient";
            this.moradaClient.ReadOnly = true;
            // 
            // LoadingPopUp_Label
            // 
            this.LoadingPopUp_Label.AutoSize = true;
            this.LoadingPopUp_Label.Location = new System.Drawing.Point(23, 33);
            this.LoadingPopUp_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadingPopUp_Label.Name = "LoadingPopUp_Label";
            this.LoadingPopUp_Label.Size = new System.Drawing.Size(87, 17);
            this.LoadingPopUp_Label.TabIndex = 0;
            this.LoadingPopUp_Label.Text = "A carregar...";
            // 
            // LoadingPopUp_ProgressBar
            // 
            this.LoadingPopUp_ProgressBar.Location = new System.Drawing.Point(27, 53);
            this.LoadingPopUp_ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingPopUp_ProgressBar.Name = "LoadingPopUp_ProgressBar";
            this.LoadingPopUp_ProgressBar.Size = new System.Drawing.Size(471, 28);
            this.LoadingPopUp_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingPopUp_ProgressBar.TabIndex = 1;
            // 
            // LoadingPopUp_Panel
            // 
            this.LoadingPopUp_Panel.Controls.Add(this.LoadingPopUp_ProgressBar);
            this.LoadingPopUp_Panel.Controls.Add(this.LoadingPopUp_Label);
            this.LoadingPopUp_Panel.Location = new System.Drawing.Point(353, 240);
            this.LoadingPopUp_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingPopUp_Panel.Name = "LoadingPopUp_Panel";
            this.LoadingPopUp_Panel.Size = new System.Drawing.Size(524, 122);
            this.LoadingPopUp_Panel.TabIndex = 1;
            // 
            // FormGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 650);
            this.Controls.Add(this.LoadingPopUp_Panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1298, 687);
            this.Name = "FormGestaoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestaoRestaurantes_FormClosing);
            this.Shown += new System.EventHandler(this.FormGestaoClientes_Shown_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_DataGridView)).EndInit();
            this.LoadingPopUp_Panel.ResumeLayout(false);
            this.LoadingPopUp_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Adicionar_BTN;
        private System.Windows.Forms.Button Remover_BTN;
        private System.Windows.Forms.Button Editar_BTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label LoadingPopUp_Label;
        private System.Windows.Forms.ProgressBar LoadingPopUp_ProgressBar;
        private System.Windows.Forms.Panel LoadingPopUp_Panel;
        private System.Windows.Forms.DataGridView Clientes_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn telCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaClient;
    }
}