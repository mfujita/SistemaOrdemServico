namespace SistemaOrdemServico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcOrdemServico = new System.Windows.Forms.TabControl();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.tpPecas = new System.Windows.Forms.TabPage();
            this.tpOrcamento = new System.Windows.Forms.TabPage();
            this.tpOrdemServico = new System.Windows.Forms.TabPage();
            this.tpClienteEmpresa = new System.Windows.Forms.TabPage();
            this.tcOrdemServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcOrdemServico
            // 
            this.tcOrdemServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcOrdemServico.Controls.Add(this.tpFuncionarios);
            this.tcOrdemServico.Controls.Add(this.tpPecas);
            this.tcOrdemServico.Controls.Add(this.tpOrcamento);
            this.tcOrdemServico.Controls.Add(this.tpOrdemServico);
            this.tcOrdemServico.Controls.Add(this.tpClienteEmpresa);
            this.tcOrdemServico.Location = new System.Drawing.Point(12, 12);
            this.tcOrdemServico.Name = "tcOrdemServico";
            this.tcOrdemServico.SelectedIndex = 0;
            this.tcOrdemServico.Size = new System.Drawing.Size(1068, 391);
            this.tcOrdemServico.TabIndex = 0;
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 30);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarios.Size = new System.Drawing.Size(1060, 357);
            this.tpFuncionarios.TabIndex = 0;
            this.tpFuncionarios.Text = "Cadastro funcionários";
            this.tpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tpPecas
            // 
            this.tpPecas.Location = new System.Drawing.Point(4, 30);
            this.tpPecas.Name = "tpPecas";
            this.tpPecas.Padding = new System.Windows.Forms.Padding(3);
            this.tpPecas.Size = new System.Drawing.Size(961, 357);
            this.tpPecas.TabIndex = 1;
            this.tpPecas.Text = "Cadastro de peças";
            this.tpPecas.UseVisualStyleBackColor = true;
            // 
            // tpOrcamento
            // 
            this.tpOrcamento.Location = new System.Drawing.Point(4, 30);
            this.tpOrcamento.Name = "tpOrcamento";
            this.tpOrcamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrcamento.Size = new System.Drawing.Size(961, 357);
            this.tpOrcamento.TabIndex = 2;
            this.tpOrcamento.Text = "Cadastro de orçamentos";
            this.tpOrcamento.UseVisualStyleBackColor = true;
            // 
            // tpOrdemServico
            // 
            this.tpOrdemServico.Location = new System.Drawing.Point(4, 30);
            this.tpOrdemServico.Name = "tpOrdemServico";
            this.tpOrdemServico.Size = new System.Drawing.Size(961, 357);
            this.tpOrdemServico.TabIndex = 3;
            this.tpOrdemServico.Text = "Cadastro de ordem de serviço";
            this.tpOrdemServico.UseVisualStyleBackColor = true;
            // 
            // tpClienteEmpresa
            // 
            this.tpClienteEmpresa.Location = new System.Drawing.Point(4, 30);
            this.tpClienteEmpresa.Name = "tpClienteEmpresa";
            this.tpClienteEmpresa.Size = new System.Drawing.Size(961, 357);
            this.tpClienteEmpresa.TabIndex = 4;
            this.tpClienteEmpresa.Text = "Cadastros de clientes/empresas";
            this.tpClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 538);
            this.Controls.Add(this.tcOrdemServico);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sistema de Ordem de Serviço v 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tcOrdemServico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcOrdemServico;
        private TabPage tpFuncionarios;
        private TabPage tpPecas;
        private TabPage tpOrcamento;
        private TabPage tpOrdemServico;
        private TabPage tpClienteEmpresa;
    }
}