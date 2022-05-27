namespace RestGest
{
    partial class FormGestaoMetodosPagamentos
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveMetodoPagamento = new System.Windows.Forms.Button();
            this.btnEditMetodoPagamento = new System.Windows.Forms.Button();
            this.btnAddMedodoPagamento = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFilterMetodosPagamentos = new System.Windows.Forms.TextBox();
            this.btnFilterMetodosPagamentos = new System.Windows.Forms.Button();
            this.btnCleanFilterMetodosPagamentos = new System.Windows.Forms.Button();
            this.Metodo_DataGridView = new System.Windows.Forms.DataGridView();
            this.IdMetodoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtivoMetodo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_DataGridView)).BeginInit();
            this.LoadingPopUp_Panel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Metodo_DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.Metodo_DataGridView, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1158, 618);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveMetodoPagamento);
            this.groupBox2.Controls.Add(this.btnEditMetodoPagamento);
            this.groupBox2.Controls.Add(this.btnAddMedodoPagamento);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(1025, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(99, 491);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btnRemoveMetodoPagamento
            // 
            this.btnRemoveMetodoPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveMetodoPagamento.Location = new System.Drawing.Point(4, 75);
            this.btnRemoveMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveMetodoPagamento.Name = "btnRemoveMetodoPagamento";
            this.btnRemoveMetodoPagamento.Size = new System.Drawing.Size(91, 50);
            this.btnRemoveMetodoPagamento.TabIndex = 2;
            this.btnRemoveMetodoPagamento.Text = "Remover";
            this.btnRemoveMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnRemoveMetodoPagamento.Click += new System.EventHandler(this.btnRemoveMetodoPagamento_Click);
            // 
            // btnEditMetodoPagamento
            // 
            this.btnEditMetodoPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditMetodoPagamento.Location = new System.Drawing.Point(4, 47);
            this.btnEditMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMetodoPagamento.Name = "btnEditMetodoPagamento";
            this.btnEditMetodoPagamento.Size = new System.Drawing.Size(91, 28);
            this.btnEditMetodoPagamento.TabIndex = 1;
            this.btnEditMetodoPagamento.Text = "Editar";
            this.btnEditMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnEditMetodoPagamento.Click += new System.EventHandler(this.btnEditMetodoPagamento_Click);
            // 
            // btnAddMedodoPagamento
            // 
            this.btnAddMedodoPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMedodoPagamento.Location = new System.Drawing.Point(4, 19);
            this.btnAddMedodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMedodoPagamento.Name = "btnAddMedodoPagamento";
            this.btnAddMedodoPagamento.Size = new System.Drawing.Size(91, 28);
            this.btnAddMedodoPagamento.TabIndex = 0;
            this.btnAddMedodoPagamento.Text = "Adicionar";
            this.btnAddMedodoPagamento.UseVisualStyleBackColor = true;
            this.btnAddMedodoPagamento.Click += new System.EventHandler(this.btnAddMedodoPagamento_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Controls.Add(this.tbFilterMetodosPagamentos, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFilterMetodosPagamentos, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCleanFilterMetodosPagamentos, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(31, 553);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(959, 35);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tbFilterMetodosPagamentos
            // 
            this.tbFilterMetodosPagamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFilterMetodosPagamentos.Location = new System.Drawing.Point(4, 4);
            this.tbFilterMetodosPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterMetodosPagamentos.Name = "tbFilterMetodosPagamentos";
            this.tbFilterMetodosPagamentos.Size = new System.Drawing.Size(759, 22);
            this.tbFilterMetodosPagamentos.TabIndex = 0;
            // 
            // btnFilterMetodosPagamentos
            // 
            this.btnFilterMetodosPagamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilterMetodosPagamentos.Location = new System.Drawing.Point(771, 4);
            this.btnFilterMetodosPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterMetodosPagamentos.Name = "btnFilterMetodosPagamentos";
            this.btnFilterMetodosPagamentos.Size = new System.Drawing.Size(87, 27);
            this.btnFilterMetodosPagamentos.TabIndex = 1;
            this.btnFilterMetodosPagamentos.Text = "Filtrar";
            this.btnFilterMetodosPagamentos.UseVisualStyleBackColor = true;
            this.btnFilterMetodosPagamentos.Click += new System.EventHandler(this.btnFilterMetodosPagamentos_Click);
            // 
            // btnCleanFilterMetodosPagamentos
            // 
            this.btnCleanFilterMetodosPagamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCleanFilterMetodosPagamentos.Location = new System.Drawing.Point(866, 4);
            this.btnCleanFilterMetodosPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleanFilterMetodosPagamentos.Name = "btnCleanFilterMetodosPagamentos";
            this.btnCleanFilterMetodosPagamentos.Size = new System.Drawing.Size(89, 27);
            this.btnCleanFilterMetodosPagamentos.TabIndex = 2;
            this.btnCleanFilterMetodosPagamentos.Text = "Limpar Filtro";
            this.btnCleanFilterMetodosPagamentos.UseVisualStyleBackColor = true;
            this.btnCleanFilterMetodosPagamentos.Click += new System.EventHandler(this.btnCleanFilterMetodosPagamentos_Click);
            // 
            // Metodo_DataGridView
            // 
            this.Metodo_DataGridView.AllowUserToAddRows = false;
            this.Metodo_DataGridView.AllowUserToDeleteRows = false;
            this.Metodo_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Metodo_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMetodoPagamento,
            this.Metodo,
            this.AtivoMetodo});
            this.Metodo_DataGridView.Location = new System.Drawing.Point(30, 28);
            this.Metodo_DataGridView.Name = "Metodo_DataGridView";
            this.Metodo_DataGridView.ReadOnly = true;
            this.Metodo_DataGridView.RowHeadersWidth = 51;
            this.Metodo_DataGridView.RowTemplate.Height = 24;
            this.Metodo_DataGridView.Size = new System.Drawing.Size(961, 493);
            this.Metodo_DataGridView.TabIndex = 3;
            this.Metodo_DataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Metodo_DataGridView_MouseClick);
            this.Metodo_DataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Metodo_DataGridView_MouseDoubleClick);
            // 
            // IdMetodoPagamento
            // 
            this.IdMetodoPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdMetodoPagamento.HeaderText = "Id";
            this.IdMetodoPagamento.MinimumWidth = 6;
            this.IdMetodoPagamento.Name = "IdMetodoPagamento";
            this.IdMetodoPagamento.ReadOnly = true;
            this.IdMetodoPagamento.Width = 48;
            // 
            // Metodo
            // 
            this.Metodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Metodo.HeaderText = "Metodo";
            this.Metodo.MinimumWidth = 6;
            this.Metodo.Name = "Metodo";
            this.Metodo.ReadOnly = true;
            this.Metodo.Width = 84;
            // 
            // AtivoMetodo
            // 
            this.AtivoMetodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AtivoMetodo.HeaderText = "Ativo";
            this.AtivoMetodo.MinimumWidth = 6;
            this.AtivoMetodo.Name = "AtivoMetodo";
            this.AtivoMetodo.ReadOnly = true;
            this.AtivoMetodo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AtivoMetodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AtivoMetodo.Width = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A carregar...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 53);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(471, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(353, 240);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 122);
            this.panel1.TabIndex = 3;
            // 
            // FormGestaoMetodosPagamentos
            // 
            this.ClientSize = new System.Drawing.Size(1158, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "FormGestaoMetodosPagamentos";
            this.Text = "Gestão de Métodos de Pagamentos";
            this.Shown += new System.EventHandler(this.FormGestaoMetodosPagamentos_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_DataGridView)).EndInit();
            this.LoadingPopUp_Panel.ResumeLayout(false);
            this.LoadingPopUp_Panel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Metodo_DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveMetodoPagamento;
        private System.Windows.Forms.Button btnEditMetodoPagamento;
        private System.Windows.Forms.Button btnAddMedodoPagamento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbFilterMetodosPagamentos;
        private System.Windows.Forms.Button btnFilterMetodosPagamentos;
        private System.Windows.Forms.Button btnCleanFilterMetodosPagamentos;
        private System.Windows.Forms.DataGridView Metodo_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMetodoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AtivoMetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
    }
}