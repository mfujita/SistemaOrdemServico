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
        
         public SqlConnection AbreConexao()
        {
            //string conexao = @"Server=LAB8-31\SQLEXPRESS;Database=OsFujita;User Id=sa;Password=1234;";
            string conexao = @"Data source=DESKTOP-FR4CCG0;Initial Catalog=OsFujita;Integrated Security=True;";
                return new SqlConnection(conexao);

        }
        

        //Confirmacao se realmente vai enviar o cadastro, caso sim é aberta conexao com o banco e envia os dados preenchidos,
        //Caso a data digitada seja invalida ira aparecer uma mensagem de alerta antes da de confirmacao de envio.
        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            if(Validador() == true)
            {
                var yesno = MessageBox.Show("Confirmar cadastro", "Confirmar envio", MessageBoxButtons.YesNo);

                if(yesno == DialogResult.Yes)
                {
                    SqlConnection conexao = AbreConexao();

                    string sql = "INSERT INTO cadFunc VALUES ('" + txtCPFFunc.Text.Replace("-","") + "','" +
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

                    SqlCommand comando = new SqlCommand(sql, conexao);
                    comando.Connection.Open();
                    comando.ExecuteNonQuery();

                    comando.Dispose();
                    conexao.Close();

                    btnSalvarFunc.BackColor = Color.Gray;

                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro concluido");
                    ClearControl(this);
                    btnSalvarFunc.BackColor = Color.LightGray;
                }
                else
                {
                    return;
                }
            }
        }

        //Verifica os campos que estao vazios 
        public bool Validador() { 
            Dictionary<string, string> validaCamposCadClie = new Dictionary<string, string>
            {
                {lblNomeFunc.Text     , txtNomeFunc.Text},
                {lblCpfFunc.Text      , txtCPFFunc.Text == "         -" ? string.Empty : txtCPFFunc.Text},
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

        //Pega os campos e salva nas variaveis
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

        //Preenchimento automatico para testes
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
        
        //Transforma a string sexo em char pra mandar pro banco
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

        //Metodo pra limpar form generico 
        public static void ClearControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).MinDate = new DateTime(1900, 1, 1);
                    ((DateTimePicker)c).MaxDate = new DateTime(2100, 1, 1);
                    ((DateTimePicker)c).Value = DateTime.Now.Date < ((DateTimePicker)c).MinDate ? ((DateTimePicker)c).MinDate : DateTime.Now.Date > ((DateTimePicker)c).MaxDate ? ((DateTimePicker)c).MaxDate : DateTime.Now.Date;
                    if (((DateTimePicker)c).ShowCheckBox)
                        ((DateTimePicker)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0 < ((NumericUpDown)c).Minimum ? ((NumericUpDown)c).Minimum : 0 > ((NumericUpDown)c).Maximum ? ((NumericUpDown)c).Maximum : 0;// ((NumericUpDown)c).Minimum;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }
                else if (c is Label)
                {
                    //((Label)c).Text = "";
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }
                //else if (c is TrackBar)
                //    ((TrackBar)c).Value = ((TrackBar)c).Minimum;
                //else if (c is RichTextBoxExtended)
                //    ((RichTextBoxExtended)c).ResetText();
                else if (c.HasChildren)
                {
                    if (c is TabControl)
                        ((TabControl)c).SelectedIndex = 0;

                    ClearControl(c);
                }
            }
        }
    }
}
