using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrdemServico
{
    public partial class Orcamento : Form
    {
        private static string conexaoString = ConfigurationManager.ConnectionStrings["GustavoDanielCasa"].ToString();
        private static SqlConnection conexaoSql = new SqlConnection(conexaoString);


        public Orcamento()
        {
            InitializeComponent();
        }

        private void PopularComboBox(ComboBox comboBox, List<List<string>> itens)
        {
            var itensDicionario = itens.ToDictionary(
                keySelector: cliente => cliente[0],
                elementSelector: cliente => string.Join(" - ", cliente.Skip(1))
                );

            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.DataSource = new BindingSource(itensDicionario, null);
            comboBox.SelectedIndex = -1;
        }

        private List<List<string>> SqlSelect(string tabela, params string[] colunas)
        {
            List<List<string>> registros = new List<List<string>>();

            string comandString = $"SELECT {string.Join(", ", colunas)} from {tabela}";
            SqlCommand comandoSql = new SqlCommand(comandString, conexaoSql);

            try
            {
                comandoSql.Connection.Open();
                SqlDataReader reader = comandoSql.ExecuteReader();

                while (reader.Read())
                {
                    List<string> campos = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        campos.Add(reader[i].ToString());
                    }

                    registros.Add(campos);
                }
            }
            catch (Exception ex)
            {
                MostrarMensagemErro(ex);
            }
            finally
            {
                comandoSql.Connection.Close();
                comandoSql.Dispose();
            }

            return registros;
        }

        private void MostrarMensagemErro(Exception ex)
        {
            MessageBox.Show(
                ex.ToString(),
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {
            dtpDataEntradaOrcamento.Value = DateTime.Today;

            PopularComboBox(cbPecasOrcamento, SqlSelect("cadPeca", "codPeca", "nomePeca", "fabricante"));
            PopularComboBox(cbClienteOrcamento, SqlSelect("cadClientForn", "idCad", "nomeRazSoc"));
            PopularComboBox(cbRecebidoOrcamento, SqlSelect("cadFunc", "idFunc", "nome"));
        }

        private void btnInserirOrcamento_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> camposDeEntrada = new Dictionary<string, string>
            {
                {lblClienteOrcamento.Text, cbClienteOrcamento.Text},
                {lblDataEntradaOrcamento.Text, dtpDataEntradaOrcamento.Value.Date.ToString("yyyy-MM-dd")},
                {lblDescricaoOrcamento.Text, txtDescricaoOrcamento.Text},
                {lblPecasOrcamento.Text, cbPecasOrcamento.Text},
                {lblValorOrcamento.Text, nudValorOrcamento.Text == "0,00" ? string.Empty : nudValorOrcamento.Text.Replace(",", ".")},
                {lblRecebidoOrcamento.Text, cbRecebidoOrcamento.Text}
            };

            //Codigo temporáreo
            if (cbClienteOrcamento.SelectedIndex != -1)
            {
                var clienteSelecionado = (KeyValuePair<string, string>)cbClienteOrcamento.SelectedItem;
                Console.WriteLine("Item " + clienteSelecionado.Key);
                Console.WriteLine("Item " + clienteSelecionado.Value);
            }
            //Fim

            if (!Form1.TemCamposVazios(camposDeEntrada))
            {
                //Validar valores do combobox antes de enviar
                var camposCorrigidos = camposDeEntrada.Values.Select(campo => $"'{campo}'");

                string sql = $"INSERT INTO cadOrcamento VALUES({string.Join(", ", camposCorrigidos)})";
                SqlCommand command = new SqlCommand(sql, conexaoSql);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "Enviado para o banco de dados com sucesso.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MostrarMensagemErro(ex);
                }
                finally
                {
                    command.Dispose();
                    conexaoSql.Close();
                }
            }
            //Modificar comportamento do botão dependendo da função ativada
        }

        private void MudarModo(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            btnEnviar.Text = btnClicado.Text;
            string[] btnsChamarJanela = {"Editar", "Excluir"};

            if (btnsChamarJanela.Contains(btnClicado.Text))
            {
                SelecionarOrcamento selecionarOrcamento = new SelecionarOrcamento();
                selecionarOrcamento.Show();
            }
            //Melhorar visualização do modo ativado no design do formulário
        }
    }
}
