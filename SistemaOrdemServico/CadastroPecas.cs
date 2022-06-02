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
    public partial class CadastroPecas : Form
    {
        string sql;

        public CadastroPecas()
        {
            InitializeComponent();
            bloquearCamposEditar();
        }




        /*
            Conexao com banco de dados
         */
        public SqlConnection abreConexao()
        {
            string conexao = @"Server= DESKTOP-U3P4RMT\SQLEXPRESS;
                            Database=OSFujita;
                            User Id=sa;
                            Password=1234;";
            return new SqlConnection(conexao);
        }








        /*
            Prencher Combobox Cadastro de peças
         */
        private void preencherComboBoxCadastrar()
        {
            SqlConnection conexao = abreConexao();

            try
            {
                conexao.Open();

                sql = "SELECT * FROM cadClientForn WHERE categoria = 'Empresa'";

                SqlCommand comando = new SqlCommand(sql, conexao);

                SqlDataReader dados = comando.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dados);


                //Combobox Cadastrar Peca
                cboxFornecedorCadastrarPeca.DisplayMember = "nomeRazSoc";

                cboxFornecedorCadastrarPeca.ValueMember = "codPeca";

                cboxFornecedorCadastrarPeca.DataSource = dt;

                cboxFornecedorCadastrarPeca.Text = "Selecionar";

            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                conexao.Close();
            }

        }






        /*
            Preencher Combobox de Editar  Peca
         */
        private void preencherComboBoxEditar()
        {
            SqlConnection conexao = abreConexao();

            try
            {
                conexao.Open();

                sql = "SELECT * FROM cadClientForn WHERE categoria = 'Empresa'";

                SqlCommand comando = new SqlCommand(sql, conexao);

                SqlDataReader dados = comando.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dados);


                //Combobox Editar peca
                cboxFornecedorEditarPeca.DisplayMember = "nomeRazSoc";

                cboxFornecedorEditarPeca.ValueMember = "codPeca";

                cboxFornecedorEditarPeca.DataSource = dt;

                cboxFornecedorEditarPeca.Text = "Selecionar";

            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                conexao.Close();
            }

        }







        /*
           Metodo para Salvar no Banco de dados
        */
        private void btnSalvarPeca_Click(object sender, EventArgs e)
        {

            //Declarações das variaveis do input text
            string cadastroNomePeca = txtNomeCadastrarPeca.Text;
            string cadastroFornecedorPeca = cboxFornecedorCadastrarPeca.Text;
            string cadastroFabricantePeca = txtFabricanteCadastrarPeca.Text;
            string cadastroValorCompra = txtCadastroValorCompraPeca.Text;
            string cadastroValorVenda = numericValorVendaCadastrarPeca.Text;


            //Validaçao do formulario 
            if (cadastroNomePeca == string.Empty ||
                cadastroFornecedorPeca == "Selecionar" ||
                cadastroFabricantePeca == string.Empty ||
                cadastroValorCompra == string.Empty ||
                cadastroValorVenda == string.Empty)
            {
                MessageBox.Show("Veja se todos os campos estão\n preenchidos corretamente");
            }
            else
            {

                SqlConnection conexao = abreConexao();
                sql = "SELECT idCad FROM cadClientForn where nomeRazSoc = '" + cboxFornecedorCadastrarPeca.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, conexao);
                conexao.Open();
                int idFornecedorPeca = (int)cmd.ExecuteScalar();


                try
                {
                    conexao = abreConexao();

                    sql = "INSERT INTO cadPeca VALUES ( '" + cadastroNomePeca + "'," +
                        "'" + idFornecedorPeca + "'," +
                        "'" + cadastroFabricantePeca + "'," +
                        "" + Convert.ToDecimal(cadastroValorCompra.Replace(",", ".")) + "," +
                        "" + Convert.ToDecimal(cadastroValorVenda.Replace(",", ".")) + ")";

                    SqlCommand comandCadastro = new SqlCommand(sql, conexao);
                    conexao.Open();

                    comandCadastro.ExecuteNonQuery();

                    comandCadastro.Dispose();

                    conexao.Close();

                    MessageBox.Show("Salvo com sucesso");

                    txtNomeCadastrarPeca.Text = string.Empty;
                    txtCadastroValorCompraPeca.Text = string.Empty;
                    cboxFornecedorCadastrarPeca.Text = "Selecionar";
                    txtFabricanteCadastrarPeca.Text = string.Empty;
                    numericValorVendaCadastrarPeca.Text = string.Empty;

                    dgvPecas.Rows.Clear();
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao salvar dados");
                }
            }
        }







        /*
             Metodo para deletar no banco de dados
         */
        private void buttonDeletarPeca_Click(object sender, EventArgs e)
        {
            string idDelete = txtIdDeletarPeca.Text;

            if (idDelete == string.Empty)
            {
                MessageBox.Show("Insira o Id da peça para deletar");
            }
            else
            {
                SqlConnection conexao = abreConexao();

                sql = "DELETE FROM cadPeca WHERE codPeca = " + Convert.ToInt32(idDelete) + "";

                SqlCommand comandoDelete = new SqlCommand(sql, conexao);

                conexao.Open();
                comandoDelete.ExecuteNonQuery();

                comandoDelete.Dispose();
                conexao.Close();

                MessageBox.Show("Peça deletada com exito");

                txtIdDeletarPeca.Text = string.Empty;

                dgvPecas.Rows.Clear();
            }
        }






        /*
            Botao de consulta para listagem do data grid view
         */
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvPecas.Rows.Clear();
            listagem();

        }





        /*
            Listagem para dar select
         */
        private void listagem()
        {
            SqlConnection conexao = abreConexao();


            //sql = "SELECT * FROM cadPeca";
            sql = "select cP.codPeca, cP.nomePeca, cCF.nomeRazSoc, cP.fabricante, cP.vlCompra, cP.vlVenda from cadPeca cP, cadClientForn cCF where cCF.categoria = 'Empresa' and cP.fkFornecedor = cCF.idCad";

            SqlCommand comandoConsulta = new SqlCommand(sql, conexao);

            conexao.Open();
            SqlDataReader dados = comandoConsulta.ExecuteReader();

            comandoConsulta.Dispose();

            while (dados.Read())
            {
                dgvPecas.Rows.Add($"#{dados[0]}", dados[1], dados[2], dados[3], dados[4], dados[5]);
            }

            conexao.Close();

        }






        /*
            Metodo que preenche o Combobox de 
            Cadastro de peça ao iniciar o form
         */
        private void CadastroPecas_Shown(object sender, EventArgs e)
        {
            cboxFornecedorEditarPeca.Text = "Selecionar";
            preencherComboBoxCadastrar();

        }







        /*
            Botao de pesquisa pelo ID selecionado
            na area de editar Peça
         */
        private void btnConsultaEditaPeca_Click(object sender, EventArgs e)
        {

            string idConsutarPeca = txtIdEditarPeca.Text;

            txtNomeEditarPeca.Text = string.Empty;
            txtFabricanteEditarPeca.Text = string.Empty;
            numericValorCompraEditar.Text = string.Empty;
            txtValorVendaEditarPeca.Text = string.Empty;


            if (idConsutarPeca == string.Empty)
            {
                MessageBox.Show("Digite um id");
            }
            else
            {
                cboxFornecedorEditarPeca.Enabled = true;
                txtNomeEditarPeca.Enabled = true;
                txtFabricanteEditarPeca.Enabled = true;
                txtValorVendaEditarPeca.Enabled = true;
                numericValorCompraEditar.Enabled = true;
                buttonEditarPeca.Enabled = true;

                preencherComboBoxEditar();


                try
                {
                    txtIdEditarPeca.Enabled = false;

                    //Preenchendo o s input text da area de editar Peça
                    SqlConnection conexao = abreConexao();

                    sql = "SELECT * FROM cadPeca WHERE codPeca = " + idConsutarPeca + " ";

                    SqlCommand comandoConsultaEdita = new SqlCommand(sql, conexao);

                    conexao.Open();
                    SqlDataReader dados = comandoConsultaEdita.ExecuteReader();

                    dados.Read();



                    double valorCompraEditarPeca = Convert.ToDouble(dados[4]);
                    double valorVendaEditarPeca = Convert.ToDouble(dados[5]);


                    txtNomeEditarPeca.Text = (string)dados[1];

                    txtFabricanteEditarPeca.Text = (string)dados[3];
                    numericValorCompraEditar.Text = valorCompraEditarPeca.ToString();
                    txtValorVendaEditarPeca.Text = valorVendaEditarPeca.ToString();


                    comandoConsultaEdita.Dispose();

                    conexao.Close();


                    //Selecionando qual fornecedor pertence a peça no Combobox

                    string sqlCBoxEditaPeca = "SELECT nomeRazSoc  FROM cadClientForn, cadPeca where idCad = fkFornecedor AND codPeca = " + idConsutarPeca + "";

                    SqlCommand comandoEmpresaCBox = new SqlCommand(sqlCBoxEditaPeca, conexao);

                    conexao.Open();

                    SqlDataReader dadosCbox = comandoEmpresaCBox.ExecuteReader();

                    dadosCbox.Read();

                    cboxFornecedorEditarPeca.Text = (string)dadosCbox[0];

                    comandoEmpresaCBox.Dispose();

                    conexao.Close();


                }
                catch (Exception)
                {
                    bloquearCamposEditar();
                    txtIdEditarPeca.Enabled = true;
                    MessageBox.Show("Id não encontrado");
                    txtIdEditarPeca.Text = "";

                }

            }

        }







        /*
            Metodo para atualizar um cadastro de peça
         */
        private void buttonEditarPeca_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = abreConexao();

            if (txtIdEditarPeca.Text == string.Empty ||
                txtNomeEditarPeca.Text == string.Empty ||
                cboxFornecedorEditarPeca.Text == "Selecionar" ||
                txtFabricanteEditarPeca.Text == string.Empty ||
                numericValorCompraEditar.Text == string.Empty ||
                txtValorVendaEditarPeca.Text == string.Empty)
            {
                MessageBox.Show("Veja se todos os campos estão preenchidos corretamente");
            }
            else
            {

                conexao = abreConexao();
                sql = "SELECT idCad FROM cadClientForn where nomeRazSoc = '" + cboxFornecedorEditarPeca.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, conexao);
                conexao.Open();
                int idFornecedorEditarPeca = (int)cmd.ExecuteScalar();

                //Variaveis
                string idEdiatarPeca = txtIdEditarPeca.Text;
                string nomeEditarPeca = txtNomeEditarPeca.Text;
                string fabricanteEditarPeca = txtFabricanteEditarPeca.Text;
                string valorCompraEditarPeca = numericValorCompraEditar.Text;
                string valorVendaEditarPeca = txtValorVendaEditarPeca.Text;

                try
                {
                    conexao = abreConexao();

                    sql = "UPDATE cadPeca SET nomePeca = '" + nomeEditarPeca + "', fkFornecedor = " + idFornecedorEditarPeca + ", fabricante = '" + fabricanteEditarPeca + "', vlCompra = " + Convert.ToDouble(valorCompraEditarPeca) + ", vlVenda = " + Convert.ToDouble(valorVendaEditarPeca) + " WHERE codPeca = " + Convert.ToInt32(idEdiatarPeca) + "";

                    SqlCommand comandoEditar = new SqlCommand(sql, conexao);
                    conexao.Open();
                    comandoEditar.ExecuteNonQuery();

                    comandoEditar.Dispose();
                    conexao.Close();

                    MessageBox.Show("Atualizado com sucesso");


                    txtIdEditarPeca.Text = string.Empty;
                    txtNomeEditarPeca.Text = string.Empty;
                    txtFabricanteEditarPeca.Text = string.Empty;
                    numericValorCompraEditar.Text = string.Empty;
                    txtValorVendaEditarPeca.Text = string.Empty;
                    txtIdEditarPeca.Enabled = true;

                    cboxFornecedorEditarPeca.Text = "Selecionar";
                    bloquearCamposEditar();

                    dgvPecas.Rows.Clear();
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar");

                    cboxFornecedorEditarPeca.Enabled = true;
                }
                finally
                {
                    conexao.Close();


                }

            }

        }





        /*
            Bloqueando escrita no Cobobox  
         */
        private void cboxFornecedorCadastrarPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboxFornecedorEditarPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void bloquearCamposEditar()
        {
            txtNomeEditarPeca.Enabled = false;
            txtFabricanteEditarPeca.Enabled = false;
            txtValorVendaEditarPeca.Enabled = false;
            numericValorCompraEditar.Enabled = false;
            buttonEditarPeca.Enabled = false;
            cboxFornecedorEditarPeca.Enabled = false;
        }

        private void btnCancelarEdicao_Click(object sender, EventArgs e)
        {
            txtNomeEditarPeca.Text = "";
            txtFabricanteEditarPeca.Text = "";
            txtValorVendaEditarPeca.Text = "";
            numericValorCompraEditar.Text = "";
            buttonEditarPeca.Enabled = false;
            cboxFornecedorEditarPeca.Text = "Selecionar";
            bloquearCamposEditar();

            txtIdEditarPeca.Text = "";
            txtIdEditarPeca.Enabled = true;
        }
    }
}