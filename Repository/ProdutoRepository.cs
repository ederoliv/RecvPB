using System.Data;
using System.Data.OleDb;


namespace RecvPB.Repository
{
    internal class ProdutoRepository
    {

        public static Boolean InsereProduto(string codigo, string descricao)
        {

            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (OleDbConnection connection = new OleDbConnection(databaseConnection.GetConnectionStringDbPrincipal()))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Materiais (cod_mat, descr_mat)" +
                                    "VALUES (@codigo, @descricao)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@codigo", codigo);
                        command.Parameters.AddWithValue("@descricao", descricao);

                        command.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);

                    return false;
                }
            }   
        }

        public static DataTable BuscaTodosProdutos() { 
        
            
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (OleDbConnection connection = new OleDbConnection(databaseConnection.GetConnectionStringDbPrincipal()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT cod_mat, descr_mat FROM Materiais";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    return dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar produtos: " + ex.Message);
                    return new DataTable();
                }
            }                        
        }
    }
}
