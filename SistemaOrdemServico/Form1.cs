using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrdemServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Metodo que verifica se existem campos em branco na tela em que foi chamado.
        private bool TemCamposVazios(Dictionary<string, string> camposDeEntrada)
        {
            List<string> camposVazios = camposDeEntrada.Where(campo => campo.Value == string.Empty)
                .Select(campo => campo.Key.Replace(":", "")).ToList();

            if (camposVazios.Count > 0)
            {
                //Exibe quais campos estão em branco
                MessageBox.Show(
                    $"Preencha o(s) campo(s) obrigatório(s):{Environment.NewLine}{string.Join(Environment.NewLine, camposVazios)}",
                    "Preencha todos os campos.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDataEntradaOrcamento.Value = DateTime.Today;
        }

        private void btnSalvarPeca_Click(object sender, EventArgs e)
        {
            string nome = txtNomePeca.Text;
            string fornecedor = txtFornecedorPeca.Text;
            string fabricante = txtFabricantePeca.Text;
            string valorCompra = txtValorCompraPeca.Text;
            string valorVenda = txtValorVendaPeca.Text;

            if ( nome == string.Empty || fornecedor == string.Empty || fabricante == string.Empty || valorCompra == string.Empty || valorVenda == string.Empty)
            {
                MessageBox.Show("Campo precisa ser preenchido");
            }

        }

        //Butão SALVAR do burim ***NÃO MEXER! SUJEITO A CACETE***
        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            //Get de todos os campos da tela de cadastro de cliente
            Dictionary<string, string> validaCamposCadClie = new Dictionary<string, string>
            {
                {lblNomePessoa.Text     , txtNomePessoa.Text},
                {lblCpfCnpj.Text        , txtCpfCnpj.Text},
                {lblCepPessoa.Text      , txtCepPessoa.Text},
                {lblEstadoPessoa.Text   , txtEstadoPessoa.Text},
                {lblCidadePessoa.Text   , txtCidadePessoa.Text},
                {lblEnderecoPessoa.Text , txtEnderecoPessoa.Text},
                {lblNumeroPessoa.Text   , txtNumeroPessoa.Text},
                {lblTelefonePessoa.Text , txtTelefonePessoa.Text},
                {lblCelularPessoa.Text  , txtCelularPessoa.Text},
                {lblEmailPessoa.Text    , txtEmailPessoa.Text},
                {lblStatusPessoa.Text   , cbStatusPessoa.Text},
                {lblCategoriaPessoa.Text, cbCategoriaPessoa.Text},
            };

            if (!TemCamposVazios(validaCamposCadClie))
            {
                salvaCampos();
                MessageBox.Show("OK", "Cadastro realizado com sucesso");
            }
        }

        //Butão SALVAR do burim ***NÃO MEXER! SUJEITO A CACETE***
        private void btnEditarPessoa_Click(object sender, EventArgs e)
        {
            //verificaCampos();
        }
        //Butão SALVAR do burim ***NÃO MEXER! SUJEITO A CACETE***
        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {

        }
        //Salva os campos puxar classe conecta banco e passar como parâmetros os valores dessa classe
        //***NÃO MEXER! SUJEITO A CACETE***
        public void salvaCampos()
        {
            int cpfCnpj       = Convert.ToInt32(txtCpfCnpj);
            int cep           = Convert.ToInt32(txtCepPessoa.Text);
            string nomePessoa = txtNomePessoa.Text;
            string estado     = txtEstadoPessoa.Text;
            string cidade     = txtCidadePessoa.Text;
            string endereco   = txtEnderecoPessoa.Text;
            string numEnd     = txtNumeroPessoa.Text;
            string telefone   = txtTelefonePessoa.Text;
            string celular    = txtCelularPessoa.Text;
            string email      = txtEmailPessoa.Text;
            string status     = cbStatusPessoa.Text;
            string categoria  = cbCategoriaPessoa.Text;
        }

        private void btnSalvarOrcamento_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> camposDeEntrada = new Dictionary<string, string>
            {
                {lblClienteOrcamento.Text, cbClienteOrcamento.Text},
                {lblDataEntradaOrcamento.Text, dtpDataEntradaOrcamento.Text},
                {lblDescricaoOrcamento.Text, txtDescricaoOrcamento.Text},
                {lblPecasOrcamento.Text, cbPecasOrcamento.Text},
                {lblValorOrcamento.Text, nudValorOrcamento.Text == "0,00" ? string.Empty : nudValorOrcamento.Text},
                {lblRecebidoOrcamento.Text, cbRecebidoOrcamento.Text}
            };

            if (!TemCamposVazios(camposDeEntrada))
            {
                try
                {
                    /*string connection = "";
                    SqlConnection sqlConnection = new SqlConnection(connection);

                    string sql = $"INSERT INTO cadOrcamento VALUES({string.Join(", ", camposDeEntrada)})";
                    SqlCommand command = new SqlCommand(sql, sqlConnection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    command.Dispose();
                    sqlConnection.Close();

                    */
                    MessageBox.Show(
                        "Enviado para o banco de dados com sucesso.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                } catch(Exception ex)
                {
                    MessageBox.Show(
                        ex.ToString(),
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
