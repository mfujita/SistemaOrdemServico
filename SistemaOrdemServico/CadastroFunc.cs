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

            if (!TemCamposVazios(validaCamposCadClie))
            {
                getCampos();
                MessageBox.Show("OK", "Cadastro realizado com sucesso");
            }
        }

        public void getCampos()
        {
            string nomeFunc = txtNomeFunc.Text;
            string cpf = txtCPFFunc.Text;
            string strDataNasc = txtDatanascFunc.Text;
            int dia = Convert.ToInt32(strDataNasc.Substring(0, 2));
            int mes = Convert.ToInt32(strDataNasc.Substring(3, 2));
            int ano = Convert.ToInt32(strDataNasc.Substring(6, 4));
            DateTime dataNasc = new DateTime(ano, mes, dia);
            string sexo = cbSexoFunc.Text;

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
    }
}
