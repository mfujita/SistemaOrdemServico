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
    public partial class Orcamento : Form
    {
        public Orcamento()
        {
            InitializeComponent();
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {
            dtpDataEntradaOrcamento.Value = DateTime.Today;
        }

        private void btnInserirOrcamento_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> camposDeEntrada = new Dictionary<string, string>
            {
                {lblClienteOrcamento.Text, cbClienteOrcamento.Text},
                {lblDataEntradaOrcamento.Text, dtpDataEntradaOrcamento.Text},
                {lblDescricaoOrcamento.Text, txtDescricaoOrcamento.Text},
                {lblPecasOrcamento.Text, cbPecasOrcamento.Text},
                {lblValorOrcamento.Text, nudValorOrcamento.Text == "0,00" ? string.Empty : nudValorOrcamento.Text},
                {lblRecebidoOrcamento.Text, cbRecebidoOrcamento.Text}
            };

            if (!Form1.TemCamposVazios(camposDeEntrada))
            {
                try
                {
                    /*string connection = "";
                    SqlConnection sqlConnection = new SqlConnection(connection);

                    string sql = $"INSERT INTO cadOrcamento VALUES({string.Join(", ", camposDeEntrada)})";
                    SqlCommand command = new SqlCommand(sql, sqlConnection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    command.Dispose();
                    sqlConnection.Close();

                    */
                    MessageBox.Show(
                        "Enviado para o banco de dados com sucesso.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.ToString(),
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
