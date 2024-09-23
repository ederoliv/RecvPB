using RecvPB.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (!String.IsNullOrEmpty(tboxFornecedor.Text) || !String.IsNullOrEmpty(tboxMaterial.Text))
            {
                CarregaGridRecebimento();
            }
            else
            {
                MessageBox.Show("Preencha pelo menos um dos campos vazios!");
            }
        }

        private void CarregaGridRecebimento()
        {

            try
            {

                DataTable dtRecebimento = RecebimentoRepository.BuscaPorFornecedorOuMaterial(tboxFornecedor.Text, tboxMaterial.Text);

                if (dtRecebimento.Rows.Count > 0)
                {

                    dgvRecebimento.DataSource = dtRecebimento;

                    dgvRecebimento.Columns[0].HeaderText = "Código";
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

        }
    }
}
