using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intersoft.Crosslight.Mobile;

namespace RecvPB.Repository
{
    internal static class FornecedoresRepository
    {
        public static Boolean InsereFornecedor(string CodigoFornecedor, string NomeFornecedor) {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (OleDbConnection connection = new OleDbConnection(databaseConnection.GetConnectionStringDbPrincipal()))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Fornecedores (cod_for, descr_for) " +
                                   "VALUES (@codigo ,@nome)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codigo", CodigoFornecedor);
                        command.Parameters.AddWithValue("@nome", NomeFornecedor);

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
        public static DataTable BuscaTodosFornecedoresNomeId() {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (OleDbConnection connection = new OleDbConnection(databaseConnection.GetConnectionStringDbPrincipal()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT cod_for, descr_for FROM Fornecedores";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
                    return new DataTable();
                }
            }
        }
    }
}