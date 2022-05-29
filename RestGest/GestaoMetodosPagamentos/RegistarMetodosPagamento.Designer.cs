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
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(302, 46);
            this.cbAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbAtivo.TabIndex = 9;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnCleanMetodoPagamento
            // 
            this.btnCleanMetodoPagamento.Location = new System.Drawing.Point(352, 41);
            this.btnCleanMetodoPagamento.Name = "btnCleanMetodoPagamento";
            this.btnCleanMetodoPagamento.Size = new System.Drawing.Size(75, 23);
            this.btnCleanMetodoPagamento.TabIndex = 8;
            this.btnCleanMetodoPagamento.Text = "Limpar";
            this.btnCleanMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnCleanMetodoPagamento.Click += new System.EventHandler(this.btnCleanMetodoPagamento_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Método de Pagamento";
            // 
            // btnAddMetodoPagamento
            // 
            this.btnAddMetodoPagamento.Location = new System.Drawing.Point(434, 41);
            this.btnAddMetodoPagamento.Name = "btnAddMetodoPagamento";
            this.btnAddMetodoPagamento.Size = new System.Drawing.Size(75, 23);
            this.btnAddMetodoPagamento.TabIndex = 7;
            this.btnAddMetodoPagamento.Text = "Registar";
            this.btnAddMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnAddMetodoPagamento.Click += new System.EventHandler(this.btnAddMetodoPagamento_Click);
            // 
            // tbMetodoPagamento
            // 
            this.tbMetodoPagamento.Location = new System.Drawing.Point(152, 17);
            this.tbMetodoPagamento.Name = "tbMetodoPagamento";
            this.tbMetodoPagamento.Size = new System.Drawing.Size(359, 20);
            this.tbMetodoPagamento.TabIndex = 1;
            // 
            // RegistarMetodosPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 106);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(558, 145);
            this.MinimumSize = new System.Drawing.Size(558, 145);
            this.Name = "RegistarMetodosPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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