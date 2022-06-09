using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace SistemaOrdemServico
{
    internal class BancoDadosOrcamento
    {
        private readonly SqlConnection conexao;


        public BancoDadosOrcamento()
        {
            conexao = new SqlConnection(GetStringConexao());
        }

        private string GetStringConexao()
        {
            var strConPath = Path.Combine(Directory.GetCurrentDirectory(), "stringConexao.txt");

            if (File.Exists(strConPath))
            {
                using (var sr = new StreamReader(strConPath))
                {
                    return sr.ReadLine();
                }
            }
            else
            {
                Form1.MostrarMensagemErro(
                    "Crie um arquivo com o nome \"stringConexao.txt\" no diretório do executável, " +
                    "escreva a string de conexão ao banco de dados no arquivo e " +
                    "rode o programa novamente."
                    );

                Environment.Exit(0);
                return string.Empty;
            }
        }

        public void TryComando(Action<SqlCommand> acao, string comandoStr)
        {
            var comando = new SqlCommand(comandoStr, conexao);

            try
            {
                comando.Connection.Open();

                acao(comando);
            }
            catch (Exception ex)
            {
                Form1.MostrarMensagemErro(ex.Message);
            }
            finally
            {
                comando.Connection.Close();
                comando.Dispose();
            }
        }

        public List<string> ObterColunas(string tabela)
        {
            var colunasBanco = new List<string>();

            var comandoStr = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tabela}'";
            TryComando((comando) =>
            {
                var leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    colunasBanco.Add(leitor[0].ToString());
                }
            }, comandoStr);

            return colunasBanco;
        }

        public List<List<string>> Select(string comandoStr)
        {
            var registros = new List<List<string>>();

            TryComando((comando) =>
            {
                var leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    var campos = new List<string>();

                    for (int i = 0; i < leitor.FieldCount; i++)
                    {
                        campos.Add(leitor[i].GetType() != typeof(DateTime) ? leitor[i].ToString() : ((DateTime)leitor[i]).ToShortDateString());
                    }

                    registros.Add(campos);
                }
            }, comandoStr);

            return registros;
        }

        public List<List<string>> Select(string tabela, params string[] colunas)
        {
            var comandoStr = $"SELECT {string.Join(", ", colunas)} from {tabela}";

            return Select(comandoStr);
        }

        public List<List<string>> Select(string tabela, Dictionary<string, string> condicoes, string operacao, params string[] colunas)
        {
            var comandoStr = $"SELECT {string.Join(", ", colunas)} from {tabela}" +
                $" WHERE {string.Join($" {operacao} ", condicoes.Select(condicao => $"{condicao.Key} = '{condicao.Value}'"))}";

            return Select(comandoStr);
        }

        public void Insert(string tabela, Dictionary<string, string> campos)
        {
            var comandoStr = $"INSERT INTO {tabela} VALUES({ string.Join(", ", campos.Select(campo => campo.Key))})";

            TryComando((comando) =>
            {
                foreach (var campo in campos) { comando.Parameters.AddWithValue(campo.Key, campo.Value); }

                comando.ExecuteNonQuery();

                Form1.MostrarMensagemSucesso("Enviado para o banco de dados com sucesso.");
            }, comandoStr);
        }

        public void Update(string tabela, Dictionary<string, string> camposAtualizados, Dictionary<string, string> condicoes, string operacao = "")
        {
            var comandoStr = $"UPDATE {tabela}" +
                $" SET { string.Join(", ", camposAtualizados.Select(campo => $"{ campo.Key } = @{ campo.Key }")) }" +
                $" WHERE {string.Join($" {operacao} ", condicoes.Select(condicao => $"{condicao.Key} = '{condicao.Value}'"))}";

            TryComando((comando) =>
            {
                foreach (var campo in camposAtualizados) { comando.Parameters.AddWithValue(campo.Key, campo.Value); }

                comando.ExecuteNonQuery();

                Form1.MostrarMensagemSucesso("Registro atualizado com sucesso.");
            }, comandoStr);
        }

        public void Delete(string tabela, Dictionary<string, string> condicoes, string operacao = "")
        {
            var comandoStr = $"DELETE FROM {tabela}" +
                $" WHERE {string.Join($" {operacao} ", condicoes.Select(condicao => $"{condicao.Key} = '{condicao.Value}'"))}";

            TryComando((comando) =>
            {
                comando.ExecuteNonQuery();

                Form1.MostrarMensagemSucesso("Deletado do banco de dados com sucesso.");
            }, comandoStr);
        }
    }
}
