using RecvPB.Repository;
using System.Data;


namespace RecvPB
{
    public partial class FormConsultaRecebimento : Form
    {
        public FormConsultaRecebimento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
        

            if (!String.IsNullOrEmpty(tbCodFornecedor.Text) || !String.IsNullOrEmpty(tbCodMaterial.Text) || !String.IsNullOrEmpty(tbNumeroLote.Text))
            {

                CarregaGridRecebimento(tbCodFornecedor.Text,tbCodMaterial.Text, tbNumeroLote.Text);

            }
            else
            {
                MessageBox.Show("Preencha pelo menos um dos campos vazios!");
            }
        }

        private void CarregaGridRecebimento(string CodFornecedor , string CodMaterial,string NumeroLote)
        {
            try
            {
                DataTable dtRecebimento = RecebimentoRepository.BuscaPorFonecedorMaterialOuLote(CodFornecedor,CodMaterial, NumeroLote);

                if (dtRecebimento.Rows.Count > 0)
                {

                    dgvRecebimento.DataSource = dtRecebimento;

                    dgvRecebimento.Columns[0].Visible = false;
                    dgvRecebimento.Columns[1].HeaderText = "Cód Fonecedor";
                    dgvRecebimento.Columns[2].HeaderText = "Cód Material";
                    dgvRecebimento.Columns[3].HeaderText = "Data Recebimento";
                    dgvRecebimento.Columns[4].HeaderText = "Recebido Por";
                    dgvRecebimento.Columns[5].HeaderText = "Quantidade";
                    dgvRecebimento.Columns[6].HeaderText = "Nro Lote";

                }
                else
                {
                    MessageBox.Show("Nenhum recebimento encontrado: verifique se o código do Material ou do Fornecedor está correto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os recebimentos: " + ex.Message);
            }
        }

        private void FormConsultaRecebimento_Load(object sender, EventArgs e)
        {
            //code 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
