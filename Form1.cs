using RecvPB.Repository;
using System.Data;
using System.Data.OleDb;

namespace RecvPB
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();

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

                    comboBoxRecebedores.DisplayMember = "nome";
                    comboBoxRecebedores.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar recebedores: " + ex.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //teste
            tboxFornecedor.Text = "777";
            tBoxMaterial.Text = "777";
            tBoxQuantidade.Text = "777";
            tBoxNumeroLote.Text = "777";


            //teste

            RecebimentoRepository.InserirRecebimento(tboxFornecedor.Text, tBoxMaterial.Text, dtPickerDataRecebimento.Value.ToString("dd/MM/yyyy"), comboBoxRecebedores.Text, tBoxQuantidade.Text, tBoxNumeroLote.Text);
            
        }
            

            /*
            private void btnSalvar_Click(object sender, EventArgs e)
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
                            command.Parameters.AddWithValue("@cod_for", tboxFornecedor.Text);
                            command.Parameters.AddWithValue("@cod_mat", tBoxMaterial.Text);
                            command.Parameters.AddWithValue("@dt_recebimento", dtPickerDataRecebimento.Value.ToString("dd/MM/yyyy"));
                            command.Parameters.AddWithValue("recebido_por", comboBoxRecebedores.Text);
                            command.Parameters.AddWithValue("@quantidade", tBoxQuantidade.Text);
                            command.Parameters.AddWithValue("@nro_lote", tBoxNumeroLote.Text);

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

            } */

            private void btnSobre_Click(object sender, EventArgs e)
        {
            // URL para onde deseja redirecionar
            string url = "https://ederoliv.github.io";

            // Abre o navegador com o URL
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o site: " + ex.Message);
            }
        }
    }
}