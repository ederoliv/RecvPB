using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecvPB.Repository
{
    internal class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection()
        {
            // Obtém o caminho do diretório de execução do aplicativo
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Constrói o caminho completo para o banco de dados na pasta properties
            string dbPath = Path.Combine(basePath, "properties", "recebedores.accdb");

            // Constrói a string de conexão usando o caminho completo
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"{dbPath}\";Persist Security Info=False;";
        }

        // Método para obter a string de conexão (opcional)
        public string GetConnectionString()
        {
            return connectionString;
        }
    }
}
