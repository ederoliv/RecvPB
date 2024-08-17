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
            CarregaGridRecebimento();
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
                    MessageBox.Show("Nenhum recebimento encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os recebimentos: " + ex.Message);
            }
        }
    }
}
