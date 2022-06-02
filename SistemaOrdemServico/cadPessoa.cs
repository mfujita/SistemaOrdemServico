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
        private void btnSalvarPessoa_Click_1(object sender, EventArgs e)
        {
            //Get de todos os campos da tela de cadastro de cliente e verifica se estão em branco
            if (validaCampos() == true)
            {
                var yesno = MessageBox.Show("Confirmar cadastro", "Confirmar envio", MessageBoxButtons.YesNo);

                if (yesno == DialogResult.Yes)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro concluido");
                }
                else
                {
                    return;
                }
            }
        }

        private void btnEditarPessoa_Click_1(object sender, EventArgs e)
        {

        }
        private void btnExcluirPessoa_Click_1(object sender, EventArgs e)
        {

        }

        //valida campos em branco
        public bool validaCampos()
        {
            Dictionary<string, string> validaCamposCadClie = new Dictionary<string, string>
            {
                {lblNomePessoa.Text     , txtNomePessoa.Text},
                {lblCpfCnpj.Text        , txtCpfCnpj.Text == "   .   .   -" ? string.Empty :txtCpfCnpj.Text},
                {lblCepPessoa.Text      , txtCepPessoa.Text == "     -" ? string.Empty :txtCpfCnpj.Text},
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
                return true;
                //envia para o banco
            }
            else
            {
                return false;
                //cancela o processo
            }
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

        private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            string entrada = txtCpfCnpj.Text;
            string formatado = String.Join("", System.Text.RegularExpressions.Regex.Split(entrada, @"[^\d]"));
            if (formatado.Length >10)
            {
                this.txtCpfCnpj.Mask = "00,000,000/0000-00";//cnpj
                //this.txtCpfCnpj.TextMaskFormat = { };
                Console.WriteLine(txtCpfCnpj.TextLength);
                Console.WriteLine(formatado);
            }
            else
            {
                this.txtCpfCnpj.Mask = "000,000,000-00";//cpf
                Console.WriteLine(txtCpfCnpj.TextLength);
                Console.WriteLine(formatado);
            }
        }

    }
}
