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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcOrdemServico = new System.Windows.Forms.TabControl();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.tpPecas = new System.Windows.Forms.TabPage();
            this.btnExcluirPeca = new System.Windows.Forms.Button();
            this.btnEditarPeca = new System.Windows.Forms.Button();
            this.btnSalvarPeca = new System.Windows.Forms.Button();
            this.txtValorVendaPeca = new System.Windows.Forms.TextBox();
            this.txtValorCompraPeca = new System.Windows.Forms.TextBox();
            this.txtFabricantePeca = new System.Windows.Forms.TextBox();
            this.txtFornecedorPeca = new System.Windows.Forms.TextBox();
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.lblValorVendaPeca = new System.Windows.Forms.Label();
            this.lblValorCompraPeca = new System.Windows.Forms.Label();
            this.lblFabricantePeca = new System.Windows.Forms.Label();
            this.lblFornecedorPeca = new System.Windows.Forms.Label();
            this.lblNomePeca = new System.Windows.Forms.Label();
            this.lblCadastroPeca = new System.Windows.Forms.Label();
            this.pbPeca = new System.Windows.Forms.PictureBox();
            this.tpOrcamento = new System.Windows.Forms.TabPage();
            this.lblCadastroOrcamento = new System.Windows.Forms.Label();
            this.btnExcluirOrcamento = new System.Windows.Forms.Button();
            this.btnEditarOrcamento = new System.Windows.Forms.Button();
            this.btnSalvarOrcamento = new System.Windows.Forms.Button();
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
            this.tpOrdemServico = new System.Windows.Forms.TabPage();
            this.tpClienteEmpresa = new System.Windows.Forms.TabPage();
            this.txtCidadePessoa = new System.Windows.Forms.TextBox();
            this.lblCidadePessoa = new System.Windows.Forms.Label();
            this.txtEstadoPessoa = new System.Windows.Forms.TextBox();
            this.lblEstadoPessoa = new System.Windows.Forms.Label();
            this.cbCategoriaPessoa = new System.Windows.Forms.ComboBox();
            this.cbStatusPessoa = new System.Windows.Forms.ComboBox();
            this.txtEmailPessoa = new System.Windows.Forms.TextBox();
            this.txtCelularPessoa = new System.Windows.Forms.TextBox();
            this.txtContatoPessoa = new System.Windows.Forms.TextBox();
            this.txtNumeroPessoa = new System.Windows.Forms.TextBox();
            this.txtBairroPessoa = new System.Windows.Forms.TextBox();
            this.txtEnderecoPessoa = new System.Windows.Forms.TextBox();
            this.txtCepPessoa = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.lblCategoriaPessoa = new System.Windows.Forms.Label();
            this.lblCadastroContatoPessoa = new System.Windows.Forms.Label();
            this.lblNumeroPessoa = new System.Windows.Forms.Label();
            this.lblCadastroEnderecoPessoa = new System.Windows.Forms.Label();
            this.lblStatusPessoa = new System.Windows.Forms.Label();
            this.lblEmailPessoa = new System.Windows.Forms.Label();
            this.lblCelularPessoa = new System.Windows.Forms.Label();
            this.lblTelefonePessoa = new System.Windows.Forms.Label();
            this.lblBairroPessoa = new System.Windows.Forms.Label();
            this.lblEnderecoPessoa = new System.Windows.Forms.Label();
            this.lblCepPessoa = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblNomePessoa = new System.Windows.Forms.Label();
            this.lblCadastroPessoa = new System.Windows.Forms.Label();
            this.pbPessoa = new System.Windows.Forms.PictureBox();
            this.btnExcluirPessoa = new System.Windows.Forms.Button();
            this.btnEditarPessoa = new System.Windows.Forms.Button();
            this.btnSalvarPessoa = new System.Windows.Forms.Button();
            this.tcOrdemServico.SuspendLayout();
            this.tpPecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeca)).BeginInit();
            this.tpOrcamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorOrcamento)).BeginInit();
            this.tpClienteEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPessoa)).BeginInit();
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
            this.tcOrdemServico.Size = new System.Drawing.Size(1255, 733);
            this.tcOrdemServico.TabIndex = 0;
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 30);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarios.Size = new System.Drawing.Size(1247, 699);
            this.tpFuncionarios.TabIndex = 0;
            this.tpFuncionarios.Text = "Cadastro funcionários";
            this.tpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tpPecas
            // 
            this.tpPecas.Controls.Add(this.btnExcluirPeca);
            this.tpPecas.Controls.Add(this.btnEditarPeca);
            this.tpPecas.Controls.Add(this.btnSalvarPeca);
            this.tpPecas.Controls.Add(this.txtValorVendaPeca);
            this.tpPecas.Controls.Add(this.txtValorCompraPeca);
            this.tpPecas.Controls.Add(this.txtFabricantePeca);
            this.tpPecas.Controls.Add(this.txtFornecedorPeca);
            this.tpPecas.Controls.Add(this.txtNomePeca);
            this.tpPecas.Controls.Add(this.lblValorVendaPeca);
            this.tpPecas.Controls.Add(this.lblValorCompraPeca);
            this.tpPecas.Controls.Add(this.lblFabricantePeca);
            this.tpPecas.Controls.Add(this.lblFornecedorPeca);
            this.tpPecas.Controls.Add(this.lblNomePeca);
            this.tpPecas.Controls.Add(this.lblCadastroPeca);
            this.tpPecas.Controls.Add(this.pbPeca);
            this.tpPecas.Location = new System.Drawing.Point(4, 30);
            this.tpPecas.Name = "tpPecas";
            this.tpPecas.Padding = new System.Windows.Forms.Padding(3);
            this.tpPecas.Size = new System.Drawing.Size(1247, 699);
            this.tpPecas.TabIndex = 1;
            this.tpPecas.Text = "Cadastro de peças";
            this.tpPecas.UseVisualStyleBackColor = true;
            // 
            // btnExcluirPeca
            // 
            this.btnExcluirPeca.Location = new System.Drawing.Point(319, 490);
            this.btnExcluirPeca.Name = "btnExcluirPeca";
            this.btnExcluirPeca.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirPeca.TabIndex = 46;
            this.btnExcluirPeca.Text = "Excluir";
            this.btnExcluirPeca.UseVisualStyleBackColor = true;
            // 
            // btnEditarPeca
            // 
            this.btnEditarPeca.Location = new System.Drawing.Point(238, 490);
            this.btnEditarPeca.Name = "btnEditarPeca";
            this.btnEditarPeca.Size = new System.Drawing.Size(75, 33);
            this.btnEditarPeca.TabIndex = 45;
            this.btnEditarPeca.Text = "Editar";
            this.btnEditarPeca.UseVisualStyleBackColor = true;
            // 
            // btnSalvarPeca
            // 
            this.btnSalvarPeca.Location = new System.Drawing.Point(158, 490);
            this.btnSalvarPeca.Name = "btnSalvarPeca";
            this.btnSalvarPeca.Size = new System.Drawing.Size(75, 33);
            this.btnSalvarPeca.TabIndex = 44;
            this.btnSalvarPeca.Text = "Salvar";
            this.btnSalvarPeca.UseVisualStyleBackColor = true;
            this.btnSalvarPeca.Click += new System.EventHandler(this.btnSalvarPeca_Click);
            // 
            // txtValorVendaPeca
            // 
            this.txtValorVendaPeca.Location = new System.Drawing.Point(292, 388);
            this.txtValorVendaPeca.Name = "txtValorVendaPeca";
            this.txtValorVendaPeca.Size = new System.Drawing.Size(234, 29);
            this.txtValorVendaPeca.TabIndex = 43;
            // 
            // txtValorCompraPeca
            // 
            this.txtValorCompraPeca.Location = new System.Drawing.Point(292, 341);
            this.txtValorCompraPeca.Name = "txtValorCompraPeca";
            this.txtValorCompraPeca.Size = new System.Drawing.Size(234, 29);
            this.txtValorCompraPeca.TabIndex = 42;
            // 
            // txtFabricantePeca
            // 
            this.txtFabricantePeca.Location = new System.Drawing.Point(292, 295);
            this.txtFabricantePeca.Name = "txtFabricantePeca";
            this.txtFabricantePeca.Size = new System.Drawing.Size(234, 29);
            this.txtFabricantePeca.TabIndex = 41;
            // 
            // txtFornecedorPeca
            // 
            this.txtFornecedorPeca.Location = new System.Drawing.Point(292, 250);
            this.txtFornecedorPeca.Name = "txtFornecedorPeca";
            this.txtFornecedorPeca.Size = new System.Drawing.Size(234, 29);
            this.txtFornecedorPeca.TabIndex = 40;
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.Location = new System.Drawing.Point(292, 208);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.Size = new System.Drawing.Size(234, 29);
            this.txtNomePeca.TabIndex = 39;
            // 
            // lblValorVendaPeca
            // 
            this.lblValorVendaPeca.AutoSize = true;
            this.lblValorVendaPeca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVendaPeca.Location = new System.Drawing.Point(160, 399);
            this.lblValorVendaPeca.Name = "lblValorVendaPeca";
            this.lblValorVendaPeca.Size = new System.Drawing.Size(97, 18);
            this.lblValorVendaPeca.TabIndex = 29;
            this.lblValorVendaPeca.Text = "Valor Venda:";
            // 
            // lblValorCompraPeca
            // 
            this.lblValorCompraPeca.AutoSize = true;
            this.lblValorCompraPeca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompraPeca.Location = new System.Drawing.Point(160, 352);
            this.lblValorCompraPeca.Name = "lblValorCompraPeca";
            this.lblValorCompraPeca.Size = new System.Drawing.Size(109, 18);
            this.lblValorCompraPeca.TabIndex = 28;
            this.lblValorCompraPeca.Text = "Valor Compra:";
            // 
            // lblFabricantePeca
            // 
            this.lblFabricantePeca.AutoSize = true;
            this.lblFabricantePeca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricantePeca.Location = new System.Drawing.Point(160, 306);
            this.lblFabricantePeca.Name = "lblFabricantePeca";
            this.lblFabricantePeca.Size = new System.Drawing.Size(87, 18);
            this.lblFabricantePeca.TabIndex = 27;
            this.lblFabricantePeca.Text = "Fabricante:";
            // 
            // lblFornecedorPeca
            // 
            this.lblFornecedorPeca.AutoSize = true;
            this.lblFornecedorPeca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedorPeca.Location = new System.Drawing.Point(160, 261);
            this.lblFornecedorPeca.Name = "lblFornecedorPeca";
            this.lblFornecedorPeca.Size = new System.Drawing.Size(93, 18);
            this.lblFornecedorPeca.TabIndex = 26;
            this.lblFornecedorPeca.Text = "Fornecedor:";
            // 
            // lblNomePeca
            // 
            this.lblNomePeca.AutoSize = true;
            this.lblNomePeca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePeca.Location = new System.Drawing.Point(160, 219);
            this.lblNomePeca.Name = "lblNomePeca";
            this.lblNomePeca.Size = new System.Drawing.Size(54, 18);
            this.lblNomePeca.TabIndex = 25;
            this.lblNomePeca.Text = "Nome:";
            // 
            // lblCadastroPeca
            // 
            this.lblCadastroPeca.AutoSize = true;
            this.lblCadastroPeca.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroPeca.Location = new System.Drawing.Point(288, 83);
            this.lblCadastroPeca.Name = "lblCadastroPeca";
            this.lblCadastroPeca.Size = new System.Drawing.Size(200, 24);
            this.lblCadastroPeca.TabIndex = 22;
            this.lblCadastroPeca.Text = "Cadastro de peças";
            // 
            // pbPeca
            // 
            this.pbPeca.Image = ((System.Drawing.Image)(resources.GetObject("pbPeca.Image")));
            this.pbPeca.Location = new System.Drawing.Point(163, 41);
            this.pbPeca.Name = "pbPeca";
            this.pbPeca.Size = new System.Drawing.Size(84, 84);
            this.pbPeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeca.TabIndex = 21;
            this.pbPeca.TabStop = false;
            // 
            // tpOrcamento
            // 
            this.tpOrcamento.Controls.Add(this.lblCadastroOrcamento);
            this.tpOrcamento.Controls.Add(this.btnExcluirOrcamento);
            this.tpOrcamento.Controls.Add(this.btnEditarOrcamento);
            this.tpOrcamento.Controls.Add(this.btnSalvarOrcamento);
            this.tpOrcamento.Controls.Add(this.cbRecebidoOrcamento);
            this.tpOrcamento.Controls.Add(this.lblMoedaOrcamento);
            this.tpOrcamento.Controls.Add(this.nudValorOrcamento);
            this.tpOrcamento.Controls.Add(this.cbPecasOrcamento);
            this.tpOrcamento.Controls.Add(this.txtDescricaoOrcamento);
            this.tpOrcamento.Controls.Add(this.dtpDataEntradaOrcamento);
            this.tpOrcamento.Controls.Add(this.cbClienteOrcamento);
            this.tpOrcamento.Controls.Add(this.lblPecasOrcamento);
            this.tpOrcamento.Controls.Add(this.lblRecebidoOrcamento);
            this.tpOrcamento.Controls.Add(this.lblValorOrcamento);
            this.tpOrcamento.Controls.Add(this.lblDescricaoOrcamento);
            this.tpOrcamento.Controls.Add(this.lblDataEntradaOrcamento);
            this.tpOrcamento.Controls.Add(this.lblClienteOrcamento);
            this.tpOrcamento.Location = new System.Drawing.Point(4, 30);
            this.tpOrcamento.Name = "tpOrcamento";
            this.tpOrcamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrcamento.Size = new System.Drawing.Size(1247, 699);
            this.tpOrcamento.TabIndex = 2;
            this.tpOrcamento.Text = "Cadastro de orçamentos";
            this.tpOrcamento.UseVisualStyleBackColor = true;
            // 
            // lblCadastroOrcamento
            // 
            this.lblCadastroOrcamento.AutoSize = true;
            this.lblCadastroOrcamento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroOrcamento.Location = new System.Drawing.Point(148, 12);
            this.lblCadastroOrcamento.Name = "lblCadastroOrcamento";
            this.lblCadastroOrcamento.Size = new System.Drawing.Size(263, 24);
            this.lblCadastroOrcamento.TabIndex = 23;
            this.lblCadastroOrcamento.Text = "Cadastro de Orçamentos";
            // 
            // btnExcluirOrcamento
            // 
            this.btnExcluirOrcamento.Location = new System.Drawing.Point(322, 422);
            this.btnExcluirOrcamento.Name = "btnExcluirOrcamento";
            this.btnExcluirOrcamento.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirOrcamento.TabIndex = 22;
            this.btnExcluirOrcamento.Text = "Excluir";
            this.btnExcluirOrcamento.UseVisualStyleBackColor = true;
            // 
            // btnEditarOrcamento
            // 
            this.btnEditarOrcamento.Location = new System.Drawing.Point(241, 422);
            this.btnEditarOrcamento.Name = "btnEditarOrcamento";
            this.btnEditarOrcamento.Size = new System.Drawing.Size(75, 33);
            this.btnEditarOrcamento.TabIndex = 21;
            this.btnEditarOrcamento.Text = "Editar";
            this.btnEditarOrcamento.UseVisualStyleBackColor = true;
            // 
            // btnSalvarOrcamento
            // 
            this.btnSalvarOrcamento.Location = new System.Drawing.Point(160, 422);
            this.btnSalvarOrcamento.Name = "btnSalvarOrcamento";
            this.btnSalvarOrcamento.Size = new System.Drawing.Size(75, 33);
            this.btnSalvarOrcamento.TabIndex = 20;
            this.btnSalvarOrcamento.Text = "Salvar";
            this.btnSalvarOrcamento.UseVisualStyleBackColor = true;
            // 
            // cbRecebidoOrcamento
            // 
            this.cbRecebidoOrcamento.FormattingEnabled = true;
            this.cbRecebidoOrcamento.Location = new System.Drawing.Point(142, 373);
            this.cbRecebidoOrcamento.MaxLength = 60;
            this.cbRecebidoOrcamento.Name = "cbRecebidoOrcamento";
            this.cbRecebidoOrcamento.Size = new System.Drawing.Size(272, 29);
            this.cbRecebidoOrcamento.TabIndex = 13;
            // 
            // lblMoedaOrcamento
            // 
            this.lblMoedaOrcamento.AutoSize = true;
            this.lblMoedaOrcamento.Location = new System.Drawing.Point(141, 330);
            this.lblMoedaOrcamento.Name = "lblMoedaOrcamento";
            this.lblMoedaOrcamento.Size = new System.Drawing.Size(29, 21);
            this.lblMoedaOrcamento.TabIndex = 12;
            this.lblMoedaOrcamento.Text = "R$";
            // 
            // nudValorOrcamento
            // 
            this.nudValorOrcamento.DecimalPlaces = 2;
            this.nudValorOrcamento.Location = new System.Drawing.Point(176, 326);
            this.nudValorOrcamento.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudValorOrcamento.Name = "nudValorOrcamento";
            this.nudValorOrcamento.Size = new System.Drawing.Size(238, 29);
            this.nudValorOrcamento.TabIndex = 11;
            this.nudValorOrcamento.ThousandsSeparator = true;
            // 
            // cbPecasOrcamento
            // 
            this.cbPecasOrcamento.FormattingEnabled = true;
            this.cbPecasOrcamento.Location = new System.Drawing.Point(145, 279);
            this.cbPecasOrcamento.MaxLength = 60;
            this.cbPecasOrcamento.Name = "cbPecasOrcamento";
            this.cbPecasOrcamento.Size = new System.Drawing.Size(269, 29);
            this.cbPecasOrcamento.TabIndex = 10;
            // 
            // txtDescricaoOrcamento
            // 
            this.txtDescricaoOrcamento.Location = new System.Drawing.Point(145, 146);
            this.txtDescricaoOrcamento.Multiline = true;
            this.txtDescricaoOrcamento.Name = "txtDescricaoOrcamento";
            this.txtDescricaoOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricaoOrcamento.Size = new System.Drawing.Size(269, 115);
            this.txtDescricaoOrcamento.TabIndex = 9;
            // 
            // dtpDataEntradaOrcamento
            // 
            this.dtpDataEntradaOrcamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntradaOrcamento.Location = new System.Drawing.Point(145, 99);
            this.dtpDataEntradaOrcamento.Name = "dtpDataEntradaOrcamento";
            this.dtpDataEntradaOrcamento.Size = new System.Drawing.Size(269, 29);
            this.dtpDataEntradaOrcamento.TabIndex = 8;
            this.dtpDataEntradaOrcamento.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            // 
            // cbClienteOrcamento
            // 
            this.cbClienteOrcamento.FormattingEnabled = true;
            this.cbClienteOrcamento.Location = new System.Drawing.Point(145, 52);
            this.cbClienteOrcamento.MaxLength = 60;
            this.cbClienteOrcamento.Name = "cbClienteOrcamento";
            this.cbClienteOrcamento.Size = new System.Drawing.Size(269, 29);
            this.cbClienteOrcamento.TabIndex = 7;
            // 
            // lblPecasOrcamento
            // 
            this.lblPecasOrcamento.AutoSize = true;
            this.lblPecasOrcamento.Location = new System.Drawing.Point(41, 283);
            this.lblPecasOrcamento.Name = "lblPecasOrcamento";
            this.lblPecasOrcamento.Size = new System.Drawing.Size(51, 21);
            this.lblPecasOrcamento.TabIndex = 6;
            this.lblPecasOrcamento.Text = "Peças:";
            // 
            // lblRecebidoOrcamento
            // 
            this.lblRecebidoOrcamento.AutoSize = true;
            this.lblRecebidoOrcamento.Location = new System.Drawing.Point(15, 377);
            this.lblRecebidoOrcamento.Name = "lblRecebidoOrcamento";
            this.lblRecebidoOrcamento.Size = new System.Drawing.Size(105, 21);
            this.lblRecebidoOrcamento.TabIndex = 5;
            this.lblRecebidoOrcamento.Text = "Recebido por:";
            // 
            // lblValorOrcamento
            // 
            this.lblValorOrcamento.AutoSize = true;
            this.lblValorOrcamento.Location = new System.Drawing.Point(4, 330);
            this.lblValorOrcamento.Name = "lblValorOrcamento";
            this.lblValorOrcamento.Size = new System.Drawing.Size(126, 21);
            this.lblValorOrcamento.TabIndex = 4;
            this.lblValorOrcamento.Text = "Valor do Serviço:";
            // 
            // lblDescricaoOrcamento
            // 
            this.lblDescricaoOrcamento.AutoSize = true;
            this.lblDescricaoOrcamento.Location = new System.Drawing.Point(32, 193);
            this.lblDescricaoOrcamento.Name = "lblDescricaoOrcamento";
            this.lblDescricaoOrcamento.Size = new System.Drawing.Size(80, 21);
            this.lblDescricaoOrcamento.TabIndex = 3;
            this.lblDescricaoOrcamento.Text = "Descrição:";
            // 
            // lblDataEntradaOrcamento
            // 
            this.lblDataEntradaOrcamento.AutoSize = true;
            this.lblDataEntradaOrcamento.Location = new System.Drawing.Point(6, 103);
            this.lblDataEntradaOrcamento.Name = "lblDataEntradaOrcamento";
            this.lblDataEntradaOrcamento.Size = new System.Drawing.Size(123, 21);
            this.lblDataEntradaOrcamento.TabIndex = 2;
            this.lblDataEntradaOrcamento.Text = "Data de Entrada:";
            // 
            // lblClienteOrcamento
            // 
            this.lblClienteOrcamento.AutoSize = true;
            this.lblClienteOrcamento.Location = new System.Drawing.Point(32, 56);
            this.lblClienteOrcamento.Name = "lblClienteOrcamento";
            this.lblClienteOrcamento.Size = new System.Drawing.Size(61, 21);
            this.lblClienteOrcamento.TabIndex = 1;
            this.lblClienteOrcamento.Text = "Cliente:";
            // 
            // tpOrdemServico
            // 
            this.tpOrdemServico.Location = new System.Drawing.Point(4, 30);
            this.tpOrdemServico.Name = "tpOrdemServico";
            this.tpOrdemServico.Size = new System.Drawing.Size(1247, 699);
            this.tpOrdemServico.TabIndex = 3;
            this.tpOrdemServico.Text = "Cadastro de ordem de serviço";
            this.tpOrdemServico.UseVisualStyleBackColor = true;
            // 
            // tpClienteEmpresa
            // 
            this.tpClienteEmpresa.Controls.Add(this.txtCidadePessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblCidadePessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtEstadoPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblEstadoPessoa);
            this.tpClienteEmpresa.Controls.Add(this.cbCategoriaPessoa);
            this.tpClienteEmpresa.Controls.Add(this.cbStatusPessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtEmailPessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtCelularPessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtContatoPessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtNumeroPessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtBairroPessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtEnderecoPessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtCepPessoa);
            this.tpClienteEmpresa.Controls.Add(this.txtCpfCnpj);
            this.tpClienteEmpresa.Controls.Add(this.txtNomePessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblCategoriaPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblCadastroContatoPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblNumeroPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblCadastroEnderecoPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblStatusPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblEmailPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblCelularPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblTelefonePessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblBairroPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblEnderecoPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblCepPessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblCpfCnpj);
            this.tpClienteEmpresa.Controls.Add(this.lblNomePessoa);
            this.tpClienteEmpresa.Controls.Add(this.lblCadastroPessoa);
            this.tpClienteEmpresa.Controls.Add(this.pbPessoa);
            this.tpClienteEmpresa.Controls.Add(this.btnExcluirPessoa);
            this.tpClienteEmpresa.Controls.Add(this.btnEditarPessoa);
            this.tpClienteEmpresa.Controls.Add(this.btnSalvarPessoa);
            this.tpClienteEmpresa.Location = new System.Drawing.Point(4, 30);
            this.tpClienteEmpresa.Name = "tpClienteEmpresa";
            this.tpClienteEmpresa.Size = new System.Drawing.Size(1247, 699);
            this.tpClienteEmpresa.TabIndex = 4;
            this.tpClienteEmpresa.Text = "Cadastros de clientes/empresas";
            this.tpClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtCidadePessoa
            // 
            this.txtCidadePessoa.Location = new System.Drawing.Point(294, 403);
            this.txtCidadePessoa.Name = "txtCidadePessoa";
            this.txtCidadePessoa.Size = new System.Drawing.Size(100, 29);
            this.txtCidadePessoa.TabIndex = 49;
            // 
            // lblCidadePessoa
            // 
            this.lblCidadePessoa.AutoSize = true;
            this.lblCidadePessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadePessoa.Location = new System.Drawing.Point(204, 414);
            this.lblCidadePessoa.Name = "lblCidadePessoa";
            this.lblCidadePessoa.Size = new System.Drawing.Size(68, 18);
            this.lblCidadePessoa.TabIndex = 48;
            this.lblCidadePessoa.Text = "Cidade: ";
            // 
            // txtEstadoPessoa
            // 
            this.txtEstadoPessoa.Location = new System.Drawing.Point(294, 368);
            this.txtEstadoPessoa.Name = "txtEstadoPessoa";
            this.txtEstadoPessoa.Size = new System.Drawing.Size(100, 29);
            this.txtEstadoPessoa.TabIndex = 47;
            // 
            // lblEstadoPessoa
            // 
            this.lblEstadoPessoa.AutoSize = true;
            this.lblEstadoPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPessoa.Location = new System.Drawing.Point(204, 379);
            this.lblEstadoPessoa.Name = "lblEstadoPessoa";
            this.lblEstadoPessoa.Size = new System.Drawing.Size(62, 18);
            this.lblEstadoPessoa.TabIndex = 46;
            this.lblEstadoPessoa.Text = "Estado:";
            // 
            // cbCategoriaPessoa
            // 
            this.cbCategoriaPessoa.FormattingEnabled = true;
            this.cbCategoriaPessoa.Location = new System.Drawing.Point(870, 214);
            this.cbCategoriaPessoa.Name = "cbCategoriaPessoa";
            this.cbCategoriaPessoa.Size = new System.Drawing.Size(121, 29);
            this.cbCategoriaPessoa.TabIndex = 45;
            // 
            // cbStatusPessoa
            // 
            this.cbStatusPessoa.FormattingEnabled = true;
            this.cbStatusPessoa.Location = new System.Drawing.Point(870, 179);
            this.cbStatusPessoa.Name = "cbStatusPessoa";
            this.cbStatusPessoa.Size = new System.Drawing.Size(121, 29);
            this.cbStatusPessoa.TabIndex = 44;
            // 
            // txtEmailPessoa
            // 
            this.txtEmailPessoa.Location = new System.Drawing.Point(859, 403);
            this.txtEmailPessoa.Name = "txtEmailPessoa";
            this.txtEmailPessoa.Size = new System.Drawing.Size(137, 29);
            this.txtEmailPessoa.TabIndex = 43;
            // 
            // txtCelularPessoa
            // 
            this.txtCelularPessoa.Location = new System.Drawing.Point(859, 368);
            this.txtCelularPessoa.Name = "txtCelularPessoa";
            this.txtCelularPessoa.Size = new System.Drawing.Size(137, 29);
            this.txtCelularPessoa.TabIndex = 42;
            // 
            // txtContatoPessoa
            // 
            this.txtContatoPessoa.Location = new System.Drawing.Point(859, 333);
            this.txtContatoPessoa.Name = "txtContatoPessoa";
            this.txtContatoPessoa.Size = new System.Drawing.Size(137, 29);
            this.txtContatoPessoa.TabIndex = 41;
            // 
            // txtNumeroPessoa
            // 
            this.txtNumeroPessoa.Location = new System.Drawing.Point(294, 508);
            this.txtNumeroPessoa.Name = "txtNumeroPessoa";
            this.txtNumeroPessoa.Size = new System.Drawing.Size(234, 29);
            this.txtNumeroPessoa.TabIndex = 40;
            // 
            // txtBairroPessoa
            // 
            this.txtBairroPessoa.Location = new System.Drawing.Point(294, 473);
            this.txtBairroPessoa.Name = "txtBairroPessoa";
            this.txtBairroPessoa.Size = new System.Drawing.Size(234, 29);
            this.txtBairroPessoa.TabIndex = 39;
            // 
            // txtEnderecoPessoa
            // 
            this.txtEnderecoPessoa.Location = new System.Drawing.Point(294, 438);
            this.txtEnderecoPessoa.Name = "txtEnderecoPessoa";
            this.txtEnderecoPessoa.Size = new System.Drawing.Size(234, 29);
            this.txtEnderecoPessoa.TabIndex = 38;
            // 
            // txtCepPessoa
            // 
            this.txtCepPessoa.Location = new System.Drawing.Point(294, 333);
            this.txtCepPessoa.Name = "txtCepPessoa";
            this.txtCepPessoa.Size = new System.Drawing.Size(100, 29);
            this.txtCepPessoa.TabIndex = 37;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(356, 214);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(175, 29);
            this.txtCpfCnpj.TabIndex = 36;
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(356, 179);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(175, 29);
            this.txtNomePessoa.TabIndex = 4;
            // 
            // lblCategoriaPessoa
            // 
            this.lblCategoriaPessoa.AutoSize = true;
            this.lblCategoriaPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaPessoa.Location = new System.Drawing.Point(779, 225);
            this.lblCategoriaPessoa.Name = "lblCategoriaPessoa";
            this.lblCategoriaPessoa.Size = new System.Drawing.Size(86, 18);
            this.lblCategoriaPessoa.TabIndex = 34;
            this.lblCategoriaPessoa.Text = "Categoria: ";
            // 
            // lblCadastroContatoPessoa
            // 
            this.lblCadastroContatoPessoa.AutoSize = true;
            this.lblCadastroContatoPessoa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroContatoPessoa.Location = new System.Drawing.Point(877, 303);
            this.lblCadastroContatoPessoa.Name = "lblCadastroContatoPessoa";
            this.lblCadastroContatoPessoa.Size = new System.Drawing.Size(97, 24);
            this.lblCadastroContatoPessoa.TabIndex = 33;
            this.lblCadastroContatoPessoa.Text = "Contato:";
            // 
            // lblNumeroPessoa
            // 
            this.lblNumeroPessoa.AutoSize = true;
            this.lblNumeroPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPessoa.Location = new System.Drawing.Point(204, 519);
            this.lblNumeroPessoa.Name = "lblNumeroPessoa";
            this.lblNumeroPessoa.Size = new System.Drawing.Size(71, 18);
            this.lblNumeroPessoa.TabIndex = 32;
            this.lblNumeroPessoa.Text = "Número: ";
            // 
            // lblCadastroEnderecoPessoa
            // 
            this.lblCadastroEnderecoPessoa.AutoSize = true;
            this.lblCadastroEnderecoPessoa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroEnderecoPessoa.Location = new System.Drawing.Point(417, 303);
            this.lblCadastroEnderecoPessoa.Name = "lblCadastroEnderecoPessoa";
            this.lblCadastroEnderecoPessoa.Size = new System.Drawing.Size(114, 24);
            this.lblCadastroEnderecoPessoa.TabIndex = 31;
            this.lblCadastroEnderecoPessoa.Text = "Endereço:";
            // 
            // lblStatusPessoa
            // 
            this.lblStatusPessoa.AutoSize = true;
            this.lblStatusPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPessoa.Location = new System.Drawing.Point(779, 190);
            this.lblStatusPessoa.Name = "lblStatusPessoa";
            this.lblStatusPessoa.Size = new System.Drawing.Size(56, 18);
            this.lblStatusPessoa.TabIndex = 30;
            this.lblStatusPessoa.Text = "Status:";
            // 
            // lblEmailPessoa
            // 
            this.lblEmailPessoa.AutoSize = true;
            this.lblEmailPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPessoa.Location = new System.Drawing.Point(779, 414);
            this.lblEmailPessoa.Name = "lblEmailPessoa";
            this.lblEmailPessoa.Size = new System.Drawing.Size(61, 18);
            this.lblEmailPessoa.TabIndex = 29;
            this.lblEmailPessoa.Text = "E-Mail: ";
            // 
            // lblCelularPessoa
            // 
            this.lblCelularPessoa.AutoSize = true;
            this.lblCelularPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularPessoa.Location = new System.Drawing.Point(779, 379);
            this.lblCelularPessoa.Name = "lblCelularPessoa";
            this.lblCelularPessoa.Size = new System.Drawing.Size(65, 18);
            this.lblCelularPessoa.TabIndex = 28;
            this.lblCelularPessoa.Text = "Celular: ";
            // 
            // lblTelefonePessoa
            // 
            this.lblTelefonePessoa.AutoSize = true;
            this.lblTelefonePessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonePessoa.Location = new System.Drawing.Point(779, 344);
            this.lblTelefonePessoa.Name = "lblTelefonePessoa";
            this.lblTelefonePessoa.Size = new System.Drawing.Size(74, 18);
            this.lblTelefonePessoa.TabIndex = 27;
            this.lblTelefonePessoa.Text = "Telefone: ";
            // 
            // lblBairroPessoa
            // 
            this.lblBairroPessoa.AutoSize = true;
            this.lblBairroPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroPessoa.Location = new System.Drawing.Point(204, 484);
            this.lblBairroPessoa.Name = "lblBairroPessoa";
            this.lblBairroPessoa.Size = new System.Drawing.Size(55, 18);
            this.lblBairroPessoa.TabIndex = 26;
            this.lblBairroPessoa.Text = "Bairro:";
            // 
            // lblEnderecoPessoa
            // 
            this.lblEnderecoPessoa.AutoSize = true;
            this.lblEnderecoPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoPessoa.Location = new System.Drawing.Point(204, 449);
            this.lblEnderecoPessoa.Name = "lblEnderecoPessoa";
            this.lblEnderecoPessoa.Size = new System.Drawing.Size(84, 18);
            this.lblEnderecoPessoa.TabIndex = 25;
            this.lblEnderecoPessoa.Text = "Endereço: ";
            // 
            // lblCepPessoa
            // 
            this.lblCepPessoa.AutoSize = true;
            this.lblCepPessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepPessoa.Location = new System.Drawing.Point(204, 344);
            this.lblCepPessoa.Name = "lblCepPessoa";
            this.lblCepPessoa.Size = new System.Drawing.Size(50, 18);
            this.lblCepPessoa.TabIndex = 24;
            this.lblCepPessoa.Text = "CEP: ";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(195, 225);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(95, 18);
            this.lblCpfCnpj.TabIndex = 23;
            this.lblCpfCnpj.Text = "CPF/CNPJ: ";
            // 
            // lblNomePessoa
            // 
            this.lblNomePessoa.AutoSize = true;
            this.lblNomePessoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePessoa.Location = new System.Drawing.Point(195, 190);
            this.lblNomePessoa.Name = "lblNomePessoa";
            this.lblNomePessoa.Size = new System.Drawing.Size(155, 18);
            this.lblNomePessoa.TabIndex = 22;
            this.lblNomePessoa.Text = "Nome/Razão Social: ";
            // 
            // lblCadastroPessoa
            // 
            this.lblCadastroPessoa.AutoSize = true;
            this.lblCadastroPessoa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroPessoa.Location = new System.Drawing.Point(595, 64);
            this.lblCadastroPessoa.Name = "lblCadastroPessoa";
            this.lblCadastroPessoa.Size = new System.Drawing.Size(379, 24);
            this.lblCadastroPessoa.TabIndex = 21;
            this.lblCadastroPessoa.Text = "Cadastro de Clientes / Fornecedores";
            // 
            // pbPessoa
            // 
            this.pbPessoa.Image = global::SistemaOrdemServico.Properties.Resources.download1;
            this.pbPessoa.Location = new System.Drawing.Point(177, 47);
            this.pbPessoa.Name = "pbPessoa";
            this.pbPessoa.Size = new System.Drawing.Size(84, 84);
            this.pbPessoa.TabIndex = 20;
            this.pbPessoa.TabStop = false;
            // 
            // btnExcluirPessoa
            // 
            this.btnExcluirPessoa.Location = new System.Drawing.Point(456, 98);
            this.btnExcluirPessoa.Name = "btnExcluirPessoa";
            this.btnExcluirPessoa.Size = new System.Drawing.Size(75, 33);
            this.btnExcluirPessoa.TabIndex = 19;
            this.btnExcluirPessoa.Text = "Excluir";
            this.btnExcluirPessoa.UseVisualStyleBackColor = true;
            // 
            // btnEditarPessoa
            // 
            this.btnEditarPessoa.Location = new System.Drawing.Point(375, 98);
            this.btnEditarPessoa.Name = "btnEditarPessoa";
            this.btnEditarPessoa.Size = new System.Drawing.Size(75, 33);
            this.btnEditarPessoa.TabIndex = 18;
            this.btnEditarPessoa.Text = "Editar";
            this.btnEditarPessoa.UseVisualStyleBackColor = true;
            // 
            // btnSalvarPessoa
            // 
            this.btnSalvarPessoa.Location = new System.Drawing.Point(294, 98);
            this.btnSalvarPessoa.Name = "btnSalvarPessoa";
            this.btnSalvarPessoa.Size = new System.Drawing.Size(75, 33);
            this.btnSalvarPessoa.TabIndex = 17;
            this.btnSalvarPessoa.Text = "Salvar";
            this.btnSalvarPessoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 733);
            this.Controls.Add(this.tcOrdemServico);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sistema de Ordem de Serviço v 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcOrdemServico.ResumeLayout(false);
            this.tpPecas.ResumeLayout(false);
            this.tpPecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeca)).EndInit();
            this.tpOrcamento.ResumeLayout(false);
            this.tpOrcamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorOrcamento)).EndInit();
            this.tpClienteEmpresa.ResumeLayout(false);
            this.tpClienteEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcOrdemServico;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private System.Windows.Forms.TabPage tpPecas;
        private System.Windows.Forms.TabPage tpOrcamento;
        private System.Windows.Forms.TabPage tpOrdemServico;
        private System.Windows.Forms.TabPage tpClienteEmpresa;
        private System.Windows.Forms.Label lblCadastroContatoPessoa;
        private System.Windows.Forms.Label lblNumeroPessoa;
        private System.Windows.Forms.Label lblCadastroEnderecoPessoa;
        private System.Windows.Forms.Label lblStatusPessoa;
        private System.Windows.Forms.Label lblEmailPessoa;
        private System.Windows.Forms.Label lblCelularPessoa;
        private System.Windows.Forms.Label lblTelefonePessoa;
        private System.Windows.Forms.Label lblBairroPessoa;
        private System.Windows.Forms.Label lblEnderecoPessoa;
        private System.Windows.Forms.Label lblCepPessoa;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblNomePessoa;
        private System.Windows.Forms.Label lblCadastroPessoa;
        private System.Windows.Forms.PictureBox pbPessoa;
        private System.Windows.Forms.Button btnExcluirPessoa;
        private System.Windows.Forms.Button btnEditarPessoa;
        private System.Windows.Forms.Button btnSalvarPessoa;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.Label lblCategoriaPessoa;
        private System.Windows.Forms.ComboBox cbCategoriaPessoa;
        private System.Windows.Forms.ComboBox cbStatusPessoa;
        private System.Windows.Forms.TextBox txtEmailPessoa;
        private System.Windows.Forms.TextBox txtCelularPessoa;
        private System.Windows.Forms.TextBox txtContatoPessoa;
        private System.Windows.Forms.TextBox txtNumeroPessoa;
        private System.Windows.Forms.TextBox txtBairroPessoa;
        private System.Windows.Forms.TextBox txtEnderecoPessoa;
        private System.Windows.Forms.TextBox txtCepPessoa;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtCidadePessoa;
        private System.Windows.Forms.Label lblCidadePessoa;
        private System.Windows.Forms.TextBox txtEstadoPessoa;
        private System.Windows.Forms.Label lblEstadoPessoa;
        private System.Windows.Forms.Button btnExcluirPeca;
        private System.Windows.Forms.Button btnEditarPeca;
        private System.Windows.Forms.Button btnSalvarPeca;
        private System.Windows.Forms.TextBox txtValorVendaPeca;
        private System.Windows.Forms.TextBox txtValorCompraPeca;
        private System.Windows.Forms.TextBox txtFabricantePeca;
        private System.Windows.Forms.TextBox txtFornecedorPeca;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.Label lblValorVendaPeca;
        private System.Windows.Forms.Label lblValorCompraPeca;
        private System.Windows.Forms.Label lblFabricantePeca;
        private System.Windows.Forms.Label lblFornecedorPeca;
        private System.Windows.Forms.Label lblNomePeca;
        private System.Windows.Forms.Label lblCadastroPeca;
        private System.Windows.Forms.PictureBox pbPeca;
        private System.Windows.Forms.Label lblPecasOrcamento;
        private System.Windows.Forms.Label lblRecebidoOrcamento;
        private System.Windows.Forms.Label lblValorOrcamento;
        private System.Windows.Forms.Label lblDescricaoOrcamento;
        private System.Windows.Forms.Label lblDataEntradaOrcamento;
        private System.Windows.Forms.Label lblClienteOrcamento;
        private System.Windows.Forms.TextBox txtDescricaoOrcamento;
        private System.Windows.Forms.DateTimePicker dtpDataEntradaOrcamento;
        private System.Windows.Forms.ComboBox cbClienteOrcamento;
        private System.Windows.Forms.ComboBox cbPecasOrcamento;
        private System.Windows.Forms.ComboBox cbRecebidoOrcamento;
        private System.Windows.Forms.Label lblMoedaOrcamento;
        private System.Windows.Forms.NumericUpDown nudValorOrcamento;
        private System.Windows.Forms.Label lblCadastroOrcamento;
        private System.Windows.Forms.Button btnExcluirOrcamento;
        private System.Windows.Forms.Button btnEditarOrcamento;
        private System.Windows.Forms.Button btnSalvarOrcamento;
    }
}

