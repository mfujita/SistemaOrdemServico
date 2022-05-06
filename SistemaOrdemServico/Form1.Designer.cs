namespace SistemaOrdemServico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
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
            this.tcOrdemServico.Controls.Add(this.tpFuncionarios);
            this.tcOrdemServico.Controls.Add(this.tpPecas);
            this.tcOrdemServico.Controls.Add(this.tpOrcamento);
            this.tcOrdemServico.Controls.Add(this.tpOrdemServico);
            this.tcOrdemServico.Controls.Add(this.tpClienteEmpresa);
            this.tcOrdemServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOrdemServico.Location = new System.Drawing.Point(0, 0);
            this.tcOrdemServico.Name = "tcOrdemServico";
            this.tcOrdemServico.SelectedIndex = 0;
            this.tcOrdemServico.Size = new System.Drawing.Size(1255, 538);
            this.tcOrdemServico.TabIndex = 0;
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 30);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarios.Size = new System.Drawing.Size(1247, 504);
            this.tpFuncionarios.TabIndex = 0;
            this.tpFuncionarios.Text = "Cadastro funcionários";
            this.tpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tpPecas
            // 
            this.tpPecas.Location = new System.Drawing.Point(4, 30);
            this.tpPecas.Name = "tpPecas";
            this.tpPecas.Padding = new System.Windows.Forms.Padding(3);
            this.tpPecas.Size = new System.Drawing.Size(1060, 357);
            this.tpPecas.TabIndex = 1;
            this.tpPecas.Text = "Cadastro de peças";
            this.tpPecas.UseVisualStyleBackColor = true;
            // 
            // tpOrcamento
            // 
            this.tpOrcamento.Location = new System.Drawing.Point(4, 30);
            this.tpOrcamento.Name = "tpOrcamento";
            this.tpOrcamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrcamento.Size = new System.Drawing.Size(1060, 357);
            this.tpOrcamento.TabIndex = 2;
            this.tpOrcamento.Text = "Cadastro de orçamentos";
            this.tpOrcamento.UseVisualStyleBackColor = true;
            // 
            // tpOrdemServico
            // 
            this.tpOrdemServico.Location = new System.Drawing.Point(4, 30);
            this.tpOrdemServico.Name = "tpOrdemServico";
            this.tpOrdemServico.Size = new System.Drawing.Size(1060, 357);
            this.tpOrdemServico.TabIndex = 3;
            this.tpOrdemServico.Text = "Cadastro de ordem de serviço";
            this.tpOrdemServico.UseVisualStyleBackColor = true;
            // 
            // tpClienteEmpresa
            // 
            this.tpClienteEmpresa.Location = new System.Drawing.Point(4, 30);
            this.tpClienteEmpresa.Name = "tpClienteEmpresa";
            this.tpClienteEmpresa.Size = new System.Drawing.Size(1060, 357);
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
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sistema de Ordem de Serviço v 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tcOrdemServico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcOrdemServico;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private System.Windows.Forms.TabPage tpPecas;
        private System.Windows.Forms.TabPage tpOrcamento;
        private System.Windows.Forms.TabPage tpOrdemServico;
        private System.Windows.Forms.TabPage tpClienteEmpresa;
    }
}

