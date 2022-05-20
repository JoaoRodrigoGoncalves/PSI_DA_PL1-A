namespace RestGest
{
    partial class FormGestaoFuncionarios
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
            this.dataGrid_Funcionarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.idFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelemovelFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoradaFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicaoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Funcionarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGrid_Funcionarios, 1, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGrid_Funcionarios
            // 
            this.dataGrid_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionario,
            this.NomeFuncionario,
            this.TelemovelFuncionario,
            this.MoradaFuncionario,
            this.SalarioFuncionario,
            this.PosicaoFuncionario,
            this.NomeRestaurante});
            this.dataGrid_Funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_Funcionarios.Location = new System.Drawing.Point(23, 23);
            this.dataGrid_Funcionarios.Name = "dataGrid_Funcionarios";
            this.dataGrid_Funcionarios.Size = new System.Drawing.Size(660, 352);
            this.dataGrid_Funcionarios.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_delete);
            this.groupBox1.Controls.Add(this.bt_edit);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(709, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(68, 352);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // bt_delete
            // 
            this.bt_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_delete.Location = new System.Drawing.Point(3, 62);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(62, 23);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_edit.Location = new System.Drawing.Point(3, 39);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(62, 23);
            this.bt_edit.TabIndex = 1;
            this.bt_edit.Text = "Editar";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_add.Location = new System.Drawing.Point(3, 16);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(62, 23);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.bt_filtrar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_filter, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 401);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 25);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_filtrar.Location = new System.Drawing.Point(597, 3);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(60, 19);
            this.bt_filtrar.TabIndex = 1;
            this.bt_filtrar.Text = "Filtrar";
            this.bt_filtrar.UseVisualStyleBackColor = true;
            // 
            // tb_filter
            // 
            this.tb_filter.Location = new System.Drawing.Point(3, 3);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(588, 20);
            this.tb_filter.TabIndex = 0;
            // 
            // idFuncionario
            // 
            this.idFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idFuncionario.HeaderText = "ID";
            this.idFuncionario.Name = "idFuncionario";
            // 
            // NomeFuncionario
            // 
            this.NomeFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeFuncionario.HeaderText = "Nome";
            this.NomeFuncionario.Name = "NomeFuncionario";
            // 
            // TelemovelFuncionario
            // 
            this.TelemovelFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TelemovelFuncionario.HeaderText = "Telemovel";
            this.TelemovelFuncionario.Name = "TelemovelFuncionario";
            // 
            // MoradaFuncionario
            // 
            this.MoradaFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoradaFuncionario.HeaderText = "Morada";
            this.MoradaFuncionario.Name = "MoradaFuncionario";
            // 
            // SalarioFuncionario
            // 
            this.SalarioFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalarioFuncionario.HeaderText = "Salario";
            this.SalarioFuncionario.Name = "SalarioFuncionario";
            // 
            // PosicaoFuncionario
            // 
            this.PosicaoFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PosicaoFuncionario.HeaderText = "Posição";
            this.PosicaoFuncionario.Name = "PosicaoFuncionario";
            // 
            // NomeRestaurante
            // 
            this.NomeRestaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeRestaurante.HeaderText = "Restaurante";
            this.NomeRestaurante.Name = "NomeRestaurante";
            // 
            // FormGestaoFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormGestaoFuncionarios";
            this.Text = "Gestão Funcionarios";
            this.Load += new System.EventHandler(this.FormGestaoFuncionarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Funcionarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGrid_Funcionarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelemovelFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoradaFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicaoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeRestaurante;
    }
}