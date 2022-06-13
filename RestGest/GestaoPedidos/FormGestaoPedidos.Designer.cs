
namespace RestGest.GestaoPedidos
{
    partial class FormGestaoPedidos
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
            this.LoadingPopUp_Panel = new System.Windows.Forms.Panel();
            this.LoadingPopUp_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LoadingPopUp_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pedidos_DataGridView = new System.Windows.Forms.DataGridView();
            this.IDRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeRestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_empregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_restaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Selecionar_BTN = new System.Windows.Forms.Button();
            this.Remover_BTN = new System.Windows.Forms.Button();
            this.Editar_BTN = new System.Windows.Forms.Button();
            this.Adicionar_BTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.filtrar_TextBox = new System.Windows.Forms.TextBox();
            this.filtrar_BTN = new System.Windows.Forms.Button();
            this.LimparFiltro_BTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_cancelados = new System.Windows.Forms.Button();
            this.bt_concluidos = new System.Windows.Forms.Button();
            this.bt_pendente = new System.Windows.Forms.Button();
            this.LoadingPopUp_Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidos_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadingPopUp_Panel
            // 
            this.LoadingPopUp_Panel.Controls.Add(this.LoadingPopUp_ProgressBar);
            this.LoadingPopUp_Panel.Controls.Add(this.LoadingPopUp_Label);
            this.LoadingPopUp_Panel.Location = new System.Drawing.Point(216, 164);
            this.LoadingPopUp_Panel.Name = "LoadingPopUp_Panel";
            this.LoadingPopUp_Panel.Size = new System.Drawing.Size(393, 99);
            this.LoadingPopUp_Panel.TabIndex = 5;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.pedidos_DataGridView, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.956522F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 563);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pedidos_DataGridView
            // 
            this.pedidos_DataGridView.AllowUserToAddRows = false;
            this.pedidos_DataGridView.AllowUserToDeleteRows = false;
            this.pedidos_DataGridView.AllowUserToResizeRows = false;
            this.pedidos_DataGridView.CausesValidation = false;
            this.pedidos_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidos_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRestaurante,
            this.NomeRestaurante,
            this.totalValue,
            this.client_name,
            this.name_empregado,
            this.name_restaurante});
            this.pedidos_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pedidos_DataGridView.Location = new System.Drawing.Point(23, 106);
            this.pedidos_DataGridView.Name = "pedidos_DataGridView";
            this.pedidos_DataGridView.ReadOnly = true;
            this.pedidos_DataGridView.Size = new System.Drawing.Size(662, 380);
            this.pedidos_DataGridView.TabIndex = 0;
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
            this.NomeRestaurante.HeaderText = "Estado";
            this.NomeRestaurante.Name = "NomeRestaurante";
            this.NomeRestaurante.ReadOnly = true;
            // 
            // totalValue
            // 
            this.totalValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalValue.HeaderText = "Valor Total";
            this.totalValue.Name = "totalValue";
            this.totalValue.ReadOnly = true;
            // 
            // client_name
            // 
            this.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.client_name.HeaderText = "Nome Cliente";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            // 
            // name_empregado
            // 
            this.name_empregado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_empregado.HeaderText = "Nome Empregado";
            this.name_empregado.Name = "name_empregado";
            this.name_empregado.ReadOnly = true;
            // 
            // name_restaurante
            // 
            this.name_restaurante.HeaderText = "Restaurante";
            this.name_restaurante.Name = "name_restaurante";
            this.name_restaurante.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Selecionar_BTN);
            this.groupBox1.Controls.Add(this.Remover_BTN);
            this.groupBox1.Controls.Add(this.Editar_BTN);
            this.groupBox1.Controls.Add(this.Adicionar_BTN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(711, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // Selecionar_BTN
            // 
            this.Selecionar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Selecionar_BTN.Location = new System.Drawing.Point(3, 103);
            this.Selecionar_BTN.Name = "Selecionar_BTN";
            this.Selecionar_BTN.Size = new System.Drawing.Size(99, 41);
            this.Selecionar_BTN.TabIndex = 3;
            this.Selecionar_BTN.Text = "Selecionar";
            this.Selecionar_BTN.UseVisualStyleBackColor = true;
            // 
            // Remover_BTN
            // 
            this.Remover_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Remover_BTN.Location = new System.Drawing.Point(3, 62);
            this.Remover_BTN.Name = "Remover_BTN";
            this.Remover_BTN.Size = new System.Drawing.Size(99, 41);
            this.Remover_BTN.TabIndex = 2;
            this.Remover_BTN.Text = "Cancelar Pedido";
            this.Remover_BTN.UseVisualStyleBackColor = true;
            // 
            // Editar_BTN
            // 
            this.Editar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Editar_BTN.Location = new System.Drawing.Point(3, 39);
            this.Editar_BTN.Name = "Editar_BTN";
            this.Editar_BTN.Size = new System.Drawing.Size(99, 23);
            this.Editar_BTN.TabIndex = 1;
            this.Editar_BTN.Text = "Editar";
            this.Editar_BTN.UseVisualStyleBackColor = true;
            // 
            // Adicionar_BTN
            // 
            this.Adicionar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Adicionar_BTN.Location = new System.Drawing.Point(3, 16);
            this.Adicionar_BTN.Name = "Adicionar_BTN";
            this.Adicionar_BTN.Size = new System.Drawing.Size(99, 23);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 512);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(662, 27);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // filtrar_TextBox
            // 
            this.filtrar_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtrar_TextBox.Location = new System.Drawing.Point(3, 3);
            this.filtrar_TextBox.Name = "filtrar_TextBox";
            this.filtrar_TextBox.Size = new System.Drawing.Size(523, 20);
            this.filtrar_TextBox.TabIndex = 0;
            // 
            // filtrar_BTN
            // 
            this.filtrar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtrar_BTN.Location = new System.Drawing.Point(532, 3);
            this.filtrar_BTN.Name = "filtrar_BTN";
            this.filtrar_BTN.Size = new System.Drawing.Size(60, 19);
            this.filtrar_BTN.TabIndex = 1;
            this.filtrar_BTN.Text = "Filtrar";
            this.filtrar_BTN.UseVisualStyleBackColor = true;
            // 
            // LimparFiltro_BTN
            // 
            this.LimparFiltro_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LimparFiltro_BTN.Location = new System.Drawing.Point(598, 3);
            this.LimparFiltro_BTN.Name = "LimparFiltro_BTN";
            this.LimparFiltro_BTN.Size = new System.Drawing.Size(61, 19);
            this.LimparFiltro_BTN.TabIndex = 2;
            this.LimparFiltro_BTN.Text = "Limpar Filtro";
            this.LimparFiltro_BTN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_cancelados);
            this.panel1.Controls.Add(this.bt_concluidos);
            this.panel1.Controls.Add(this.bt_pendente);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 56);
            this.panel1.TabIndex = 3;
            // 
            // bt_cancelados
            // 
            this.bt_cancelados.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_cancelados.Location = new System.Drawing.Point(162, 0);
            this.bt_cancelados.Name = "bt_cancelados";
            this.bt_cancelados.Size = new System.Drawing.Size(79, 56);
            this.bt_cancelados.TabIndex = 3;
            this.bt_cancelados.Text = "Cancelados";
            this.bt_cancelados.UseVisualStyleBackColor = true;
            this.bt_cancelados.Click += new System.EventHandler(this.bt_cancelados_Click);
            // 
            // bt_concluidos
            // 
            this.bt_concluidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_concluidos.Location = new System.Drawing.Point(73, 0);
            this.bt_concluidos.Name = "bt_concluidos";
            this.bt_concluidos.Size = new System.Drawing.Size(89, 56);
            this.bt_concluidos.TabIndex = 2;
            this.bt_concluidos.Text = "Concluidos";
            this.bt_concluidos.UseVisualStyleBackColor = true;
            this.bt_concluidos.Click += new System.EventHandler(this.bt_concluidos_Click);
            // 
            // bt_pendente
            // 
            this.bt_pendente.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_pendente.Location = new System.Drawing.Point(0, 0);
            this.bt_pendente.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.bt_pendente.Name = "bt_pendente";
            this.bt_pendente.Size = new System.Drawing.Size(73, 56);
            this.bt_pendente.TabIndex = 1;
            this.bt_pendente.Text = "Pendentes";
            this.bt_pendente.UseVisualStyleBackColor = true;
            this.bt_pendente.Click += new System.EventHandler(this.bt_pendente_Click);
            // 
            // FormGestaoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 563);
            this.Controls.Add(this.LoadingPopUp_Panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormGestaoPedidos";
            this.Text = "FormGestaoPedidos";
            this.Shown += new System.EventHandler(this.FormGestaoPedidos_Shown);
            this.LoadingPopUp_Panel.ResumeLayout(false);
            this.LoadingPopUp_Panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pedidos_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoadingPopUp_Panel;
        private System.Windows.Forms.ProgressBar LoadingPopUp_ProgressBar;
        private System.Windows.Forms.Label LoadingPopUp_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView pedidos_DataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Selecionar_BTN;
        private System.Windows.Forms.Button Remover_BTN;
        private System.Windows.Forms.Button Editar_BTN;
        private System.Windows.Forms.Button Adicionar_BTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox filtrar_TextBox;
        private System.Windows.Forms.Button filtrar_BTN;
        private System.Windows.Forms.Button LimparFiltro_BTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_cancelados;
        private System.Windows.Forms.Button bt_concluidos;
        private System.Windows.Forms.Button bt_pendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_empregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_restaurante;
    }
}