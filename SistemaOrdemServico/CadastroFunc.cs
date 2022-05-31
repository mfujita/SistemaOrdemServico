using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrdemServico
{

    public partial class CadastroFunc : Form
    {
        char sexo;

        public CadastroFunc()
        {
            InitializeComponent();
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            if(Validador() == true)
            {
                var yesno = MessageBox.Show("Confirmar cadastro", "Confirmar envio", MessageBoxButtons.YesNo);

                if(yesno == DialogResult.Yes)
                {
                    string conexao = @"Server=LAB8-31\SQLEXPRESS;Database=OsFujita;User Id=sa;Password=1234;";

                    SqlConnection sqlConexao = new SqlConnection(conexao);
                    MessageBox.Show(sexo.ToString());

                    string sql = "INSERT INTO cadFunc VALUES ('" + txtCPFFunc.Text + "','" +
                        txtNomeFunc.Text + "', '" +
                        sexo + "', '" +
                        txtDatanascFunc.Text.Replace("/", "-") + "', '" +
                        txtCepFunc.Text + "', '" +
                        txtTelFunc.Text + "', '" +
                        txtCelFunc.Text + "', '" +
                        txtEmailFunc.Text + "', '" +
                        cbEstadoFunc.Text + "', '" +
                        txtCidadeFunc.Text + "', '" +
                        txtBairroFunc.Text + "', '" +
                        txtNumCasaFunc.Text + "', '" +
                        txtRuaFunc.Text + "')";

                    SqlCommand comando = new SqlCommand(sql, sqlConexao);
                    comando.Connection.Open();
                    comando.ExecuteNonQuery();

                    comando.Dispose();
                    sqlConexao.Close();

                    btnSalvarFunc.BackColor = Color.Gray;

                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro concluido");
                }
                else
                {
                    return;
                }
            }
        }

        public bool Validador() { 
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
                return true;
            }
            else
            {
                return false;
            }
        }

        //validacao semi inutil
        public void getCampos()
        {
            string nomeFunc = txtNomeFunc.Text;
            string cpf = txtCPFFunc.Text;
            string strDataNasc = txtDatanascFunc.Text;
            string sexo = cbSexoFunc.Text;

            int dia = Convert.ToInt32(strDataNasc.Substring(0, 2));
            int mes = Convert.ToInt32(strDataNasc.Substring(3, 2));
            int ano = Convert.ToInt32(strDataNasc.Substring(6, 4));
            try
            {
                DateTime dataNasc = new DateTime(ano, mes, dia);
            }
            catch (Exception)
            {
                MessageBox.Show("Data inválida");
                return;
            }

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

        
        private void CadastroFunc_Load(object sender, EventArgs e)
        {
            txtNomeFunc.Text = "Gustavo";
            txtCPFFunc.Text = "44444444444";
            txtDatanascFunc.Text = "15/08/2002";
            cbSexoFunc.Text = "Masculino";
            txtRuaFunc.Text = "Juscelino";
            txtBairroFunc.Text = "Kubicheque";
            txtCidadeFunc.Text = "Americana";
            cbEstadoFunc.Text = "SP";
            txtCepFunc.Text = "14888290";
            txtNumCasaFunc.Text = "404";
            txtTelFunc.Text = "34075566";
            txtCelFunc.Text = "19994197566";
            txtEmailFunc.Text = "gustavo_allm@outlook.com";
        }

        private void cbSexoFunc_DropDownClosed(object sender, EventArgs e)
        {
            if (cbSexoFunc.Text == "Masculino")
            {
                sexo = 'M';
            }
            else
            {
                sexo = 'F';
            }
        }
    }
}
