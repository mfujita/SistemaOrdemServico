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
        private readonly Orcamento orcamento;
        private Dictionary<string, string> clientes;
        private Dictionary<string, string> pecas;
        private Dictionary<string, string> funcionarios;
        private Dictionary<string, List<string>> orcamentosValue;
        public IEnumerable<string> ValoresSelecionados { get; private set; }


        public SelecionarOrcamento()
        {
            InitializeComponent();

            orcamento = new Orcamento();

            var condicoesCliente = new Dictionary<string, string> { { "categoria", "Cliente" } };
            clientes = CriarDicionario(orcamento.SqlSelect("cadClientForn", condicoesCliente, "AND", "idCad", "nomeRazSoc"));
            pecas = CriarDicionario(orcamento.SqlSelect("cadPeca", "codPeca", "nomePeca", "fabricante"));
            funcionarios = CriarDicionario(orcamento.SqlSelect("cadFunc", "idFunc", "nome"));
        }

        private void SelecionarOrcamento_Load(object sender, EventArgs e)
        {
            var registros = orcamento.SqlSelect("cadOrcamento", "*");

            orcamentosValue = registros.ToDictionary(
                keySelector: item => item.First(),
                elementSelector: item => new List<string>(item)
                );

            foreach (var registro in registros)
            {
                registro[1] = clientes[registro[1]];
                registro[4] = pecas[registro[4]];
                registro[6] = funcionarios[registro[6]]; 
            }

            registros.ForEach(registro => dgResultados.Rows.Add(registro.ToArray()));
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

        private Dictionary<string, string> CriarDicionario(List<List<string>> dados)
        {
            return dados.ToDictionary(
                keySelector: item => item[0],
                elementSelector: item => string.Join(" - ", item.Skip(1))
                );
        }
        private void EnviarParaFormulario()
        {
            ValoresSelecionados = orcamentosValue[dgResultados.SelectedCells[0].Value.ToString()];
            Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            //Procurar nos elementos dentro do datagrid usando o campo especificado pelo combo box
        }
    }
}
