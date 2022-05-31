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
    public partial class SelecionarOrcamento : Form
    {
        private readonly SqlConnection conexaoSql;
        private readonly Orcamento orcamento;
        public IEnumerable<string> Valores { get; private set; }


        public SelecionarOrcamento(SqlConnection conexao)
        {
            conexaoSql = conexao;
            orcamento = new Orcamento();

            InitializeComponent();
        }

        private void CarregarColunas()
        {
            List<string> colunasBanco = orcamento.ObterColunasOrcamento();
            List<string> colunasExibidas = new List<string>()
            {
                "ID", "Cliente", "Data de entrada", "Descrição", "Peças", "Valor do serviço", "Recebido por"
            };

            foreach (var _ in colunasBanco.Zip(colunasExibidas, dgResultados.Columns.Add)) ;
        }

        private void SelecionarOrcamento_Load(object sender, EventArgs e)
        {
            CarregarColunas();

            if (dgResultados.Columns.Count > 0)
            {
                var registros = orcamento.SqlSelect("cadOrcamento", "*");
                registros.ForEach(registro => dgResultados.Rows.Add(registro.ToArray()));
            }
        }

        private void dgResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EnviarParaFormulario();
            }

        }

        private void dgResultados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarParaFormulario();
                e.Handled = true;
            }
        }

        private void EnviarParaFormulario()
        {
            Valores = dgResultados.SelectedCells.Cast<DataGridViewCell>()
                     .Select(cell => cell.Value.ToString());
            Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            //Procurar nos elementos dentro do datagrid usando o campo especificado pelo combo box
        }
    }
}
