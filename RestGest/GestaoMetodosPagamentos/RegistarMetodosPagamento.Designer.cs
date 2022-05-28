namespace RestGest.GestaoMetodosPagamentos
{
    partial class RegistarMetodosPagamento
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.btnCleanMetodoPagamento = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddMetodoPagamento = new System.Windows.Forms.Button();
            this.tbMetodoPagamento = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAtivo);
            this.groupBox2.Controls.Add(this.btnCleanMetodoPagamento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAddMetodoPagamento);
            this.groupBox2.Controls.Add(this.tbMetodoPagamento);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(695, 103);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(402, 56);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(61, 21);
            this.cbAtivo.TabIndex = 9;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnCleanMetodoPagamento
            // 
            this.btnCleanMetodoPagamento.Location = new System.Drawing.Point(470, 51);
            this.btnCleanMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleanMetodoPagamento.Name = "btnCleanMetodoPagamento";
            this.btnCleanMetodoPagamento.Size = new System.Drawing.Size(100, 28);
            this.btnCleanMetodoPagamento.TabIndex = 8;
            this.btnCleanMetodoPagamento.Text = "Limpar";
            this.btnCleanMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnCleanMetodoPagamento.Click += new System.EventHandler(this.btnCleanMetodoPagamento_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Método de Pagamento";
            // 
            // btnAddMetodoPagamento
            // 
            this.btnAddMetodoPagamento.Location = new System.Drawing.Point(578, 51);
            this.btnAddMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMetodoPagamento.Name = "btnAddMetodoPagamento";
            this.btnAddMetodoPagamento.Size = new System.Drawing.Size(100, 28);
            this.btnAddMetodoPagamento.TabIndex = 7;
            this.btnAddMetodoPagamento.Text = "Registar";
            this.btnAddMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnAddMetodoPagamento.Click += new System.EventHandler(this.btnAddMetodoPagamento_Click);
            // 
            // tbMetodoPagamento
            // 
            this.tbMetodoPagamento.Location = new System.Drawing.Point(202, 21);
            this.tbMetodoPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.tbMetodoPagamento.Name = "tbMetodoPagamento";
            this.tbMetodoPagamento.Size = new System.Drawing.Size(477, 22);
            this.tbMetodoPagamento.TabIndex = 1;
            // 
            // RegistarMetodosPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 130);
            this.Controls.Add(this.groupBox2);
            this.Name = "RegistarMetodosPagamento";
            this.Text = "Registar Métodos de Pagamento";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Button btnCleanMetodoPagamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddMetodoPagamento;
        private System.Windows.Forms.TextBox tbMetodoPagamento;
    }
}