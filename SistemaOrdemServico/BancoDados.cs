using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrdemServico
{
    class BancoDados
    {
        public SqlConnection AbreConexao()
        {
            string conexao = @"'NOME-DO-SERVIDOR-DA-MAQUINA';
                                   Database=OSFujita;
                                   User Id=sa; 
                                   Password=1234;";
            return new SqlConnection(conexao);
        }
    }
}
