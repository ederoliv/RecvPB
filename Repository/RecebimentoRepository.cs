using System.Data;
using System.Data.OleDb;

namespace RecvPB.Repository
{
    internal class RecebimentoRepository
    {

        public static void InserirRecebimento(string fonecedor, string material, string dataRecebimento, string recebedor, string quantidade, string numeroLote)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            using (OleDbConnection connection = new OleDbConnection(databaseConnection.GetConnectionStringDbPrincipal()))
            {
                try
                {
                    // Abre a conexão
                    connection.Open();

                    // Comando SQL para inserir os dados na tabela Recebimento
                    string query = "INSERT INTO Recebimento (cod_for, cod_mat, dt_recebimento,recebido_por, quantidade, nro_lote) " +
                                   "VALUES (@cod_for, @cod_mat, @dt_recebimento,@comboBoxRecebedores, @quantidade, @nro_lote)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Parâmetros adicionados ao comando SQL, substituindo os placeholders
                        command.Parameters.AddWithValue("@cod_for", fonecedor);
                        command.Parameters.AddWithValue("@cod_mat", material);
                        command.Parameters.AddWithValue("@dt_recebimento", dataRecebimento);
                        command.Parameters.AddWithValue("recebido_por", recebedor);
                        command.Parameters.AddWithValue("@quantidade", quantidade);
                        command.Parameters.AddWithValue("@nro_lote", numeroLote);

                        // Executa o comando para inserir os dados
                        command.ExecuteNonQuery();

                        // Exibe uma mensagem de sucesso
                        MessageBox.Show("Recebimento inserido com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    // Exibe uma mensagem de erro, se necessário
                    MessageBox.Show("Erro ao inserir recebimento: " + ex.Message);
                }
            }
        }

        public static DataTable BuscaPorLote(string Lote)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (OleDbConnection connection = new OleDbConnection(databaseConnection.GetConnectionStringDbPrincipal()))
            {
                try
                {
                    connection.Open();
                    // Incluindo nro_lote na consulta SQL
                    string query = "SELECT * FROM Recebimento WHERE nro_lote = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@nro_lote", Lote); 

                        // Executando a consulta
                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar recebimentos: " + ex.Message);
                    return new DataTable();
                }
            }
        }

        public static DataTable BuscaUltimosVinteRecebimentos()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (OleDbConnection connection = new OleDbConnection(databaseConnection.GetConnectionStringDbPrincipal()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TOP 20 * FROM Recebimento ORDER BY Código DESC;";
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
