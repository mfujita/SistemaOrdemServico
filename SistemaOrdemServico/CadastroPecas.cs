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
        }


        //Conexao com banco de dados
        public SqlConnection abreConexao()
        {
            string conexao = @"Server=DESKTOP-U3P4RMT\SQLEXPRESS;
                            Database=OSFujita;
                            User Id=sa;
                            Password=1234;";
            return new SqlConnection(conexao);
        }



        //Prencher Combobox
        private void preencherComboBox ()
        {
            SqlConnection conexao = abreConexao();

            try
            {
                conexao.Open();

                sql = "SELECT * FROM cadClientForn WHERE categoria = 'Fornecedor'";

                SqlCommand comando = new SqlCommand(sql, conexao);

                SqlDataReader dados = comando.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dados);

                
                //Combobox Cadastrar Peca
                cboxFornecedorCadastrarPeca.DisplayMember = "idCad";

                cboxFornecedorCadastrarPeca.ValueMember = "cpfCnpj";

                cboxFornecedorCadastrarPeca.DataSource = dt;

                //Combobox Editar peca
                cboxFornecedorEditarPeca.DisplayMember = "nomeRazSoc";

                cboxFornecedorEditarPeca.ValueMember = "idCad";

                cboxFornecedorEditarPeca.DataSource = dt;

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





        //Metodo para gravar no bando
        private void btnSalvarPeca_Click(object sender, EventArgs e)
        {
            //Declarações das variaveis do input text

            string cadastroNomePeca = txtNomeCadastrarPeca.Text;
            string cadastroFornecedorPeca = cboxFornecedorCadastrarPeca.Text;
            string cadastroFabricantePeca = txtFabricanteCadastrarPeca.Text;
            string cadastroValorCompra = numericValorCompraCadastrarPeca.Text;
            string cadastroValorVenda = numericValorVendaCadastrarPeca.Text;

            //Validaçao do formulario 
            if( cadastroNomePeca == string.Empty || 
                cadastroFornecedorPeca == string.Empty || 
                cadastroFabricantePeca == string.Empty ||
                cadastroValorCompra == string.Empty ||
                cadastroValorVenda == string.Empty)
            {
                MessageBox.Show("Campo precisa ser preenchido");
            }
            else
            {
                //Area do banco de dados
                SqlConnection conexao = abreConexao();

                sql = "INSERT INTO cadPeca VALUES ( '"+cadastroNomePeca+"'," +
                    "'"+Convert.ToInt32(cadastroFornecedorPeca) +"'," +
                    "'"+cadastroFabricantePeca+"'," +
                    ""+Convert.ToDouble(cadastroValorCompra.Replace(",","."))+"," +
                    ""+Convert.ToDouble(cadastroValorVenda.Replace(",","."))+")";

                SqlCommand comandCadastro = new SqlCommand(sql, conexao);
                conexao.Open();

                comandCadastro.ExecuteNonQuery();

                comandCadastro.Dispose();

                conexao.Close();

            }


        }


        //Area de deletar a peça
        private void buttonDeletarPeca_Click(object sender, EventArgs e)
        {
            string idDelete = txtIdDeletarPeca.Text;

            if ( idDelete == string.Empty )
            {
                MessageBox.Show("Insira o Id da peça para deletar");
            }
            else
            {
                // sql = "DELETE FROM 'cadastropeca' WHERE ID = " + Convert.ToInt32( idDelete) + "";

                /*SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();

                comando.Dispose();
                conexao.Close();*/
            }
        }




        //Botao de consulta
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            listagem();
            btnConsultar.Enabled = false;

 
        }

        //Listagem para dar select
        private void listagem()
        {


             sql = "SELECT * FROM 'nome da tabela'";

            /*SqlCommand comando = new SqlCommand(sql, conexao);

            conexao.Open();
            SqlDataReader dados = comando.ExecuteReader();

            comando.Dispose();

            while (dados.Read())
            {
                dgvPecas.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5]);
            }

            conexao.Close();*/

        }



        private void CadastroPecas_Shown(object sender, EventArgs e)
        {
            preencherComboBox();
           
        }
    }
}
