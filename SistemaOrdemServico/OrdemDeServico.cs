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
            //tb_ID.Text = tb_ID.Text;
            mtb_Id.Text = mtb_Id.Text;
            //tb_DataSaida.Text = tb_DataSaida.Text;
            dtp_Saida.Text = dtp_Saida.Text;
            //tb_Garantia.Text = tb_Garantia.Text;
            dtp_Garantia.Text = dtp_Garantia.Text;
            tb_RespServico.Text = tb_RespServico.Text;

            if (mtb_Id.Text == string.Empty || dtp_Saida.Text == string.Empty ||
            dtp_Garantia.Text == string.Empty || tb_RespServico.Text == string.Empty)
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
            //tb_ID.Clear();
            mtb_Id.Clear();
            tb_RespServico.Clear();
            //tb_ID.Focus();
            mtb_Id.Focus();
        }

    }
}

