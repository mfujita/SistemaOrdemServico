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
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.labelValorCompra = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelNomePeca = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tpOrcamento = new System.Windows.Forms.TabPage();
            this.tpOrdemServico = new System.Windows.Forms.TabPage();
            this.tpClienteEmpresa = new System.Windows.Forms.TabPage();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcOrdemServico.SuspendLayout();
            this.tpPecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpClienteEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tcOrdemServico.SelectedIndexChanged += new System.EventHandler(this.tcOrdemServico_SelectedIndexChanged);
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
            this.tpFuncionarios.Click += new System.EventHandler(this.tpFuncionarios_Click);
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
            this.tpPecas.Controls.Add(this.labelValorVenda);
            this.tpPecas.Controls.Add(this.labelValorCompra);
            this.tpPecas.Controls.Add(this.labelFabricante);
            this.tpPecas.Controls.Add(this.labelFornecedor);
            this.tpPecas.Controls.Add(this.labelNomePeca);
            this.tpPecas.Controls.Add(this.label17);
            this.tpPecas.Controls.Add(this.pictureBox2);
            this.tpPecas.Location = new System.Drawing.Point(4, 30);
            this.tpPecas.Name = "tpPecas";
            this.tpPecas.Padding = new System.Windows.Forms.Padding(3);
            this.tpPecas.Size = new System.Drawing.Size(1247, 699);
            this.tpPecas.TabIndex = 1;
            this.tpPecas.Text = "Cadastro de peças";
            this.tpPecas.UseVisualStyleBackColor = true;
            this.tpPecas.Click += new System.EventHandler(this.tpPecas_Click);
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
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorVenda.Location = new System.Drawing.Point(160, 399);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(97, 18);
            this.labelValorVenda.TabIndex = 29;
            this.labelValorVenda.Text = "Valor Venda:";
            // 
            // labelValorCompra
            // 
            this.labelValorCompra.AutoSize = true;
            this.labelValorCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorCompra.Location = new System.Drawing.Point(160, 352);
            this.labelValorCompra.Name = "labelValorCompra";
            this.labelValorCompra.Size = new System.Drawing.Size(109, 18);
            this.labelValorCompra.TabIndex = 28;
            this.labelValorCompra.Text = "Valor Compra:";
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFabricante.Location = new System.Drawing.Point(160, 306);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(87, 18);
            this.labelFabricante.TabIndex = 27;
            this.labelFabricante.Text = "Fabricante:";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.Location = new System.Drawing.Point(160, 261);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(93, 18);
            this.labelFornecedor.TabIndex = 26;
            this.labelFornecedor.Text = "Fornecedor:";
            // 
            // labelNomePeca
            // 
            this.labelNomePeca.AutoSize = true;
            this.labelNomePeca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomePeca.Location = new System.Drawing.Point(160, 219);
            this.labelNomePeca.Name = "labelNomePeca";
            this.labelNomePeca.Size = new System.Drawing.Size(54, 18);
            this.labelNomePeca.TabIndex = 25;
            this.labelNomePeca.Text = "Nome:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(288, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 24);
            this.label17.TabIndex = 22;
            this.label17.Text = "Cadastro de peças";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(163, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // tpOrcamento
            // 
            this.tpOrcamento.Location = new System.Drawing.Point(4, 30);
            this.tpOrcamento.Name = "tpOrcamento";
            this.tpOrcamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrcamento.Size = new System.Drawing.Size(1247, 699);
            this.tpOrcamento.TabIndex = 2;
            this.tpOrcamento.Text = "Cadastro de orçamentos";
            this.tpOrcamento.UseVisualStyleBackColor = true;
            this.tpOrcamento.Click += new System.EventHandler(this.tpOrcamento_Click);
            // 
            // tpOrdemServico
            // 
            this.tpOrdemServico.Location = new System.Drawing.Point(4, 30);
            this.tpOrdemServico.Name = "tpOrdemServico";
            this.tpOrdemServico.Size = new System.Drawing.Size(1247, 699);
            this.tpOrdemServico.TabIndex = 3;
            this.tpOrdemServico.Text = "Cadastro de ordem de serviço";
            this.tpOrdemServico.UseVisualStyleBackColor = true;
            this.tpOrdemServico.Click += new System.EventHandler(this.tpOrdemServico_Click);
            // 
            // tpClienteEmpresa
            // 
            this.tpClienteEmpresa.Controls.Add(this.textBox11);
            this.tpClienteEmpresa.Controls.Add(this.label16);
            this.tpClienteEmpresa.Controls.Add(this.textBox10);
            this.tpClienteEmpresa.Controls.Add(this.label15);
            this.tpClienteEmpresa.Controls.Add(this.comboBox2);
            this.tpClienteEmpresa.Controls.Add(this.comboBox1);
            this.tpClienteEmpresa.Controls.Add(this.textBox9);
            this.tpClienteEmpresa.Controls.Add(this.textBox8);
            this.tpClienteEmpresa.Controls.Add(this.textBox7);
            this.tpClienteEmpresa.Controls.Add(this.textBox6);
            this.tpClienteEmpresa.Controls.Add(this.textBox5);
            this.tpClienteEmpresa.Controls.Add(this.textBox4);
            this.tpClienteEmpresa.Controls.Add(this.textBox3);
            this.tpClienteEmpresa.Controls.Add(this.textBox2);
            this.tpClienteEmpresa.Controls.Add(this.textBox1);
            this.tpClienteEmpresa.Controls.Add(this.label14);
            this.tpClienteEmpresa.Controls.Add(this.label13);
            this.tpClienteEmpresa.Controls.Add(this.label12);
            this.tpClienteEmpresa.Controls.Add(this.label11);
            this.tpClienteEmpresa.Controls.Add(this.label10);
            this.tpClienteEmpresa.Controls.Add(this.label9);
            this.tpClienteEmpresa.Controls.Add(this.label8);
            this.tpClienteEmpresa.Controls.Add(this.label7);
            this.tpClienteEmpresa.Controls.Add(this.label6);
            this.tpClienteEmpresa.Controls.Add(this.label5);
            this.tpClienteEmpresa.Controls.Add(this.label4);
            this.tpClienteEmpresa.Controls.Add(this.label3);
            this.tpClienteEmpresa.Controls.Add(this.label2);
            this.tpClienteEmpresa.Controls.Add(this.label1);
            this.tpClienteEmpresa.Controls.Add(this.pictureBox1);
            this.tpClienteEmpresa.Controls.Add(this.button3);
            this.tpClienteEmpresa.Controls.Add(this.button2);
            this.tpClienteEmpresa.Controls.Add(this.button1);
            this.tpClienteEmpresa.Location = new System.Drawing.Point(4, 30);
            this.tpClienteEmpresa.Name = "tpClienteEmpresa";
            this.tpClienteEmpresa.Size = new System.Drawing.Size(1247, 699);
            this.tpClienteEmpresa.TabIndex = 4;
            this.tpClienteEmpresa.Text = "Cadastros de clientes/empresas";
            this.tpClienteEmpresa.UseVisualStyleBackColor = true;
            this.tpClienteEmpresa.Click += new System.EventHandler(this.tpClienteEmpresa_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(294, 403);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 29);
            this.textBox11.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(204, 414);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 18);
            this.label16.TabIndex = 48;
            this.label16.Text = "Cidade: ";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(294, 368);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 29);
            this.textBox10.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(204, 379);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 46;
            this.label15.Text = "Estado:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(870, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 29);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(870, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(859, 403);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(137, 29);
            this.textBox9.TabIndex = 43;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(859, 368);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(137, 29);
            this.textBox8.TabIndex = 42;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(859, 333);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 29);
            this.textBox7.TabIndex = 41;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(294, 508);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(234, 29);
            this.textBox6.TabIndex = 40;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(294, 473);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(234, 29);
            this.textBox5.TabIndex = 39;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(294, 438);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 29);
            this.textBox4.TabIndex = 38;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 333);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 37;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 29);
            this.textBox2.TabIndex = 36;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(779, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 18);
            this.label14.TabIndex = 34;
            this.label14.Text = "Categoria: ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(877, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 24);
            this.label13.TabIndex = 33;
            this.label13.Text = "Contato:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(204, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Número: ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(417, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 24);
            this.label11.TabIndex = 31;
            this.label11.Text = "Endereço:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(779, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Status:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(779, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "E-Mail: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(779, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Celular: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(779, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Telefone: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Bairro:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Endereço: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "CEP: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "CPF/CNPJ: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome/Razão Social: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cadastro de Clientes / Fornecedores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaOrdemServico.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(177, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 84);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tcOrdemServico.ResumeLayout(false);
            this.tpPecas.ResumeLayout(false);
            this.tpPecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpClienteEmpresa.ResumeLayout(false);
            this.tpClienteEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcOrdemServico;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private System.Windows.Forms.TabPage tpPecas;
        private System.Windows.Forms.TabPage tpOrcamento;
        private System.Windows.Forms.TabPage tpOrdemServico;
        private System.Windows.Forms.TabPage tpClienteEmpresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnExcluirPeca;
        private System.Windows.Forms.Button btnEditarPeca;
        private System.Windows.Forms.Button btnSalvarPeca;
        private System.Windows.Forms.TextBox txtValorVendaPeca;
        private System.Windows.Forms.TextBox txtValorCompraPeca;
        private System.Windows.Forms.TextBox txtFabricantePeca;
        private System.Windows.Forms.TextBox txtFornecedorPeca;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.Label labelValorVenda;
        private System.Windows.Forms.Label labelValorCompra;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelNomePeca;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

