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
    public partial class SelecionarOrcamento : Form
    {
        public SelecionarOrcamento()
        {
            InitializeComponent();
        }

        private void SelecionarOrcamento_Load(object sender, EventArgs e)
        {
            //Código Temporário
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 100; i++)
            {
                dgResultados.Rows.Add($"Teste{i}", i, i/100F, alfabeto[i%alfabeto.Length], Math.Pow(i, 2));
            }
            //Dar select em todos elementos da tabela Orçamento
        }

        private void dgResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Código Temporário
            if(e.RowIndex >= 0)
            {
                var values = dgResultados.Rows[e.RowIndex].Cells
                    .Cast<DataGridViewCell>()
                    .Select(cell => cell.Value);

                MessageBox.Show(string.Join(", ", values));
            }

            //Enviar valores para o formulário Orçamento
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            //Procurar nos elementos dentro do datagrid usando o campo especificado pelo combo box
        }
    }
}
