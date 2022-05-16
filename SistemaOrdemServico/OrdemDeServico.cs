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
    public partial class OrdemDeServico : Form
    {
        public OrdemDeServico()
        {
            InitializeComponent();
        }
        private void btn_Salvar_Click_1(object sender, EventArgs e)
        {
            tb_ID.Text = tb_ID.Text;
            tb_DataSaida.Text = tb_DataSaida.Text;
            tb_Garantia.Text = tb_Garantia.Text;
            tb_RespServico.Text = tb_RespServico.Text;

            if (tb_ID.Text == string.Empty || tb_DataSaida.Text == string.Empty ||
            tb_Garantia.Text == string.Empty || tb_RespServico.Text == string.Empty)
            {
                MessageBox.Show("Campos obrigatórios não preenchidos");
            }
            else
            {
                MessageBox.Show("Campos Preenchido, enviando informações. Obrigado!!");
            }
        }

        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            tb_ID.Clear();
            tb_DataSaida.Clear();
            tb_RespServico.Clear();
            tb_Garantia.Clear();
            tb_ID.Focus();
        }
    }
}

