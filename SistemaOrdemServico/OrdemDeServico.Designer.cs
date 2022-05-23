namespace SistemaOrdemServico
{
    partial class OrdemDeServico
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
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_RespServico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Saida = new System.Windows.Forms.DateTimePicker();
            this.dtp_Garantia = new System.Windows.Forms.DateTimePicker();
            this.mtb_Id = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(428, 269);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(166, 36);
            this.btn_Limpar.TabIndex = 21;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click_1);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(256, 269);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(166, 36);
            this.btn_Salvar.TabIndex = 20;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Data de Garantia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Respon. Serviço";
            // 
            // tb_RespServico
            // 
            this.tb_RespServico.Location = new System.Drawing.Point(363, 182);
            this.tb_RespServico.Name = "tb_RespServico";
            this.tb_RespServico.Size = new System.Drawing.Size(188, 20);
            this.tb_RespServico.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data de Saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID Orçamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ordem de Serviço";
            // 
            // dtp_Saida
            // 
            this.dtp_Saida.CustomFormat = "";
            this.dtp_Saida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Saida.Location = new System.Drawing.Point(363, 136);
            this.dtp_Saida.Name = "dtp_Saida";
            this.dtp_Saida.Size = new System.Drawing.Size(200, 20);
            this.dtp_Saida.TabIndex = 22;
            // 
            // dtp_Garantia
            // 
            this.dtp_Garantia.CustomFormat = "";
            this.dtp_Garantia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Garantia.Location = new System.Drawing.Point(363, 223);
            this.dtp_Garantia.Name = "dtp_Garantia";
            this.dtp_Garantia.Size = new System.Drawing.Size(200, 20);
            this.dtp_Garantia.TabIndex = 23;
            // 
            // mtb_Id
            // 
            this.mtb_Id.Location = new System.Drawing.Point(363, 92);
            this.mtb_Id.Mask = "00000";
            this.mtb_Id.Name = "mtb_Id";
            this.mtb_Id.PasswordChar = '*';
            this.mtb_Id.Size = new System.Drawing.Size(59, 20);
            this.mtb_Id.TabIndex = 24;
            this.mtb_Id.ValidatingType = typeof(int);
            // 
            // OrdemDeServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtb_Id);
            this.Controls.Add(this.dtp_Garantia);
            this.Controls.Add(this.dtp_Saida);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_RespServico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdemDeServico";
            this.Text = "Ordem_de_servico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_RespServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Saida;
        private System.Windows.Forms.DateTimePicker dtp_Garantia;
        private System.Windows.Forms.MaskedTextBox mtb_Id;
    }
}