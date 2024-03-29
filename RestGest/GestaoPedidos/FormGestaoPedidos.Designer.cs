﻿
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
            this.name_restaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_empregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Selecionar_BTN = new System.Windows.Forms.Button();
            this.Detalhes_BTN = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.filtrar_BTN = new System.Windows.Forms.Button();
            this.LimparFiltro_BTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_all = new System.Windows.Forms.Button();
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
            this.LoadingPopUp_Panel.Location = new System.Drawing.Point(288, 202);
            this.LoadingPopUp_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingPopUp_Panel.Name = "LoadingPopUp_Panel";
            this.LoadingPopUp_Panel.Size = new System.Drawing.Size(524, 122);
            this.LoadingPopUp_Panel.TabIndex = 5;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Controls.Add(this.pedidos_DataGridView, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.956522F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 693);
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
            this.name_restaurante,
            this.client_name,
            this.name_empregado,
            this.totalValue});
            this.pedidos_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pedidos_DataGridView.Location = new System.Drawing.Point(31, 131);
            this.pedidos_DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pedidos_DataGridView.Name = "pedidos_DataGridView";
            this.pedidos_DataGridView.ReadOnly = true;
            this.pedidos_DataGridView.RowHeadersWidth = 51;
            this.pedidos_DataGridView.Size = new System.Drawing.Size(883, 466);
            this.pedidos_DataGridView.TabIndex = 0;
            this.pedidos_DataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pedidos_DataGridView_MouseDoubleClick);
            // 
            // IDRestaurante
            // 
            this.IDRestaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IDRestaurante.HeaderText = "ID";
            this.IDRestaurante.MinimumWidth = 6;
            this.IDRestaurante.Name = "IDRestaurante";
            this.IDRestaurante.ReadOnly = true;
            this.IDRestaurante.Width = 50;
            // 
            // NomeRestaurante
            // 
            this.NomeRestaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeRestaurante.HeaderText = "Estado";
            this.NomeRestaurante.MinimumWidth = 6;
            this.NomeRestaurante.Name = "NomeRestaurante";
            this.NomeRestaurante.ReadOnly = true;
            // 
            // name_restaurante
            // 
            this.name_restaurante.HeaderText = "Restaurante";
            this.name_restaurante.MinimumWidth = 6;
            this.name_restaurante.Name = "name_restaurante";
            this.name_restaurante.ReadOnly = true;
            this.name_restaurante.Width = 125;
            // 
            // client_name
            // 
            this.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.client_name.HeaderText = "Nome Cliente";
            this.client_name.MinimumWidth = 6;
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            // 
            // name_empregado
            // 
            this.name_empregado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_empregado.HeaderText = "Nome Empregado";
            this.name_empregado.MinimumWidth = 6;
            this.name_empregado.Name = "name_empregado";
            this.name_empregado.ReadOnly = true;
            // 
            // totalValue
            // 
            this.totalValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalValue.HeaderText = "Valor Total";
            this.totalValue.MinimumWidth = 6;
            this.totalValue.Name = "totalValue";
            this.totalValue.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Selecionar_BTN);
            this.groupBox1.Controls.Add(this.Detalhes_BTN);
            this.groupBox1.Controls.Add(this.bt_cancelar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(949, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(140, 466);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // Selecionar_BTN
            // 
            this.Selecionar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Selecionar_BTN.Enabled = false;
            this.Selecionar_BTN.Location = new System.Drawing.Point(4, 119);
            this.Selecionar_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.Selecionar_BTN.Name = "Selecionar_BTN";
            this.Selecionar_BTN.Size = new System.Drawing.Size(132, 50);
            this.Selecionar_BTN.TabIndex = 4;
            this.Selecionar_BTN.Text = "Selecionar";
            this.Selecionar_BTN.UseVisualStyleBackColor = true;
            this.Selecionar_BTN.Click += new System.EventHandler(this.Selecionar_BTN_Click);
            // 
            // Detalhes_BTN
            // 
            this.Detalhes_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detalhes_BTN.Location = new System.Drawing.Point(4, 69);
            this.Detalhes_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.Detalhes_BTN.Name = "Detalhes_BTN";
            this.Detalhes_BTN.Size = new System.Drawing.Size(132, 50);
            this.Detalhes_BTN.TabIndex = 3;
            this.Detalhes_BTN.Text = "Detalhes";
            this.Detalhes_BTN.UseVisualStyleBackColor = true;
            this.Detalhes_BTN.Click += new System.EventHandler(this.Detalhes_BTN_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_cancelar.Location = new System.Drawing.Point(4, 19);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(132, 50);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.Text = "Cancelar Pedido";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.tb_filter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.filtrar_BTN, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LimparFiltro_BTN, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(31, 630);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(883, 33);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tb_filter
            // 
            this.tb_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_filter.Location = new System.Drawing.Point(4, 4);
            this.tb_filter.Margin = new System.Windows.Forms.Padding(4);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(698, 22);
            this.tb_filter.TabIndex = 0;
            // 
            // filtrar_BTN
            // 
            this.filtrar_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtrar_BTN.Location = new System.Drawing.Point(710, 4);
            this.filtrar_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.filtrar_BTN.Name = "filtrar_BTN";
            this.filtrar_BTN.Size = new System.Drawing.Size(80, 23);
            this.filtrar_BTN.TabIndex = 1;
            this.filtrar_BTN.Text = "Filtrar";
            this.filtrar_BTN.UseVisualStyleBackColor = true;
            this.filtrar_BTN.Click += new System.EventHandler(this.bt_filter_Click);
            // 
            // LimparFiltro_BTN
            // 
            this.LimparFiltro_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LimparFiltro_BTN.Location = new System.Drawing.Point(798, 4);
            this.LimparFiltro_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.LimparFiltro_BTN.Name = "LimparFiltro_BTN";
            this.LimparFiltro_BTN.Size = new System.Drawing.Size(81, 23);
            this.LimparFiltro_BTN.TabIndex = 2;
            this.LimparFiltro_BTN.Text = "Limpar Filtro";
            this.LimparFiltro_BTN.UseVisualStyleBackColor = true;
            this.LimparFiltro_BTN.Click += new System.EventHandler(this.LimparFiltro_BTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_all);
            this.panel1.Controls.Add(this.bt_cancelados);
            this.panel1.Controls.Add(this.bt_concluidos);
            this.panel1.Controls.Add(this.bt_pendente);
            this.panel1.Location = new System.Drawing.Point(31, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 69);
            this.panel1.TabIndex = 3;
            // 
            // bt_all
            // 
            this.bt_all.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_all.Location = new System.Drawing.Point(321, 0);
            this.bt_all.Margin = new System.Windows.Forms.Padding(4);
            this.bt_all.Name = "bt_all";
            this.bt_all.Size = new System.Drawing.Size(105, 69);
            this.bt_all.TabIndex = 4;
            this.bt_all.Text = "Ver Todos";
            this.bt_all.UseVisualStyleBackColor = true;
            this.bt_all.Click += new System.EventHandler(this.bt_all_Click);
            // 
            // bt_cancelados
            // 
            this.bt_cancelados.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_cancelados.Location = new System.Drawing.Point(216, 0);
            this.bt_cancelados.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancelados.Name = "bt_cancelados";
            this.bt_cancelados.Size = new System.Drawing.Size(105, 69);
            this.bt_cancelados.TabIndex = 3;
            this.bt_cancelados.Text = "Cancelados";
            this.bt_cancelados.UseVisualStyleBackColor = true;
            this.bt_cancelados.Click += new System.EventHandler(this.bt_cancelados_Click);
            // 
            // bt_concluidos
            // 
            this.bt_concluidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_concluidos.Location = new System.Drawing.Point(97, 0);
            this.bt_concluidos.Margin = new System.Windows.Forms.Padding(4);
            this.bt_concluidos.Name = "bt_concluidos";
            this.bt_concluidos.Size = new System.Drawing.Size(119, 69);
            this.bt_concluidos.TabIndex = 2;
            this.bt_concluidos.Text = "Concluidos";
            this.bt_concluidos.UseVisualStyleBackColor = true;
            this.bt_concluidos.Click += new System.EventHandler(this.bt_concluidos_Click);
            // 
            // bt_pendente
            // 
            this.bt_pendente.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_pendente.Location = new System.Drawing.Point(0, 0);
            this.bt_pendente.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.bt_pendente.Name = "bt_pendente";
            this.bt_pendente.Size = new System.Drawing.Size(97, 69);
            this.bt_pendente.TabIndex = 1;
            this.bt_pendente.Text = "Pendentes";
            this.bt_pendente.UseVisualStyleBackColor = true;
            this.bt_pendente.Click += new System.EventHandler(this.bt_pendente_Click);
            // 
            // FormGestaoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 693);
            this.Controls.Add(this.LoadingPopUp_Panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestaoPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGestaoPedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestaoPedidos_FormClosing);
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
        private System.Windows.Forms.Button Detalhes_BTN;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Button filtrar_BTN;
        private System.Windows.Forms.Button LimparFiltro_BTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_cancelados;
        private System.Windows.Forms.Button bt_concluidos;
        private System.Windows.Forms.Button bt_pendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeRestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_restaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_empregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalValue;
        private System.Windows.Forms.Button Selecionar_BTN;
        private System.Windows.Forms.Button bt_all;
    }
}