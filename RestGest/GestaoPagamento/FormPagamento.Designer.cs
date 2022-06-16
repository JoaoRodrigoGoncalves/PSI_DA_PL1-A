namespace RestGest.GestaoPagamento
{
    partial class FormPagamento
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
            this.cb_MetodosPagamentos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_num_0 = new System.Windows.Forms.Button();
            this.bt_enter = new System.Windows.Forms.Button();
            this.bt_num_9 = new System.Windows.Forms.Button();
            this.bt_num_8 = new System.Windows.Forms.Button();
            this.bt_num_7 = new System.Windows.Forms.Button();
            this.bt_num_6 = new System.Windows.Forms.Button();
            this.bt_num_5 = new System.Windows.Forms.Button();
            this.bt_num_4 = new System.Windows.Forms.Button();
            this.bt_num_3 = new System.Windows.Forms.Button();
            this.bt_num_2 = new System.Windows.Forms.Button();
            this.bt_num_1 = new System.Windows.Forms.Button();
            this.nb_value = new System.Windows.Forms.NumericUpDown();
            this.bt_concluir = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_valor_to_pay = new System.Windows.Forms.TextBox();
            this.lb_pagamentos = new System.Windows.Forms.ListBox();
            this.bt_remove_payment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_value)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo de Pagamento:";
            // 
            // cb_MetodosPagamentos
            // 
            this.cb_MetodosPagamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MetodosPagamentos.FormattingEnabled = true;
            this.cb_MetodosPagamentos.Location = new System.Drawing.Point(12, 43);
            this.cb_MetodosPagamentos.Name = "cb_MetodosPagamentos";
            this.cb_MetodosPagamentos.Size = new System.Drawing.Size(118, 21);
            this.cb_MetodosPagamentos.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.nb_value);
            this.panel1.Location = new System.Drawing.Point(163, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 333);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.bt_remove, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_enter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_num_1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 295);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.Color.Firebrick;
            this.bt_remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.Location = new System.Drawing.Point(205, 222);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(97, 70);
            this.bt_remove.TabIndex = 11;
            this.bt_remove.Text = "Clear";
            this.bt_remove.UseVisualStyleBackColor = false;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_num_0
            // 
            this.bt_num_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_0.Location = new System.Drawing.Point(104, 222);
            this.bt_num_0.Name = "bt_num_0";
            this.bt_num_0.Size = new System.Drawing.Size(95, 70);
            this.bt_num_0.TabIndex = 10;
            this.bt_num_0.Text = "0";
            this.bt_num_0.UseVisualStyleBackColor = true;
            this.bt_num_0.Click += new System.EventHandler(this.bt_num_0_Click);
            // 
            // bt_enter
            // 
            this.bt_enter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bt_enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enter.Location = new System.Drawing.Point(3, 222);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(95, 70);
            this.bt_enter.TabIndex = 9;
            this.bt_enter.Text = "Enter";
            this.bt_enter.UseVisualStyleBackColor = false;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // bt_num_9
            // 
            this.bt_num_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_9.Location = new System.Drawing.Point(205, 149);
            this.bt_num_9.Name = "bt_num_9";
            this.bt_num_9.Size = new System.Drawing.Size(97, 67);
            this.bt_num_9.TabIndex = 8;
            this.bt_num_9.Text = "9";
            this.bt_num_9.UseVisualStyleBackColor = true;
            this.bt_num_9.Click += new System.EventHandler(this.bt_num_9_Click);
            // 
            // bt_num_8
            // 
            this.bt_num_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_8.Location = new System.Drawing.Point(104, 149);
            this.bt_num_8.Name = "bt_num_8";
            this.bt_num_8.Size = new System.Drawing.Size(95, 67);
            this.bt_num_8.TabIndex = 7;
            this.bt_num_8.Text = "8";
            this.bt_num_8.UseVisualStyleBackColor = true;
            this.bt_num_8.Click += new System.EventHandler(this.bt_num_8_Click);
            // 
            // bt_num_7
            // 
            this.bt_num_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_7.Location = new System.Drawing.Point(3, 149);
            this.bt_num_7.Name = "bt_num_7";
            this.bt_num_7.Size = new System.Drawing.Size(95, 67);
            this.bt_num_7.TabIndex = 6;
            this.bt_num_7.Text = "7";
            this.bt_num_7.UseVisualStyleBackColor = true;
            this.bt_num_7.Click += new System.EventHandler(this.bt_num_7_Click);
            // 
            // bt_num_6
            // 
            this.bt_num_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_6.Location = new System.Drawing.Point(205, 76);
            this.bt_num_6.Name = "bt_num_6";
            this.bt_num_6.Size = new System.Drawing.Size(97, 67);
            this.bt_num_6.TabIndex = 5;
            this.bt_num_6.Text = "6";
            this.bt_num_6.UseVisualStyleBackColor = true;
            this.bt_num_6.Click += new System.EventHandler(this.bt_num_6_Click);
            // 
            // bt_num_5
            // 
            this.bt_num_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_5.Location = new System.Drawing.Point(104, 76);
            this.bt_num_5.Name = "bt_num_5";
            this.bt_num_5.Size = new System.Drawing.Size(95, 67);
            this.bt_num_5.TabIndex = 4;
            this.bt_num_5.Text = "5";
            this.bt_num_5.UseVisualStyleBackColor = true;
            this.bt_num_5.Click += new System.EventHandler(this.bt_num_5_Click);
            // 
            // bt_num_4
            // 
            this.bt_num_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_4.Location = new System.Drawing.Point(3, 76);
            this.bt_num_4.Name = "bt_num_4";
            this.bt_num_4.Size = new System.Drawing.Size(95, 67);
            this.bt_num_4.TabIndex = 3;
            this.bt_num_4.Text = "4";
            this.bt_num_4.UseVisualStyleBackColor = true;
            this.bt_num_4.Click += new System.EventHandler(this.bt_num_4_Click);
            // 
            // bt_num_3
            // 
            this.bt_num_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_3.Location = new System.Drawing.Point(205, 3);
            this.bt_num_3.Name = "bt_num_3";
            this.bt_num_3.Size = new System.Drawing.Size(97, 67);
            this.bt_num_3.TabIndex = 2;
            this.bt_num_3.Text = "3";
            this.bt_num_3.UseVisualStyleBackColor = true;
            this.bt_num_3.Click += new System.EventHandler(this.bt_num_3_Click);
            // 
            // bt_num_2
            // 
            this.bt_num_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_2.Location = new System.Drawing.Point(104, 3);
            this.bt_num_2.Name = "bt_num_2";
            this.bt_num_2.Size = new System.Drawing.Size(95, 67);
            this.bt_num_2.TabIndex = 1;
            this.bt_num_2.Text = "2";
            this.bt_num_2.UseVisualStyleBackColor = true;
            this.bt_num_2.Click += new System.EventHandler(this.bt_num_2_Click);
            // 
            // bt_num_1
            // 
            this.bt_num_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_num_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_num_1.Location = new System.Drawing.Point(3, 3);
            this.bt_num_1.Name = "bt_num_1";
            this.bt_num_1.Size = new System.Drawing.Size(95, 67);
            this.bt_num_1.TabIndex = 0;
            this.bt_num_1.Text = "1";
            this.bt_num_1.UseVisualStyleBackColor = true;
            this.bt_num_1.Click += new System.EventHandler(this.bt_num_1_Click);
            // 
            // nb_value
            // 
            this.nb_value.DecimalPlaces = 2;
            this.nb_value.Dock = System.Windows.Forms.DockStyle.Top;
            this.nb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb_value.Location = new System.Drawing.Point(0, 0);
            this.nb_value.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nb_value.Name = "nb_value";
            this.nb_value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nb_value.Size = new System.Drawing.Size(305, 38);
            this.nb_value.TabIndex = 2;
            // 
            // bt_concluir
            // 
            this.bt_concluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_concluir.Location = new System.Drawing.Point(163, 415);
            this.bt_concluir.Name = "bt_concluir";
            this.bt_concluir.Size = new System.Drawing.Size(141, 66);
            this.bt_concluir.TabIndex = 8;
            this.bt_concluir.Text = "Concluir Pagamento";
            this.bt_concluir.UseVisualStyleBackColor = true;
            this.bt_concluir.Click += new System.EventHandler(this.bt_concluir_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(331, 415);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(137, 66);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Cancelar Pagamento";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor a pagar:";
            // 
            // tb_valor_to_pay
            // 
            this.tb_valor_to_pay.Location = new System.Drawing.Point(12, 100);
            this.tb_valor_to_pay.Name = "tb_valor_to_pay";
            this.tb_valor_to_pay.ReadOnly = true;
            this.tb_valor_to_pay.Size = new System.Drawing.Size(118, 20);
            this.tb_valor_to_pay.TabIndex = 9;
            // 
            // lb_pagamentos
            // 
            this.lb_pagamentos.FormattingEnabled = true;
            this.lb_pagamentos.HorizontalScrollbar = true;
            this.lb_pagamentos.Location = new System.Drawing.Point(513, 38);
            this.lb_pagamentos.Name = "lb_pagamentos";
            this.lb_pagamentos.Size = new System.Drawing.Size(153, 303);
            this.lb_pagamentos.TabIndex = 10;
            // 
            // bt_remove_payment
            // 
            this.bt_remove_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove_payment.Location = new System.Drawing.Point(513, 347);
            this.bt_remove_payment.Name = "bt_remove_payment";
            this.bt_remove_payment.Size = new System.Drawing.Size(153, 66);
            this.bt_remove_payment.TabIndex = 8;
            this.bt_remove_payment.Text = "Delete Payment";
            this.bt_remove_payment.UseVisualStyleBackColor = true;
            this.bt_remove_payment.Click += new System.EventHandler(this.bt_remove_payment_Click);
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 493);
            this.Controls.Add(this.lb_pagamentos);
            this.Controls.Add(this.tb_valor_to_pay);
            this.Controls.Add(this.bt_remove_payment);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_concluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_MetodosPagamentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nb_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_MetodosPagamentos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_num_0;
        private System.Windows.Forms.Button bt_enter;
        private System.Windows.Forms.Button bt_num_9;
        private System.Windows.Forms.Button bt_num_8;
        private System.Windows.Forms.Button bt_num_7;
        private System.Windows.Forms.Button bt_num_6;
        private System.Windows.Forms.Button bt_num_5;
        private System.Windows.Forms.Button bt_num_4;
        private System.Windows.Forms.Button bt_num_3;
        private System.Windows.Forms.Button bt_num_2;
        private System.Windows.Forms.Button bt_num_1;
        private System.Windows.Forms.Button bt_concluir;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_valor_to_pay;
        private System.Windows.Forms.ListBox lb_pagamentos;
        private System.Windows.Forms.Button bt_remove_payment;
        private System.Windows.Forms.NumericUpDown nb_value;
    }
}