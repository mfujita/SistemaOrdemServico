﻿using System;
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
    public partial class Orcamento : Form
    {
        private readonly SqlConnection conexaoSql;
        private readonly Dictionary<string, Func<bool>> modos;
        private Dictionary<string, string> camposDeEntrada;
        private readonly List<Control> campos;
        private static string orcamentoTabela = "cadOrcamento";
        private IEnumerable<string> valoresSelecionados;


        public Orcamento()
        {
            InitializeComponent();

            conexaoSql = new SqlConnection(Form1.GetStringConecao("GustavoDanielCasa"));
            //conexaoSql = new SqlConnection(Form1.GetStringConecao("GustavoDanielFaculdade"));
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

        private bool Inserir()
        {
            CarregarValorCampos();

            if (!Form1.TemCamposVazios(camposDeEntrada) && ValidaComboBoxes())
            {
                Dictionary<string, string> dadosAEnviar = new Dictionary<string, string>();

                foreach (var campo in camposDeEntrada)
                {
                    dadosAEnviar.Add("@" + campo.Key.Split(' ')[0].Replace(":", ""), campo.Value);
                }

                SqlInsert(orcamentoTabela, dadosAEnviar);

                return true;
            }

            return false;
        }

        private bool Editar()
        {
            CarregarValorCampos();

            if (!Form1.TemCamposVazios(camposDeEntrada) && ValidaComboBoxes())
            {
                var camposAtualizados = ObterValoresAtualizados();

                if (camposAtualizados.Count > 0)
                {
                    var condicoes = new Dictionary<string, string> { { "idOrc", btnEnviar.Tag.ToString() } };

                    SqlUpdate(orcamentoTabela, camposAtualizados, condicoes);

                    return true;
                }
                else
                {
                    MostrarMensagemErro("Nenhum valor modificado.");
                }
            }

            return false;
        }

        private bool Excluir()
        {
            var deleteDicionario = new Dictionary<string, string> { { "idOrc", btnEnviar.Tag.ToString() } }; 
            SqlDelete(orcamentoTabela, deleteDicionario);

            return true;
        }

        private void CarregarValorCampos()
        {
            camposDeEntrada = new Dictionary<string, string>{
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

        public List<List<string>> SqlSelect(string tabela, params string[] colunas)
        {
            string comandoString = $"SELECT {string.Join(", ", colunas)} from {tabela}";

            return SqlSelect(comandoString);
        }
        public List<List<string>> SqlSelect(string tabela, Dictionary<string, string> condicoes, string operacao, params string[] colunas)
        {
            string comandoString = $"SELECT {string.Join(", ", colunas)} from {tabela}" +
                $" WHERE {string.Join($" {operacao} ", condicoes.Select(condicao => $"{condicao.Key} = '{condicao.Value}'"))}";

            return SqlSelect(comandoString);
        }

        private List<List<string>> SqlSelect(string comandoString)
        {
            List<List<string>> registros = new List<List<string>>();

            SqlCommand comandoSql = new SqlCommand(comandoString, conexaoSql);

            try
            {
                comandoSql.Connection.Open();
                SqlDataReader leitor = comandoSql.ExecuteReader();

                while (leitor.Read())
                {
                    List<string> campos = new List<string>();

                    for (int i = 0; i < leitor.FieldCount; i++)
                    {
                        campos.Add(leitor[i].GetType() != typeof(DateTime) ? leitor[i].ToString() : ((DateTime)leitor[i]).ToShortDateString());
                    }

                    registros.Add(campos);
                }
            }
            catch (Exception ex)
            {
                MostrarMensagemErro(ex.Message);
            }
            finally
            {
                comandoSql.Connection.Close();
                comandoSql.Dispose();
            }

            return registros;
        }

        private void SqlInsert(string tabela, Dictionary<string, string> campos)
        {
            string comandoString = $"INSERT INTO {tabela} VALUES({ string.Join(", ", campos.Select(campo => campo.Key))})";
            SqlCommand comandoSql = new SqlCommand(comandoString, conexaoSql);
            foreach (var campo in campos) { comandoSql.Parameters.AddWithValue(campo.Key, campo.Value); }

            try
            {
                comandoSql.Connection.Open();
                comandoSql.ExecuteNonQuery();

                MostrarMensagemSucesso("Enviado para o banco de dados com sucesso.");
            }
            catch (Exception ex)
            {
                MostrarMensagemErro(ex.Message);
            }
            finally
            {
                comandoSql.Connection.Close();
                comandoSql.Dispose();
            }
        }

        private void SqlUpdate(string tabela, Dictionary<string, string> camposAtualizados, Dictionary<string, string> condicoes, string operacao = "")
        {
            string comandoString = $"UPDATE {tabela}" +
                $" SET { string.Join(", ", camposAtualizados.Select(campo => $"{ campo.Key } = @{ campo.Key }")) }" +
                $" WHERE {string.Join($" {operacao} ", condicoes.Select(condicao => $"{condicao.Key} = '{condicao.Value}'"))}";

            SqlCommand comandoSql = new SqlCommand(comandoString, conexaoSql);
            foreach (var campo in camposAtualizados) { comandoSql.Parameters.AddWithValue(campo.Key, campo.Value); }

            try
            {
                comandoSql.Connection.Open();
                comandoSql.ExecuteNonQuery();

                MostrarMensagemSucesso("Registro atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                MostrarMensagemErro(ex.Message);
            }
            finally
            {
                comandoSql.Connection.Close();
                comandoSql.Dispose();
            }
        }

        private void SqlDelete(string tabela, Dictionary<string, string> condicoes, string operacao = "")
        {
            string comandoString = $"DELETE FROM {tabela}" +
                $" WHERE {string.Join($" {operacao} ", condicoes.Select(condicao => $"{condicao.Key} = '{condicao.Value}'"))}";
            SqlCommand comandoSql = new SqlCommand(comandoString, conexaoSql);

            try
            {
                comandoSql.Connection.Open();
                comandoSql.ExecuteNonQuery();

                MostrarMensagemSucesso("Deletado do banco de dados com sucesso.");
            }
            catch (Exception ex)
            {
                MostrarMensagemErro(ex.Message);
            }
            finally
            {
                comandoSql.Connection.Close();
                comandoSql.Dispose();
            }
        }

        public void MostrarMensagemErro(string message)
        {
            MessageBox.Show(
                message,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
        
        public void MostrarMensagemSucesso(string message)
        {
            MessageBox.Show(
                message,
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
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

                    camposDeEntrada[comboBox.Key] = itemSelecionado.Key;
                }
                else
                {
                    MostrarMensagemErro($"Selecione um valor valido no campo \"{comboBox.Key.Replace(":", "")}\"");
                    return false;
                }
            }

            return true;
        }

        private Dictionary<string, string> ObterValoresAtualizados()
        {
            var atualizacoes = new Dictionary<string, string>();
            var colunasBanco = ObterColunas(orcamentoTabela).Skip(1).ToArray();
            var valoresAntigos = valoresSelecionados.ToArray();
            var valoresNovos = camposDeEntrada.Values.ToArray();

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
        public List<string> ObterColunas(string tabela)
        {
            List<string> colunasBanco = new List<string>();
            string comandoString = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabela}'";
            SqlCommand comandoSql = new SqlCommand(comandoString, conexaoSql);

            try
            {
                comandoSql.Connection.Open();
                var leitor = comandoSql.ExecuteReader();

                while (leitor.Read())
                {
                    colunasBanco.Add(leitor[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MostrarMensagemErro(ex.Message);
                Close();
            }
            finally
            {
                comandoSql.Connection.Close();
                comandoSql.Dispose();
            }

            return colunasBanco;
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {
            dtpDataEntradaOrcamento.Value = DateTime.Today;
            CarregarTags();
            var condicoesCliente = new Dictionary<string, string> { { "categoria", "Cliente" } };

            PopularComboBox(cbPecasOrcamento, SqlSelect("cadPeca", "codPeca", "nomePeca", "fabricante"));
            PopularComboBox(cbRecebidoOrcamento, SqlSelect("cadFunc", "idFunc", "nome"));
            PopularComboBox(cbClienteOrcamento, SqlSelect("cadClientForn", condicoesCliente, "AND", "idCad", "nomeRazSoc"));
        }

        private void btnInserirOrcamento_Click(object sender, EventArgs e)
        {
            if (modos[btnEnviar.Text]())
            {
                LimparCampos();
            }
        }

        private void CarregarTags()
        {
            var colunasBanco = ObterColunas(orcamentoTabela);

            foreach (var _ in campos.Zip(colunasBanco, (campo, coluna) => { campo.Tag = coluna; return true; }));
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
        }

        private void MudarModo(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            btnEnviar.Text = btnClicado.Text;
            LimparCampos();

            string[] btnsChamarJanela = { "Editar", "Excluir" };
            if (btnsChamarJanela.Contains(btnClicado.Text))
            {
                btnLimpar.Visible = false;

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
            else
            {
                btnLimpar.Visible = true;
            }
            //Melhorar visualização do modo ativado no design do formulário
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
