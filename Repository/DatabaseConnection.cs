using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecvPB.Repository
{
    internal class DatabaseConnection
    {
        private string connectionStringDbRecebedores;
        private string connectionStringDbPrincipal;

        public void SetConnectionStringDbRecebedores()
        {
            this.connectionStringDbRecebedores = "\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\recebedores.accdb\";Persist Security Info=False;\r\n";
        }
        public string GetConnectionStringDbRecebedores()
        {
            SetConnectionStringDbRecebedores();
            return this.connectionStringDbRecebedores;
        }

        public void SetConnectionStringDbPrincipal()
        {
            this.connectionStringDbPrincipal = "\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\371.accdb\";Persist Security Info=False;\r\n";
        }

        public string GetConnectionStringDbPrincipal()
        {

            SetConnectionStringDbPrincipal();
            return this.connectionStringDbPrincipal;
        }
    }
}
