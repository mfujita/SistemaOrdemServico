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
    public partial class CadastroFunc : Form
    {
        public CadastroFunc()
        {
            InitializeComponent();
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> validaCamposCadClie = new Dictionary<string, string>
            {
                {lblNomeFunc.Text     , txtNomeFunc.Text},
                {lblCpfFunc.Text      , txtCPFFunc.Text == "   .   .   -" ? string.Empty : txtCPFFunc.Text},
                {lblDatanascFunc.Text , txtDatanascFunc.Text == "  /  /" ? string.Empty : txtDatanascFunc.Text},
                {lblSexoFunc.Text     , cbSexoFunc.Text},
                {lblRuaFunc.Text      , txtRuaFunc.Text},
                {lblBairroFunc.Text   , txtBairroFunc.Text},
                {lblCidadeFunc.Text   , txtCidadeFunc.Text},
                {lblEstadoFunc.Text   , cbEstadoFunc.Text},
                {lblCepFunc.Text      , txtCepFunc.Text},
                {lblNumeroFunc.Text   , txtNumCasaFunc.Text},
                {lblTelefoneFunc.Text , txtTelFunc.Text},
                {lblCelularFunc.Text  , txtCelFunc.Text},
                {lblEmailFunc.Text    , txtEmailFunc.Text},
            };

            if (!Form1.TemCamposVazios(validaCamposCadClie))
            {
                getCampos();
                MessageBox.Show("Funcionário cadastrado", "Cadastro realizado com sucesso");
            }
        }
        /*
        public static void verificaTrue(int dia, int mes, int ano)
        {
            if (dia < 1 || dia > 31)
            {
                MessageBox.Show("Dia inválido");
                return;
            }
            
            if (mes < 1 || mes > 12)
            {
                MessageBox.Show("Mês inválido");
                return;
            }

            if (ano < 1890 || ano > 2022)
            {
                MessageBox.Show("Ano inválido");
                return;
            }

        }
        */
        public void getCampos()
        {
            string nomeFunc = txtNomeFunc.Text;
            string cpf = txtCPFFunc.Text;
            string strDataNasc = txtDatanascFunc.Text;
            string sexo = cbSexoFunc.Text;

            int dia = Convert.ToInt32(strDataNasc.Substring(0, 2));
            int mes = Convert.ToInt32(strDataNasc.Substring(3, 2));
            int ano = Convert.ToInt32(strDataNasc.Substring(6, 4));
            DateTime dataNasc = new DateTime(ano, mes, dia);
            
            /*
            if(dataNasc == null)
            {
                MessageBox.Show("Data invalida");
                return;

            }
            */

            string rua = txtRuaFunc.Text;
            string bairro = txtBairroFunc.Text;
            string cidade = txtCidadeFunc.Text;
            string estado = cbEstadoFunc.Text;
            string cep = txtCepFunc.Text;
            string numCasa = txtNumCasaFunc.Text;

            string telefone = txtTelFunc.Text;
            string celular = txtCelFunc.Text;
            string email = txtEmailFunc.Text;

        }

        private void btnEditFunc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecione o funcionário", "Editar funcionário", MessageBoxButtons.OK);
        }
    }
}
