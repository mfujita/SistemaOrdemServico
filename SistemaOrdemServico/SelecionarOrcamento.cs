using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SistemaOrdemServico
{
    public partial class SelecionarOrcamento : Form
    {
        public IEnumerable<string> ValoresSelecionados { get; private set; }

        private readonly BancoDadosOrcamento bancoDados;
        private readonly Dictionary<string, string> clientes;
        private readonly Dictionary<string, string> pecas;
        private readonly Dictionary<string, string> funcionarios;
        private Dictionary<string, List<string>> orcamentosValue;
        private List<List<string>> registros;


        public SelecionarOrcamento()
        {
            InitializeComponent();

            bancoDados = new BancoDadosOrcamento();

            var condicoesCliente = new Dictionary<string, string> { { "categoria", "Cliente" } };
            clientes = CriarDicionario(bancoDados.Select("cadClientForn", condicoesCliente, "AND", "idCad", "nomeRazSoc"));
            pecas = CriarDicionario(bancoDados.Select("cadPeca", "codPeca", "nomePeca", "fabricante"));
            funcionarios = CriarDicionario(bancoDados.Select("cadFunc", "idFunc", "nome"));
        }

        private void SelecionarOrcamento_Load(object sender, EventArgs e)
        {
            CarregarColunas();

            var colunas = dgResultados.Columns.Cast<DataGridViewColumn>().Select(coluna => coluna.HeaderText);
            PopularComboBox(cbCampo, colunas.ToList());

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

        public void PopularComboBox(ComboBox comboBox, List<string> itens)
        {
            comboBox.DataSource = itens;
            comboBox.SelectedIndex = -1;
        }

        private void CarregarColunas()
        {
            registros = bancoDados.Select("cadOrcamento", "*");

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
