using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Form CadPessoas do burim
//***NÃO MEXER! SUJEITO A CACETE***

namespace SistemaOrdemServico
{
    public partial class cadPessoa : Form
    {
        public cadPessoa()
        {
            InitializeComponent();
        }
        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            //Get de todos os campos da tela de cadastro de cliente e verifica se estão em branco
            Dictionary<string, string> validaCamposCadClie = new Dictionary<string, string>
            {
                {lblNomePessoa.Text     , txtNomePessoa.Text},
                {lblCpfCnpj.Text        , txtCpfCnpj.Text == },//ta pegando a máscara dos campos
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

            if (!Form1.TemCamposVazios(validaCamposCadClie))
            {
                getDados();
                MessageBox.Show("OK", "Cadastro realizado com sucesso");
            }
        }

        private void btnEditarPessoa_Click(object sender, EventArgs e)
        {

        }
        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {

        }
        //coleta todos os dados e passa em variáveis
        public void getDados()
        {
            string cpfCnpj = txtCpfCnpj.Text;
            string cep = txtCepPessoa.Text;
            string nomePessoa = txtNomePessoa.Text;
            string estado = txtEstadoPessoa.Text;
            string cidade = txtCidadePessoa.Text;
            string endereco = txtEnderecoPessoa.Text;
            string numEnd = txtNumeroPessoa.Text;
            string telefone = txtTelefonePessoa.Text;
            string celular = txtCelularPessoa.Text;
            string email = txtEmailPessoa.Text;
            string status = cbStatusPessoa.Text;
            string categoria = cbCategoriaPessoa.Text;
        }

        public void insertCadPess(){

        }
        public void updateCadPess()
        {

        }
        public void deleteCadPess()
        {

        }
    }
}
