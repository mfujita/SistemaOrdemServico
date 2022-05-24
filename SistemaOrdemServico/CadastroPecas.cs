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
    public partial class CadastroPecas : Form
    {
        public CadastroPecas()
        {
            InitializeComponent();
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

                string sql = "INSERT INTO  'nomeTabela' VALUES ( '"+cadastroNomePeca+"'," +
                    "'"+cadastroFornecedorPeca+"'," +
                    "'"+cadastroFabricantePeca+"'," +
                    ""+Convert.ToDouble(cadastroValorCompra.Replace(",","."))+"," +
                    ""+Convert.ToDouble(cadastroValorVenda.Replace(",","."))+")";

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
                //string sql = "DELETE FROM 'cadastropeca' WHERE ID = " + Convert.ToInt32( idDelete) + "";

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


            string sql = "SELECT * FROM 'nome da tabela'";

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

    }
}
