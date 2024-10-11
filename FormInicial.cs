using RecvPB.Repository;
using System.Data;
using System.Data.Common;
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
            comboBoxRecebedores.DisplayMember = "nome";
            comboBoxRecebedores.DataSource = RecebedoresRepository.BuscaTodosRecebedoresNome();

            CarregaGridRecebimento();
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
                MessageBox.Show("Preencha os campos vazios!");
            }
            else
            {
                RecebimentoRepository.InserirRecebimento(tboxFornecedor.Text, tBoxMaterial.Text, dtPickerDataRecebimento.Value.ToString("dd/MM/yyyy"), comboBoxRecebedores.Text, tBoxQuantidade.Text, tBoxNumeroLote.Text);


                FormImprimirRecebimento formImprimirRecebimento = new();
                formImprimirRecebimento.Show();


                LimpaCamposFormInicial();
                CarregaGridRecebimento();
            }
        }
        private void btnConsultarRecebimentos_Click(object sender, EventArgs e)
        {
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

        private void LimpaCamposFormInicial()
        {
            tboxFornecedor.Text = string.Empty;
            tBoxMaterial.Text = string.Empty;
            tBoxQuantidade.Text = string.Empty;
            tBoxNumeroLote.Text = string.Empty;

        }

        private void CarregaGridRecebimento()
        {
            try
            {

                DataTable dtRecebimento = RecebimentoRepository.BuscaUltimosRecebimentos(20);

                if (dtRecebimento.Rows.Count > 0)
                {

                    dgvRecebimento.DataSource = dtRecebimento;

                    dgvRecebimento.Columns[0].HeaderText = "Código";
                    dgvRecebimento.Columns[1].HeaderText = "Fonecedor";
                    dgvRecebimento.Columns[2].HeaderText = "Material";
                    dgvRecebimento.Columns[3].HeaderText = "Recebimento";
                    dgvRecebimento.Columns[4].HeaderText = "Recebido Por";
                    dgvRecebimento.Columns[5].HeaderText = "Quantidade";
                    dgvRecebimento.Columns[6].HeaderText = "Nro Lote";

                }
                else
                {
                    MessageBox.Show("Nenhum recebimento encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os recebimentos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastraProduto formCadastraProduto = new FormCadastraProduto();
            formCadastraProduto.ShowDialog();
        }
    }
}