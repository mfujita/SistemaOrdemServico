using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SistemaOrdemServico
{
    public partial class Orcamento : Form
    {
        private readonly BancoDadosOrcamento bancoDados;
        private readonly Dictionary<string, Func<bool>> modos;
        private readonly List<Control> campos;

        private const string orcamentoTabela = "cadOrcamento";
        private Dictionary<string, string> camposValores;
        private IEnumerable<string> valoresSelecionados;


        public Orcamento()
        {
            InitializeComponent();

            bancoDados = new BancoDadosOrcamento();
            modos = new Dictionary<string, Func<bool>>
            {
                { "Inserir", Inserir },
                { "Editar", Editar },
                { "Excluir", Excluir }
            };
            campos = new List<Control>
            {
                cbClienteOrcamento,
                dtpDataEntradaOrcamento,
                txtDescricaoOrcamento,
                cbPecasOrcamento,
                nudValorOrcamento,
                cbRecebidoOrcamento
            };
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {
            dtpDataEntradaOrcamento.Value = DateTime.Today;
            var condicoesCliente = new Dictionary<string, string> { { "categoria", "Cliente" } };

            PopularComboBox(cbPecasOrcamento, bancoDados.Select("cadPeca", "codPeca", "nomePeca", "fabricante"));
            PopularComboBox(cbRecebidoOrcamento, bancoDados.Select("cadFunc", "idFunc", "nome"));
            PopularComboBox(cbClienteOrcamento, bancoDados.Select("cadClientForn", condicoesCliente, "AND", "idCad", "nomeRazSoc"));
        }

        private void MudarModo(object sender, EventArgs e)
        {
            var modoTexto = new Dictionary<string, string>
            {
                { "Inserir", "inserção" },
                { "Editar", "edição" },
                { "Excluir", "exclusão" }
            };

            var btnClicado = (sender as Button);
            campos.ForEach(campo => campo.Enabled = btnClicado.Text != "Excluir");
            btnLimpar.Visible = btnClicado.Text == "Inserir";
            btnEnviar.Text = btnClicado.Text;
            lblModo.Text = $"Modo de {modoTexto[btnClicado.Text]}";
            LimparCampos();

            string[] btnsChamarJanela = { "Editar", "Excluir" };
            if (btnsChamarJanela.Contains(btnClicado.Text))
            {
                using (var selecionarOrcamento = new SelecionarOrcamento())
                {
                    selecionarOrcamento.ShowDialog();

                    valoresSelecionados = selecionarOrcamento.ValoresSelecionados;

                    if (valoresSelecionados != null)
                    {
                        btnEnviar.Tag = valoresSelecionados.First();
                        valoresSelecionados = valoresSelecionados.Skip(1);
                        InserirValorCampos(valoresSelecionados);
                    }
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (modos[btnEnviar.Text]())
            {
                LimparCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void PopularComboBox(ComboBox comboBox, List<List<string>> itens)
        {
            var itensDicionario = itens.ToDictionary(
                keySelector: item => item[0],
                elementSelector: item => string.Join(" - ", item.Skip(1))
                );

            comboBox.ValueMember = "Key";
            comboBox.DisplayMember = "Value";
            comboBox.DataSource = new BindingSource(itensDicionario, null);
            comboBox.SelectedIndex = -1;
        }

        private bool Inserir()
        {
            CarregarValorCampos();

            if (!Form1.TemCamposVazios(camposValores) && ValidaComboBoxes())
            {
                Dictionary<string, string> dadosAEnviar = new Dictionary<string, string>();

                foreach (var campo in camposValores)
                {
                    dadosAEnviar.Add("@" + campo.Key.Split(' ')[0].Replace(":", ""), campo.Value);
                }

                bancoDados.Insert(orcamentoTabela, dadosAEnviar);

                return true;
            }

            return false;
        }

        private bool Editar()
        {
            CarregarValorCampos();

            if (btnEnviar.Tag.ToString() != string.Empty)
            {
                if (!Form1.TemCamposVazios(camposValores) && ValidaComboBoxes())
                {
                    var camposAtualizados = ObterValoresAtualizados();

                    if (camposAtualizados.Count > 0)
                    {
                        var condicoes = new Dictionary<string, string> { { "idOrc", btnEnviar.Tag.ToString() } };

                        bancoDados.Update(orcamentoTabela, camposAtualizados, condicoes);

                        return true;
                    }
                    else
                    {
                        Form1.MostrarMensagemErro("Nenhum valor modificado.");
                    }
                }
            }
            else
            {
                Form1.MostrarMensagemErro("Nenhum registro selecionado, clique no botão \"Editar\" novamente e selecione um registro.");
                return true;
            }

            return false;
        }

        private bool Excluir()
        {
            if (btnEnviar.Tag.ToString() != string.Empty)
            {
                var deleteDicionario = new Dictionary<string, string> { { "idOrc", btnEnviar.Tag.ToString() } };
                bancoDados.Delete(orcamentoTabela, deleteDicionario);
            }
            else
            {
                Form1.MostrarMensagemErro("Nenhum registro selecionado, clique no botão \"Excluir\" novamente e selecione um registro.");
            }

            return true;
        }

        private void CarregarValorCampos()
        {
            camposValores = new Dictionary<string, string>{
                { lblClienteOrcamento.Text, cbClienteOrcamento.Text },
                { lblDataEntradaOrcamento.Text, dtpDataEntradaOrcamento.Value.Date.ToString("yyyy-MM-dd") },
                { lblDescricaoOrcamento.Text, txtDescricaoOrcamento.Text },
                { lblPecasOrcamento.Text, cbPecasOrcamento.Text },
                { lblValorOrcamento.Text, nudValorOrcamento.Text == "0,00" ? string.Empty : nudValorOrcamento.Text.Replace(",", ".") },
                { lblRecebidoOrcamento.Text, cbRecebidoOrcamento.Text }
            };
        }

        private void InserirValorCampos(IEnumerable<string> valores)
        {
            var campos = new List<Action<string>>()
            {
                (valor) => { cbClienteOrcamento.SelectedValue = valor; },
                (valor) => { dtpDataEntradaOrcamento.Value = DateTime.Parse(valor); },
                (valor) => { txtDescricaoOrcamento.Text = valor; },
                (valor) => { cbPecasOrcamento.SelectedValue = valor; },
                (valor) => { nudValorOrcamento.Value = Convert.ToDecimal(valor); },
                (valor) => { cbRecebidoOrcamento.SelectedValue = valor; },                
            };

            foreach (var _ in campos.Zip(valores, (campo, valor) => { campo(valor); return true; }) );
        }

        private bool ValidaComboBoxes()
        {
            var comboBoxes = new Dictionary<string, ComboBox>
            {
                { lblClienteOrcamento.Text, cbClienteOrcamento },
                { lblPecasOrcamento.Text, cbPecasOrcamento },
                { lblRecebidoOrcamento.Text, cbRecebidoOrcamento }
            };

            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.Value.SelectedIndex != -1)
                {
                    var itemSelecionado = (KeyValuePair<string, string>)comboBox.Value.SelectedItem;

                    camposValores[comboBox.Key] = itemSelecionado.Key;
                }
                else
                {
                    Form1.MostrarMensagemErro($"Selecione um valor valido no campo \"{comboBox.Key.Replace(":", "")}\"");
                    return false;
                }
            }

            return true;
        }

        private Dictionary<string, string> ObterValoresAtualizados()
        {
            var atualizacoes = new Dictionary<string, string>();
            var colunasBanco = bancoDados.ObterColunas(orcamentoTabela).Skip(1).ToArray();
            var valoresAntigos = valoresSelecionados.ToArray();
            var valoresNovos = camposValores.Values.ToArray();

            for (int i = 0; i < colunasBanco.Length; i++)
            {
                valoresAntigos[i] = AjustaValores(valoresAntigos[i]);

                if (valoresAntigos[i] != valoresNovos[i])
                {
                    atualizacoes.Add(colunasBanco[i], valoresNovos[i]);
                }
            }

            return atualizacoes;
        }

        public string AjustaValores(string valor)
        {
            if (DateTime.TryParseExact(valor, CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern,
                                       null, DateTimeStyles.None, out var data))
            {
                valor = data.ToString("yyyy-MM-dd");
            }
            if (valor.Contains(",") && float.TryParse(valor, out var _))
            {
                valor = valor.Replace(",", ".");
            }

            return valor;
        }

        private void LimparCampos()
        {
            foreach (var campo in campos)
            {
                if (campo is ComboBox)
                {
                    (campo as ComboBox).SelectedIndex = -1;
                    campo.Text = string.Empty;
                }
                else if (campo is DateTimePicker)
                {
                    (campo as DateTimePicker).Value = DateTime.Today;
                }
                else if (campo is TextBox)
                {
                    campo.Text = string.Empty;
                }
                else if (campo is NumericUpDown)
                {
                    (campo as NumericUpDown).Value = 0;
                }
            }

            btnEnviar.Tag = string.Empty;
            valoresSelecionados = null;
        }
    }
}
