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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LoadingPopUp_Panel = new System.Windows.Forms.Panel();
            this.Metodo_DataGridView = new System.Windows.Forms.DataGridView();
            this.IdMetodoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtivoMetodo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveMetodoPagamento = new System.Windows.Forms.Button();
            this.btnEditMetodoPagamento = new System.Windows.Forms.Button();
            this.btnAddMetodoPagamento = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFilterMetodosPagamentos = new System.Windows.Forms.TextBox();
            this.btnFilterMetodosPagamentos = new System.Windows.Forms.Button();
            this.btnCleanFilterMetodosPagamentos = new System.Windows.Forms.Button();
            this.LoadingPopUp_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Metodo_DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A carregar...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 53);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(294, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // LoadingPopUp_Panel
            // 
            this.LoadingPopUp_Panel.Controls.Add(this.progressBar1);
            this.LoadingPopUp_Panel.Controls.Add(this.label1);
            this.LoadingPopUp_Panel.Location = new System.Drawing.Point(114, 113);
            this.LoadingPopUp_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingPopUp_Panel.Name = "LoadingPopUp_Panel";
            this.LoadingPopUp_Panel.Size = new System.Drawing.Size(351, 122);
            this.LoadingPopUp_Panel.TabIndex = 3;
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
            this.Metodo_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Metodo_DataGridView.Location = new System.Drawing.Point(30, 23);
            this.Metodo_DataGridView.Name = "Metodo_DataGridView";
            this.Metodo_DataGridView.ReadOnly = true;
            this.Metodo_DataGridView.RowHeadersWidth = 51;
            this.Metodo_DataGridView.RowTemplate.Height = 24;
            this.Metodo_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Metodo_DataGridView.Size = new System.Drawing.Size(340, 295);
            this.Metodo_DataGridView.TabIndex = 3;
            this.Metodo_DataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Metodo_DataGridView_MouseDoubleClick);
            // 
            // IdMetodoPagamento
            // 
            this.IdMetodoPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdMetodoPagamento.HeaderText = "Id";
            this.IdMetodoPagamento.MinimumWidth = 6;
            this.IdMetodoPagamento.Name = "IdMetodoPagamento";
            this.IdMetodoPagamento.ReadOnly = true;
            this.IdMetodoPagamento.Width = 41;
            // 
            // Metodo
            // 
            this.Metodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Metodo.HeaderText = "Metodo";
            this.Metodo.MinimumWidth = 6;
            this.Metodo.Name = "Metodo";
            this.Metodo.ReadOnly = true;
            this.Metodo.Width = 68;
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
            this.AtivoMetodo.Width = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveMetodoPagamento);
            this.groupBox2.Controls.Add(this.btnEditMetodoPagamento);
            this.groupBox2.Controls.Add(this.btnAddMetodoPagamento);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(409, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(100, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // btnRemoveMetodoPagamento
            // 
            this.btnRemoveMetodoPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveMetodoPagamento.Location = new System.Drawing.Point(4, 73);
            this.btnRemoveMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveMetodoPagamento.Name = "btnRemoveMetodoPagamento";
            this.btnRemoveMetodoPagamento.Size = new System.Drawing.Size(92, 50);
            this.btnRemoveMetodoPagamento.TabIndex = 2;
            this.btnRemoveMetodoPagamento.Text = "Desativar / Remover";
            this.btnRemoveMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnRemoveMetodoPagamento.Click += new System.EventHandler(this.btnRemoveMetodoPagamento_Click);
            // 
            // btnEditMetodoPagamento
            // 
            this.btnEditMetodoPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditMetodoPagamento.Location = new System.Drawing.Point(4, 45);
            this.btnEditMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMetodoPagamento.Name = "btnEditMetodoPagamento";
            this.btnEditMetodoPagamento.Size = new System.Drawing.Size(92, 28);
            this.btnEditMetodoPagamento.TabIndex = 1;
            this.btnEditMetodoPagamento.Text = "Editar";
            this.btnEditMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnEditMetodoPagamento.Click += new System.EventHandler(this.btnEditMetodoPagamento_Click);
            // 
            // btnAddMetodoPagamento
            // 
            this.btnAddMetodoPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMetodoPagamento.Location = new System.Drawing.Point(4, 17);
            this.btnAddMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMetodoPagamento.Name = "btnAddMetodoPagamento";
            this.btnAddMetodoPagamento.Size = new System.Drawing.Size(92, 28);
            this.btnAddMetodoPagamento.TabIndex = 0;
            this.btnAddMetodoPagamento.Text = "Adicionar";
            this.btnAddMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnAddMetodoPagamento.Click += new System.EventHandler(this.btnAddMedodoPagamento_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.Metodo_DataGridView, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.06235F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.236908F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.476309F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(542, 401);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.32544F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.73965F));
            this.tableLayoutPanel4.Controls.Add(this.tbFilterMetodosPagamentos, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnFilterMetodosPagamentos, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCleanFilterMetodosPagamentos, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(31, 346);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(338, 30);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tbFilterMetodosPagamentos
            // 
            this.tbFilterMetodosPagamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFilterMetodosPagamentos.Location = new System.Drawing.Point(4, 4);
            this.tbFilterMetodosPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterMetodosPagamentos.Name = "tbFilterMetodosPagamentos";
            this.tbFilterMetodosPagamentos.Size = new System.Drawing.Size(178, 20);
            this.tbFilterMetodosPagamentos.TabIndex = 0;
            // 
            // btnFilterMetodosPagamentos
            // 
            this.btnFilterMetodosPagamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilterMetodosPagamentos.Location = new System.Drawing.Point(190, 4);
            this.btnFilterMetodosPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterMetodosPagamentos.Name = "btnFilterMetodosPagamentos";
            this.btnFilterMetodosPagamentos.Size = new System.Drawing.Size(56, 22);
            this.btnFilterMetodosPagamentos.TabIndex = 1;
            this.btnFilterMetodosPagamentos.Text = "Filtrar";
            this.btnFilterMetodosPagamentos.UseVisualStyleBackColor = true;
            this.btnFilterMetodosPagamentos.Click += new System.EventHandler(this.btnFilterMetodosPagamentos_Click);
            // 
            // btnCleanFilterMetodosPagamentos
            // 
            this.btnCleanFilterMetodosPagamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCleanFilterMetodosPagamentos.Location = new System.Drawing.Point(254, 4);
            this.btnCleanFilterMetodosPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleanFilterMetodosPagamentos.Name = "btnCleanFilterMetodosPagamentos";
            this.btnCleanFilterMetodosPagamentos.Size = new System.Drawing.Size(80, 22);
            this.btnCleanFilterMetodosPagamentos.TabIndex = 2;
            this.btnCleanFilterMetodosPagamentos.Text = "Limpar Filtro";
            this.btnCleanFilterMetodosPagamentos.UseVisualStyleBackColor = true;
            this.btnCleanFilterMetodosPagamentos.Click += new System.EventHandler(this.btnCleanFilterMetodosPagamentos_Click);
            // 
            // FormGestaoMetodosPagamentos
            // 
            this.ClientSize = new System.Drawing.Size(542, 401);
            this.Controls.Add(this.LoadingPopUp_Panel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.MinimumSize = new System.Drawing.Size(558, 440);
            this.Name = "FormGestaoMetodosPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestão de Métodos de Pagamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestaoMetodosPagamentos_FormClosing);
            this.Shown += new System.EventHandler(this.FormGestaoMetodosPagamentos_Shown);
            this.LoadingPopUp_Panel.ResumeLayout(false);
            this.LoadingPopUp_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Metodo_DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel LoadingPopUp_Panel;
        private System.Windows.Forms.DataGridView Metodo_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMetodoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AtivoMetodo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveMetodoPagamento;
        private System.Windows.Forms.Button btnEditMetodoPagamento;
        private System.Windows.Forms.Button btnAddMetodoPagamento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbFilterMetodosPagamentos;
        private System.Windows.Forms.Button btnFilterMetodosPagamentos;
        private System.Windows.Forms.Button btnCleanFilterMetodosPagamentos;
    }
}