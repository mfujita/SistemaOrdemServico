using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrdemServico
{
    public partial class SelecionarOrcamento : Form
    {
        private readonly Orcamento orcamento;
        private readonly Dictionary<string, string> clientes;
        private readonly Dictionary<string, string> pecas;
        private readonly Dictionary<string, string> funcionarios;
        private Dictionary<string, List<string>> orcamentosValue;
        private List<List<string>> registros;
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
            CarregarColunas();

            var colunas = dgResultados.Columns.Cast<DataGridViewColumn>().Select(coluna => coluna.HeaderText);
            orcamento.PopularComboBox(cbCampo, colunas.ToList());

            dgResultados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9);
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
            else if (e.KeyCode == Keys.Tab)
            {
                var proximaLinha = dgResultados.SelectedRows[0].Index + 1;
                if (dgResultados.RowCount > proximaLinha)
                {
                    dgResultados.Rows[proximaLinha].Selected = true;
                }
                e.Handled = true;
            }
        }

        private void dgResultados_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgResultados.Cursor = Cursors.Hand;
        }

        private void dgResultados_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgResultados.Cursor = Cursors.Default;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            dgResultados.Rows.Clear();

            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;
            var compareOptions = CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase;

            var registrosFiltrados = registros.Where(registro => compareInfo.IndexOf(
                registro[cbCampo.SelectedIndex], txtValor.Text, compareOptions) != -1
                );

            PopularDataGrid(registrosFiltrados);
        }

        private void cbCampo_DropDownClosed(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex != -1)
            {
                txtValor.Enabled = true;
                txtValor.Text = string.Empty;
            }
        }

        private Dictionary<string, string> CriarDicionario(List<List<string>> dados)
        {
            return dados.ToDictionary(
                keySelector: item => item[0],
                elementSelector: item => string.Join(" - ", item.Skip(1))
                );
        }

        private void CarregarColunas()
        {
            registros = orcamento.SqlSelect("cadOrcamento", "*");

            orcamentosValue = registros.ToDictionary(
                keySelector: item => item[0],
                elementSelector: item => new List<string>(item)
                );

            foreach (var registro in registros)
            {
                registro[1] = clientes[registro[1]];
                registro[4] = pecas[registro[4]];
                registro[6] = funcionarios[registro[6]];
            }

            PopularDataGrid(registros);
        }

        private void PopularDataGrid(IEnumerable<List<string>> linhas)
        {
            foreach (var linha in linhas)
            {
                dgResultados.Rows.Add(linha.ToArray());
            }
            if (dgResultados.Rows.Count > 0)
            {
                dgResultados.Rows[0].Selected = false;
            }
        }

        private void EnviarParaFormulario()
        {
            ValoresSelecionados = orcamentosValue[dgResultados.SelectedCells[0].Value.ToString()];
            Close();
        }
    }
}
