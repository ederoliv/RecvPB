using RecvPB.Repository;
using System.Data;
using System.Data.OleDb;

namespace RecvPB
{
    public partial class FormInicial : Form
    {

        public FormInicial()
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


            if (string.IsNullOrWhiteSpace(tboxFornecedor.Text) ||
                string.IsNullOrWhiteSpace(tBoxMaterial.Text) ||
                string.IsNullOrWhiteSpace(dtPickerDataRecebimento.Value.ToString("dd/MM/yyyy")) ||
                string.IsNullOrWhiteSpace(comboBoxRecebedores.Text) ||
                string.IsNullOrWhiteSpace(tBoxQuantidade.Text) ||
                string.IsNullOrWhiteSpace(tBoxNumeroLote.Text))
            {

                Console.WriteLine("Preencha os campos vazios!");

            }
            else
            {
                RecebimentoRepository.InserirRecebimento(tboxFornecedor.Text, tBoxMaterial.Text, dtPickerDataRecebimento.Value.ToString("dd/MM/yyyy"), comboBoxRecebedores.Text, tBoxQuantidade.Text, tBoxNumeroLote.Text);
            }

        }
        private void btnConsultarRecebimentos_Click(object sender, EventArgs e)
        {
            // Abrir formulário de consulta de recebimento
            FormConsultaRecebimento formConsultaRecebimento = new FormConsultaRecebimento();
            formConsultaRecebimento.ShowDialog();

        }

        private void btnCadastraRecebedor_Click(object sender, EventArgs e)
        {
            FormCadastraRecebedor formCadastraRecebedor = new FormCadastraRecebedor();
            formCadastraRecebedor.ShowDialog();
        }

        private void btnCadastraFornecedor_Click_1(object sender, EventArgs e)
        {
            FormCadastraFornecedor formCadastraFornecedor = new FormCadastraFornecedor();
            formCadastraFornecedor.ShowDialog();
        }
    }
}