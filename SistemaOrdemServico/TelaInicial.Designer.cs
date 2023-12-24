namespace SistemaOrdemServico
{
    partial class TelaInicial
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
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnOrdemDeServico = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(410, 65);
            this.btnFuncionarios.TabIndex = 5;
            this.btnFuncionarios.Text = "Cadastro de Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnPecas
            // 
            this.btnPecas.Location = new System.Drawing.Point(12, 83);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(410, 65);
            this.btnPecas.TabIndex = 6;
            this.btnPecas.Text = "Cadastro de Peças";
            this.btnPecas.UseVisualStyleBackColor = true;
            this.btnPecas.Click += new System.EventHandler(this.btnPecas_Click);
            // 
            // btnOrcamentos
            // 
            this.btnOrcamentos.Location = new System.Drawing.Point(12, 154);
            this.btnOrcamentos.Name = "btnOrcamentos";
            this.btnOrcamentos.Size = new System.Drawing.Size(410, 65);
            this.btnOrcamentos.TabIndex = 7;
            this.btnOrcamentos.Text = "Cadastro de Orçamentos";
            this.btnOrcamentos.UseVisualStyleBackColor = true;
            this.btnOrcamentos.Click += new System.EventHandler(this.btnOrcamentos_Click);
            // 
            // btnOrdemDeServico
            // 
            this.btnOrdemDeServico.Location = new System.Drawing.Point(12, 225);
            this.btnOrdemDeServico.Name = "btnOrdemDeServico";
            this.btnOrdemDeServico.Size = new System.Drawing.Size(410, 65);
            this.btnOrdemDeServico.TabIndex = 8;
            this.btnOrdemDeServico.Text = "Cadastro de Ordem de Serviço";
            this.btnOrdemDeServico.UseVisualStyleBackColor = true;
            this.btnOrdemDeServico.Click += new System.EventHandler(this.btnOrdemDeServico_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 296);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(410, 65);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "Cadastro de Clientes/Empresas";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 373);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.btnOrdemDeServico);
            this.Controls.Add(this.btnClientes);
            this.Name = "TelaInicial";
            this.Text = "Sistema de Ordem de Serviço";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnOrdemDeServico;
        private System.Windows.Forms.Button btnClientes;
    }
}