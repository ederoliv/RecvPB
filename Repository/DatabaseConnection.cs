using System;
using System.CodeDom;
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


        //DEFAULTS STRING CONNECTIONS FOR DEVELOPMENT/TEST
        private const string strConnectionDbPrincipalDev = "\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"\\\\domain\\SISTEMAS\\banco-recebimento-teste\\371.accdb\";Persist Security Info=False;\r\n";

        private const string strConnectionDbRecebedoresDev = "\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"\\\\domain\\SISTEMAS\\banco-recebimento-teste\\recebedores.accdb\";Persist Security Info=False;\r\n";

        //DEFAULTS STRING CONNECTIONS FOR PRODUCTION
        private const string strConnectionDbPrincipalProd = "\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"\\\\domain\\SISTEMAS\\371.accdb\";Persist Security Info=False;\r\n";

        private const string strConnectionDbRecebedoresProd = "\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"\\\\domain\\SISTEMAS\\recebedores.accdb\";Persist Security Info=False;\r\n";

        //DEFAULTS STRING CONNECTIONS FOR LOCALTEST
        private const string strConnectionDbPrincipalLocalTest= "\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\371.accdb\";Persist Security Info=False;\r\n";

        private const string strConnectionDbRecebedoresLocalTest = "\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\recebedores.accdb\";Persist Security Info=False;\r\n";

        public void SetConnectionStringDbRecebedores()
        {
            this.connectionStringDbRecebedores = strConnectionDbRecebedoresLocalTest;

        }

        public void SetConnectionStringDbPrincipal()
        {
            this.connectionStringDbPrincipal = strConnectionDbPrincipalLocalTest;
        }

        public string GetConnectionStringDbRecebedores()
        {
            SetConnectionStringDbRecebedores();
            return connectionStringDbRecebedores;
        }

        public string GetConnectionStringDbPrincipal()
        {

            SetConnectionStringDbPrincipal();
            return this.connectionStringDbPrincipal;
        }
    }
}