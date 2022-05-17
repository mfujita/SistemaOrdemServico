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
    public partial class cadPessoa : Form
    {
        Form1 frm = new Form1();
        public cadPessoa()
        {
            InitializeComponent();
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

            if (!frm.TemCamposVazios(validaCamposCadClie))
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
            int cpfCnpj = Convert.ToInt32(txtCpfCnpj);
            int cep = Convert.ToInt32(txtCepPessoa.Text);
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
    }
}
