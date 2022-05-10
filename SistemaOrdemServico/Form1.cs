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

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDataEntradaOrcamento.Value = DateTime.Today;
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            verificaCampos();
        }
        private void btnEditarPessoa_Click(object sender, EventArgs e)
        {
            verificaCampos();
        }
        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {

        }
        public void verificaCampos()
        {
            string nome      = txtNomePessoa.Text;
            string cpfCnpj   = txtCpfCnpj.Text;
            string cep       = txtCepPessoa.Text;
            string estado    = txtEstadoPessoa.Text;
            string cidade    = txtCidadePessoa.Text;
            string endereco  = txtEnderecoPessoa.Text;
            string numero    = txtNumeroPessoa.Text;
            string contato   = txtContatoPessoa.Text;
            string celular   = txtCelularPessoa.Text;
            string email     = txtEmailPessoa.Text;
            string status    = cbStatusPessoa.Text;
            string categoria = cbCategoriaPessoa.Text;



            if (nome == string.Empty || cpfCnpj == string.Empty || cep == string.Empty || estado == string.Empty ||  cidade == string.Empty || endereco == string.Empty || numero == string.Empty || contato == string.Empty || celular == string.Empty || email == string.Empty || status == string.Empty ||categoria == string.Empty)
            {
                MessageBox.Show("Campo precisa ser preenchido");

            }
        }

       
    }
}
