using RecvPB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RecvPB.Repository
{
    internal class RecebimentoRepository
    {

        public static void InserirRecebimento(string fonecedor, string material, string dataRecebimento, string recebedor, string quantidade, string numeroLote)
        {
            DatabaseConnection connect = new DatabaseConnection();

            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\eder.oliveira\Desktop\RecvPB\RecvPB\371.accdb;Persist Security Info=False;"))
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

        public static DataTable BuscaPorFornecedorOuMaterial(string Fornecedor, string Material)
        {
            using (OleDbConnection connection = new OleDbConnection("\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\371.accdb\";Persist Security Info=False;\r\n"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Recebimento WHERE cod_for = ? OR cod_mat = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod_for", Fornecedor); 
                        command.Parameters.AddWithValue("@cod_mat", Material);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
                    return new DataTable();
                }
            }
        }

        public static DataTable BuscaUltimosVinteRecebimentos()
        {
            using (OleDbConnection connection = new OleDbConnection("\r\nProvider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\eder.oliveira\\Desktop\\RecvPB\\RecvPB\\371.accdb\";Persist Security Info=False;\r\n"))
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
