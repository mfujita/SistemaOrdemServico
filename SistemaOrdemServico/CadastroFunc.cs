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
        private readonly Invocador invocador;
        private readonly BancoDadosOrcamento bancoDados;
        private readonly SqlConnection conexao;
        char sexo;           // Pega o sexo na tela de cadastro
        char sexoSend;       // Pega o sexo na tela de edicao
        int idFunc;          // Salva o idFunc para uso posterior
        bool ConfirmaDelete; // Retorna a confirmação que o nome digitado pra deletar existe
        bool dataInvalida;   // Retorna se a data é valida ou não
        

        public CadastroFunc(Invocador invocador)
        {
            InitializeComponent();

            this.invocador = invocador;
            bancoDados = new BancoDadosOrcamento();
            conexao = bancoDados.GetConexao();
        }
        private void CadastroFunc_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        //Verifica os campos vazios e informa quais são eles
        public static bool TemCamposVazios(Dictionary<string, string> camposDeEntrada)
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

        //Verifica os campos que estao vazios 
        public bool Validador()
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
                {lblCepFunc.Text      , txtCepFunc.Text == "     -" ? string.Empty : txtCepFunc.Text},
                {lblNumeroFunc.Text   , txtNumCasaFunc.Text},
                //{lblTelefoneFunc.Text , txtTelFunc.Text == "(  )    -" ? string.Empty : txtTelFunc.Text},
                {lblCelularFunc.Text  , txtCelFunc.Text == "(  )     -" ? string.Empty : txtCelFunc.Text},
                {lblEmailFunc.Text    , txtEmailFunc.Text},
            };

            if (TemCamposVazios(validaCamposCadClie) == false)
            {
                GetData();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Pega o texto da data e salva em um datetime, tambem verifica se a data é valida
        public void GetData()
        {
            string strDataNasc = txtDatanascFunc.Text;
            int dia = Convert.ToInt32(strDataNasc.Substring(0, 2));
            int mes = Convert.ToInt32(strDataNasc.Substring(3, 2));
            int ano = Convert.ToInt32(strDataNasc.Substring(6, 4));
            try
            {
                DateTime dataNasc = new DateTime(ano, mes, dia);
                dataInvalida = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Data inválida");
                dataInvalida = false;
                return;
            }
        }

        //Muda o ponteiro do mouse e estiliza ao passar o mouse
        private void btnSalvarFunc_MouseEnter(object sender, EventArgs e)
        {
            btnSalvarFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSalvarFunc.BackColor = Color.LightGreen;
        }
        private void btnSalvarFunc_MouseLeave(object sender, EventArgs e)
        {
            btnSalvarFunc.BackColor = Color.Gainsboro;
        }

        //Verifica se os campos estao preenchidos e se a data esta correta,
        //caso sim é aberta conexao com o banco e é feito o envio dos dados.
        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            if (Validador() == true && dataInvalida == true)
            {
                var yesno = MessageBox.Show("Confirmar cadastro", "Confirmar envio", MessageBoxButtons.YesNo);

                if (yesno == DialogResult.Yes)
                {
                    string sql = "INSERT INTO cadFunc VALUES ('" + txtCPFFunc.Text.Replace("-", "").Replace(".", "") + "','" +
                        txtNomeFunc.Text + "', '" +
                        sexo + "', '" +
                        txtDatanascFunc.Text.Replace("/", "-") + "', '" +
                        txtCepFunc.Text.Replace("-", "") + "', '" +
                        txtTelFunc.Text.Replace("(", "").Replace(")", "").Replace("-", "") + "', '" +
                        txtCelFunc.Text.Replace("(", "").Replace(")", "").Replace("-", "") + "', '" +
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

        //Muda ponteiro do mouse e estiliza ao passar o mouse
        private void btnCancelaCad_MouseEnter(object sender, EventArgs e)
        {
            btnCancelaCad.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelaCad.BackColor = Color.IndianRed;
        }
        private void btnCancelaCad_MouseLeave(object sender, EventArgs e)
        {
            btnCancelaCad.BackColor = Color.Gainsboro;
        }
        //Limpa a tela ao clicar em cancelar
        private void btnCancelaCad_Click(object sender, EventArgs e)
        {
            ClearControl(this);
        }

        //Transforma a string sexo em char pra mandar pro banco       
        private void cbSexoFunc_SelectionChangeCommitted(object sender, EventArgs e)
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


        //Muda o ponteiro do mouse ao passar no botao e estiliza
        private void btnPesquisarEdit_MouseEnter(object sender, EventArgs e)
        {
            btnPesquisarEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPesquisarEdit.BackColor = Color.LightGreen;
        }
        private void btnPesquisarEdit_MouseLeave(object sender, EventArgs e)
        {
            btnPesquisarEdit.BackColor = Color.Gainsboro;
        }

        //Traz os dados do banco pra tela de edição pelo nome do funcionário, primeiro verifica se o nome está em branco
        //caso nao esteja em branco o datareader preenche as textbox para edição
        private void btnPesquisarEdit_Click(object sender, EventArgs e)
        {
            string nomePesquisa = txtPesquisaEdit.Text;

            if (nomePesquisa == string.Empty)
            {
                MessageBox.Show("Digite um nome", "Nome em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string sql = "SELECT * FROM cadFunc WHERE nome = '" + nomePesquisa + "' ";

                    SqlCommand comandoConsultaEdita = new SqlCommand(sql, conexao);

                    conexao.Open();
                    SqlDataReader dados = comandoConsultaEdita.ExecuteReader();

                    dados.Read();

                    idFunc = (int)dados[0];
                    txtCPFuncEdit.Text = (string)dados[1];
                    txtNomeFuncEdit.Text = (string)dados[2];
                    string sexoEdit = (string)dados[3];

                    if (sexoEdit == "M")
                    {
                        cbSexoFuncEdit.Text = "Masculino";
                    }
                    else
                    {
                        cbSexoFuncEdit.Text = "Feminino";
                    }

                    DateTime dataEdit = (DateTime)dados[4];
                    txtDtNascFuncEdit.Text = dataEdit.ToString();
                    txtCepFuncEdit.Text = (string)dados[5];
                    txtTelFuncEdit.Text = (string)dados[6];
                    txtCelFuncEdit.Text = (string)dados[7];
                    txtEmailFuncEdit.Text = (string)dados[8];
                    cbEstadoFuncEdit.Text = (string)dados[9];
                    txtCidadeFuncEdit.Text = (string)dados[10];
                    txtBairroFuncEdit.Text = (string)dados[11];
                    txtNumCFuncEdit.Text = (string)dados[12];
                    txtRuaFuncEdit.Text = (string)dados[13];

                    comandoConsultaEdita.Dispose();
                }
                catch (Exception)
                {
                    txtPesquisaEdit.Text = "";
                    MessageBox.Show("Nome incorreto ou não existente");
                    ClearControl(this);
                    tabControl1.SelectTab(tbEdit);
                    return;
                }
                finally
                {
                    conexao.Close();
                }

            }
        }

        //Muda o ponteiro do mouse ao passar no botao e estiliza 
        private void btnEditFunc_MouseEnter(object sender, EventArgs e)
        {
            btnEditFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditFunc.BackColor = Color.CadetBlue;
        }
        private void btnEditFunc_MouseLeave(object sender, EventArgs e)
        {
            btnEditFunc.BackColor = Color.Gainsboro;
        }

        //Envia os dados atualizados na tela de editar funcionário pro banco
        private void btnEditFunc_Click(object sender, EventArgs e)
        {
            if (ValidadorEdit() == true && dataInvalida == true)
            {
                string sql = "UPDATE cadFunc set cpf = '" + txtCPFuncEdit.Text.Replace("-", "").Replace(".", "") + "', nome = '" +
                    txtNomeFuncEdit.Text + "', sexo = '" +
                    sexoSend + "', dtNasc = '" +
                    txtDtNascFuncEdit.Text.Replace("/", "-") + "', cep = '" +
                    txtCepFuncEdit.Text.Replace("-", "") + "', telefone = '" +
                    txtTelFuncEdit.Text.Replace("(", "").Replace(")", "").Replace("-", "") + "', celular = '" +
                    txtCelFuncEdit.Text.Replace("(", "").Replace(")", "").Replace("-", "") + "', email = '" +
                    txtEmailFuncEdit.Text + "', estado = '" +
                    cbEstadoFuncEdit.Text + "', cidade = '" +
                    txtCidadeFuncEdit.Text + "', bairro = '" +
                    txtBairroFuncEdit.Text + "', numero = '" +
                    txtNumCFuncEdit.Text + "', rua = '" +
                    txtRuaFuncEdit.Text + "' WHERE idFunc = '" + idFunc + "'";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Connection.Open();
                comando.ExecuteNonQuery();

                comando.Dispose();
                conexao.Close();

                btnEditFunc.BackColor = Color.Gray;

                MessageBox.Show("Cadastro atualizado com sucesso!", "Atualização concluida");
                ClearControl(this);
                btnEditFunc.BackColor = Color.LightGray;
                tabControl1.SelectTab(tbEdit);
            }
            else
            {
                return;
            }
        }

        public bool ValidadorEdit()
        {
            Dictionary<string, string> validaCamposCadClie = new Dictionary<string, string>
            {
                {lblNomeFuncEdit.Text     , txtNomeFuncEdit.Text},
                {lblCPFuncEdit.Text       , txtCPFuncEdit.Text == "   .   .   -" ? string.Empty : txtCPFFunc.Text},
                {lblDtNascFuncEdit.Text   , txtDtNascFuncEdit.Text == "  /  /" ? string.Empty : txtDatanascFunc.Text},
                {lblSexoFuncEdit.Text     , cbSexoFuncEdit.Text},
                {lblRuaFuncEdit.Text      , txtRuaFuncEdit.Text},
                {lblBairroFuncEdit.Text   , txtBairroFuncEdit.Text},
                {lblCidadFuncEdit.Text    , txtCidadeFuncEdit.Text},
                {lblEstadoFuncEdit.Text   , cbEstadoFuncEdit.Text},
                {lblCepFuncEdit.Text      , txtCepFuncEdit.Text == "     -" ? string.Empty : txtCepFuncEdit.Text},
                {lblNumCFuncEdit.Text     , txtNumCFuncEdit.Text},
                //{lblTelFuncEdit.Text      , txtTelFuncEdit.Text == "(  )    -" ? string.Empty : txtTelFunc.Text},
                {lblCelFuncEdit.Text      , txtCelFuncEdit.Text == "(  )     -" ? string.Empty : txtTelFunc.Text},
                {lblEmailFuncEdit.Text    , txtEmailFuncEdit.Text},
            };

            if (TemCamposVazios(validaCamposCadClie) == false)
            {
                GetDataUpdate();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Verifica se a data alterada é valida
        public void GetDataUpdate()
        {
            string strDataNasc = txtDtNascFuncEdit.Text;
            int dia = Convert.ToInt32(strDataNasc.Substring(0, 2));
            int mes = Convert.ToInt32(strDataNasc.Substring(3, 2));
            int ano = Convert.ToInt32(strDataNasc.Substring(6, 4));
            try
            {
                DateTime dataNasc = new DateTime(ano, mes, dia);
                dataInvalida = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Data inválida");
                dataInvalida = false;
                return;
            }
        }

        //Converte a string da textbox em char pra mandar pro banco
        private void cbSexoFuncEdit_TextChanged(object sender, EventArgs e)
        {
            {
                if (cbSexoFuncEdit.Text == "Masculino")
                {
                    sexoSend = 'M';
                }
                else
                {
                    sexoSend = 'F';
                }
            }
        }

        //Muda o ponteiro do mouse
        private void btnCancelEdit_MouseEnter(object sender, EventArgs e)
        {
            btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelEdit.BackColor = Color.IndianRed;
        }
        private void btnCancelEdit_MouseLeave(object sender, EventArgs e)
        {
            btnCancelEdit.BackColor = Color.Gainsboro;
        }

        //Limpa os campos da tela de edicao 
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            ClearControl(this);
            tabControl1.SelectTab(tbEdit);
        }

        //Deleta um funcionario pelo nome cadastrado, primeiro verifica se nome esta branco ou existe,
        //depois confirma se realmete deseja deletar
        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            string nomeDelete = txtDelete.Text;

            if (nomeDelete != string.Empty)
            {  
                string sql = "SELECT * FROM cadFunc WHERE nome = '" + nomeDelete + "' ";

                SqlCommand comandoConsultaEdita = new SqlCommand(sql, conexao);

                conexao.Open();
                SqlDataReader dados = comandoConsultaEdita.ExecuteReader();

                var result = dados.Read();

                if(result != false)
                {
                    idFunc = (int)dados[0];
                    ConfirmaDelete = true;
                }
                else
                {
                    MessageBox.Show("Nome errado ou inexistente", "Erro de digitação no nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearControl(this);
                    tabControl1.SelectTab(tabDelete);
                }
                conexao.Close();
            }
            else
            {
                MessageBox.Show("Digite um nome", "Nome em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmaDelete = false;
            }
            if (ConfirmaDelete == true)    
            {
                try
                {
                    var yesno = MessageBox.Show("Você realmente quer deletar esse funcionário?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                    
                    if (yesno == DialogResult.Yes)
                    {
                        string sql = "DELETE from cadFunc WHERE nome = '" + nomeDelete + "' ";
                        
                        SqlCommand comandoDeleteFunc = new SqlCommand(sql, conexao);

                        conexao.Open();
                        comandoDeleteFunc.ExecuteNonQuery();

                        comandoDeleteFunc.Dispose();

                        MessageBox.Show("Deletado com sucesso!");
                        ClearControl(this);
                        tabControl1.SelectTab(tabDelete);
                            
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro inesperado\n" + exception.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        //Muda o ponteiro do mouse ao passar no botao
        private void btnExcluirFunc_MouseEnter(object sender, EventArgs e)
        {
            btnExcluirFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExcluirFunc.BackColor = Color.IndianRed;
        }
        private void btnExcluirFunc_MouseLeave(object sender, EventArgs e)
        {
            btnExcluirFunc.BackColor = Color.Gainsboro;
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
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }
                else if (c.HasChildren)
                {
                    if (c is TabControl)
                        ((TabControl)c).SelectedIndex = 1;

                    ClearControl(c);
                }
            }
        }
        //Preenchimento automatico para testes
        private void tbNewCad_DoubleClick(object sender, EventArgs e)
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
            txtTelFunc.Text = "1934075566";
            txtCelFunc.Text = "19994197566";
            txtEmailFunc.Text = "gustavo_allm@outlook.com";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                invocador.CarregarTelaInicial();
            }
        }
    }
}
