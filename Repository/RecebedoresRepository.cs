using RecvPB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecvPB.Repository
{
    internal static class RecebedoresRepository
    {
        public static DataTable BuscaTodosRecebedoresNome()
        {

            using (OleDbConnection connection = new OleDbConnection("\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\recebedores.accdb\";Persist Security Info=False;\r\n"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT nome FROM recebedor";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar recebedores: " + ex.Message);
                    return new DataTable();
                }
            }

        }

        public static DataTable BuscaTodosRecebedoresNomeId()
        {

            using (OleDbConnection connection = new OleDbConnection("\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\recebedores.accdb\";Persist Security Info=False;\r\n"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Código, nome FROM recebedor";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar recebedores: " + ex.Message);
                    return new DataTable();
                }
            }
        }

        public static Boolean InsereRecebedor(string nome)
        {
            //DatabaseConnection conn = new DatabaseConnection();

            using (OleDbConnection connection = new OleDbConnection("\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\recebedores.accdb\";Persist Security Info=False;\r\n"))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO recebedor (nome) " +
                                   "VALUES (@nome)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@nome", nome);

                        command.ExecuteNonQuery();

                        return true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar recebedor: " + ex.Message);

                    return false;
                }
            }
        }
    }
}
