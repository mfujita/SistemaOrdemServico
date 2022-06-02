namespace SistemaOrdemServico
{
    partial class Orcamento
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
            this.lblCadastroOrcamento = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbRecebidoOrcamento = new System.Windows.Forms.ComboBox();
            this.lblMoedaOrcamento = new System.Windows.Forms.Label();
            this.nudValorOrcamento = new System.Windows.Forms.NumericUpDown();
            this.cbPecasOrcamento = new System.Windows.Forms.ComboBox();
            this.txtDescricaoOrcamento = new System.Windows.Forms.TextBox();
            this.dtpDataEntradaOrcamento = new System.Windows.Forms.DateTimePicker();
            this.cbClienteOrcamento = new System.Windows.Forms.ComboBox();
            this.lblPecasOrcamento = new System.Windows.Forms.Label();
            this.lblRecebidoOrcamento = new System.Windows.Forms.Label();
            this.lblValorOrcamento = new System.Windows.Forms.Label();
            this.lblDescricaoOrcamento = new System.Windows.Forms.Label();
            this.lblDataEntradaOrcamento = new System.Windows.Forms.Label();
            this.lblClienteOrcamento = new System.Windows.Forms.Label();
            this.btnModoEditar = new System.Windows.Forms.Button();
            this.pbOrcamento = new System.Windows.Forms.PictureBox();
            this.btnModoInserir = new System.Windows.Forms.Button();
            this.btnModoExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastroOrcamento
            // 
            this.lblCadastroOrcamento.AutoSize = true;
            this.lblCadastroOrcamento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroOrcamento.Location = new System.Drawing.Point(155, 41);
            this.lblCadastroOrcamento.Name = "lblCadastroOrcamento";
            this.lblCadastroOrcamento.Size = new System.Drawing.Size(260, 24);
            this.lblCadastroOrcamento.TabIndex = 41;
            this.lblCadastroOrcamento.Text = "Cadastro de orçamentos";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(292, 500);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(128, 33);
            this.btnEnviar.TabIndex = 38;
            this.btnEnviar.Text = "Inserir";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnInserirOrcamento_Click);
            // 
            // cbRecebidoOrcamento
            // 
            this.cbRecebidoOrcamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRecebidoOrcamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRecebidoOrcamento.FormattingEnabled = true;
            this.cbRecebidoOrcamento.Location = new System.Drawing.Point(148, 449);
            this.cbRecebidoOrcamento.MaxLength = 60;
            this.cbRecebidoOrcamento.Name = "cbRecebidoOrcamento";
            this.cbRecebidoOrcamento.Size = new System.Drawing.Size(272, 29);
            this.cbRecebidoOrcamento.TabIndex = 37;
            // 
            // lblMoedaOrcamento
            // 
            this.lblMoedaOrcamento.AutoSize = true;
            this.lblMoedaOrcamento.Location = new System.Drawing.Point(147, 404);
            this.lblMoedaOrcamento.Name = "lblMoedaOrcamento";
            this.lblMoedaOrcamento.Size = new System.Drawing.Size(29, 21);
            this.lblMoedaOrcamento.TabIndex = 36;
            this.lblMoedaOrcamento.Text = "R$";
            // 
            // nudValorOrcamento
            // 
            this.nudValorOrcamento.DecimalPlaces = 2;
            this.nudValorOrcamento.Location = new System.Drawing.Point(182, 402);
            this.nudValorOrcamento.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.nudValorOrcamento.Name = "nudValorOrcamento";
            this.nudValorOrcamento.Size = new System.Drawing.Size(238, 29);
            this.nudValorOrcamento.TabIndex = 35;
            this.nudValorOrcamento.ThousandsSeparator = true;
            // 
            // cbPecasOrcamento
            // 
            this.cbPecasOrcamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPecasOrcamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPecasOrcamento.FormattingEnabled = true;
            this.cbPecasOrcamento.Location = new System.Drawing.Point(151, 355);
            this.cbPecasOrcamento.MaxLength = 60;
            this.cbPecasOrcamento.Name = "cbPecasOrcamento";
            this.cbPecasOrcamento.Size = new System.Drawing.Size(269, 29);
            this.cbPecasOrcamento.TabIndex = 34;
            // 
            // txtDescricaoOrcamento
            // 
            this.txtDescricaoOrcamento.AllowDrop = true;
            this.txtDescricaoOrcamento.Location = new System.Drawing.Point(151, 222);
            this.txtDescricaoOrcamento.Multiline = true;
            this.txtDescricaoOrcamento.Name = "txtDescricaoOrcamento";
            this.txtDescricaoOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricaoOrcamento.Size = new System.Drawing.Size(269, 115);
            this.txtDescricaoOrcamento.TabIndex = 33;
            // 
            // dtpDataEntradaOrcamento
            // 
            this.dtpDataEntradaOrcamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntradaOrcamento.Location = new System.Drawing.Point(151, 175);
            this.dtpDataEntradaOrcamento.Name = "dtpDataEntradaOrcamento";
            this.dtpDataEntradaOrcamento.Size = new System.Drawing.Size(269, 29);
            this.dtpDataEntradaOrcamento.TabIndex = 32;
            this.dtpDataEntradaOrcamento.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            // 
            // cbClienteOrcamento
            // 
            this.cbClienteOrcamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClienteOrcamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClienteOrcamento.FormattingEnabled = true;
            this.cbClienteOrcamento.Location = new System.Drawing.Point(151, 128);
            this.cbClienteOrcamento.MaxLength = 60;
            this.cbClienteOrcamento.Name = "cbClienteOrcamento";
            this.cbClienteOrcamento.Size = new System.Drawing.Size(269, 29);
            this.cbClienteOrcamento.TabIndex = 31;
            // 
            // lblPecasOrcamento
            // 
            this.lblPecasOrcamento.AutoSize = true;
            this.lblPecasOrcamento.Location = new System.Drawing.Point(47, 359);
            this.lblPecasOrcamento.Name = "lblPecasOrcamento";
            this.lblPecasOrcamento.Size = new System.Drawing.Size(51, 21);
            this.lblPecasOrcamento.TabIndex = 30;
            this.lblPecasOrcamento.Text = "Peças:";
            // 
            // lblRecebidoOrcamento
            // 
            this.lblRecebidoOrcamento.AutoSize = true;
            this.lblRecebidoOrcamento.Location = new System.Drawing.Point(21, 453);
            this.lblRecebidoOrcamento.Name = "lblRecebidoOrcamento";
            this.lblRecebidoOrcamento.Size = new System.Drawing.Size(105, 21);
            this.lblRecebidoOrcamento.TabIndex = 29;
            this.lblRecebidoOrcamento.Text = "Recebido por:";
            // 
            // lblValorOrcamento
            // 
            this.lblValorOrcamento.AutoSize = true;
            this.lblValorOrcamento.Location = new System.Drawing.Point(10, 406);
            this.lblValorOrcamento.Name = "lblValorOrcamento";
            this.lblValorOrcamento.Size = new System.Drawing.Size(124, 21);
            this.lblValorOrcamento.TabIndex = 28;
            this.lblValorOrcamento.Text = "Valor do serviço:";
            // 
            // lblDescricaoOrcamento
            // 
            this.lblDescricaoOrcamento.AutoSize = true;
            this.lblDescricaoOrcamento.Location = new System.Drawing.Point(38, 269);
            this.lblDescricaoOrcamento.Name = "lblDescricaoOrcamento";
            this.lblDescricaoOrcamento.Size = new System.Drawing.Size(80, 21);
            this.lblDescricaoOrcamento.TabIndex = 27;
            this.lblDescricaoOrcamento.Text = "Descrição:";
            // 
            // lblDataEntradaOrcamento
            // 
            this.lblDataEntradaOrcamento.AutoSize = true;
            this.lblDataEntradaOrcamento.Location = new System.Drawing.Point(12, 179);
            this.lblDataEntradaOrcamento.Name = "lblDataEntradaOrcamento";
            this.lblDataEntradaOrcamento.Size = new System.Drawing.Size(123, 21);
            this.lblDataEntradaOrcamento.TabIndex = 26;
            this.lblDataEntradaOrcamento.Text = "Data de entrada:";
            // 
            // lblClienteOrcamento
            // 
            this.lblClienteOrcamento.AutoSize = true;
            this.lblClienteOrcamento.Location = new System.Drawing.Point(38, 132);
            this.lblClienteOrcamento.Name = "lblClienteOrcamento";
            this.lblClienteOrcamento.Size = new System.Drawing.Size(61, 21);
            this.lblClienteOrcamento.TabIndex = 25;
            this.lblClienteOrcamento.Text = "Cliente:";
            // 
            // btnModoEditar
            // 
            this.btnModoEditar.Location = new System.Drawing.Point(282, 68);
            this.btnModoEditar.Name = "btnModoEditar";
            this.btnModoEditar.Size = new System.Drawing.Size(66, 54);
            this.btnModoEditar.TabIndex = 43;
            this.btnModoEditar.Text = "Editar";
            this.btnModoEditar.UseVisualStyleBackColor = true;
            this.btnModoEditar.Click += new System.EventHandler(this.MudarModo);
            // 
            // pbOrcamento
            // 
            this.pbOrcamento.Image = global::SistemaOrdemServico.Properties.Resources.Orcamento;
            this.pbOrcamento.Location = new System.Drawing.Point(26, 11);
            this.pbOrcamento.Name = "pbOrcamento";
            this.pbOrcamento.Size = new System.Drawing.Size(84, 84);
            this.pbOrcamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrcamento.TabIndex = 42;
            this.pbOrcamento.TabStop = false;
            // 
            // btnModoInserir
            // 
            this.btnModoInserir.Location = new System.Drawing.Point(210, 68);
            this.btnModoInserir.Name = "btnModoInserir";
            this.btnModoInserir.Size = new System.Drawing.Size(66, 54);
            this.btnModoInserir.TabIndex = 44;
            this.btnModoInserir.Text = "Inserir";
            this.btnModoInserir.UseVisualStyleBackColor = true;
            this.btnModoInserir.Click += new System.EventHandler(this.MudarModo);
            // 
            // btnModoExcluir
            // 
            this.btnModoExcluir.Location = new System.Drawing.Point(354, 68);
            this.btnModoExcluir.Name = "btnModoExcluir";
            this.btnModoExcluir.Size = new System.Drawing.Size(66, 54);
            this.btnModoExcluir.TabIndex = 45;
            this.btnModoExcluir.Text = "Excluir";
            this.btnModoExcluir.UseVisualStyleBackColor = true;
            this.btnModoExcluir.Click += new System.EventHandler(this.MudarModo);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(148, 500);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 33);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Orcamento
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 545);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnModoExcluir);
            this.Controls.Add(this.btnModoInserir);
            this.Controls.Add(this.btnModoEditar);
            this.Controls.Add(this.pbOrcamento);
            this.Controls.Add(this.lblCadastroOrcamento);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cbRecebidoOrcamento);
            this.Controls.Add(this.lblMoedaOrcamento);
            this.Controls.Add(this.nudValorOrcamento);
            this.Controls.Add(this.cbPecasOrcamento);
            this.Controls.Add(this.txtDescricaoOrcamento);
            this.Controls.Add(this.dtpDataEntradaOrcamento);
            this.Controls.Add(this.cbClienteOrcamento);
            this.Controls.Add(this.lblPecasOrcamento);
            this.Controls.Add(this.lblRecebidoOrcamento);
            this.Controls.Add(this.lblValorOrcamento);
            this.Controls.Add(this.lblDescricaoOrcamento);
            this.Controls.Add(this.lblDataEntradaOrcamento);
            this.Controls.Add(this.lblClienteOrcamento);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Orcamento";
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.Orcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValorOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOrcamento;
        private System.Windows.Forms.Label lblCadastroOrcamento;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbRecebidoOrcamento;
        private System.Windows.Forms.Label lblMoedaOrcamento;
        private System.Windows.Forms.NumericUpDown nudValorOrcamento;
        private System.Windows.Forms.ComboBox cbPecasOrcamento;
        private System.Windows.Forms.TextBox txtDescricaoOrcamento;
        private System.Windows.Forms.DateTimePicker dtpDataEntradaOrcamento;
        private System.Windows.Forms.ComboBox cbClienteOrcamento;
        private System.Windows.Forms.Label lblPecasOrcamento;
        private System.Windows.Forms.Label lblRecebidoOrcamento;
        private System.Windows.Forms.Label lblValorOrcamento;
        private System.Windows.Forms.Label lblDescricaoOrcamento;
        private System.Windows.Forms.Label lblDataEntradaOrcamento;
        private System.Windows.Forms.Label lblClienteOrcamento;
        private System.Windows.Forms.Button btnModoEditar;
        private System.Windows.Forms.Button btnModoInserir;
        private System.Windows.Forms.Button btnModoExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}