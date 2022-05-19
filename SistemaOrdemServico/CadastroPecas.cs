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
            string cadastroFornecedorPeca = txtFornecedorCadastrarPeca.Text;
            string cadastroFabricantePeca = txtFabricanteCadastrarPeca.Text;
            string cadastroValorCompra = txtValorCompraCadastrarPeca.Text;
            string cadastroValorVenda = txtValorVendaCadastrarPeca.Text;

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

                /*string sql = "INSERT INTO  nomeTabela VALUES ( '"+cadastroNomePeca+"'," +
                    "'"+cadastroFornecedorPeca+"'," +
                    "'"+cadastroFabricantePeca+"'," +
                    ""+Convert.ToDouble(cadastroValorCompra)+"," +
                    ""+Convert.ToDouble(cadastroValorVenda)+")";*/

            }


        }
    }
}
