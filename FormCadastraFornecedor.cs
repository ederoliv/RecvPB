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
    public partial class FormCadastraFornecedor : Form
    {
        public FormCadastraFornecedor()
        {
            InitializeComponent();
        }

        private void FormCadastraFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGridFornecedores();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tboxCodFornecedor.Text) || !string.IsNullOrWhiteSpace(tboxNomeFornecedor.Text))
            {
                if (FornecedoresRepository.InsereFornecedor(tboxCodFornecedor.Text, tboxNomeFornecedor.Text))
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso!");
                    CarregaGridFornecedores();
                }
                else { MessageBox.Show("Erro ao cadastrar fornecedor!"); }
            }
            else { MessageBox.Show("Preencha os campos vazios!"); }

            tboxCodFornecedor.Text = string.Empty;
            tboxNomeFornecedor.Text = string.Empty;
        }

        private void CarregaGridFornecedores()
        {
            try
            {

                DataTable dtFornecedores = FornecedoresRepository.BuscaTodosFornecedoresNomeId();

                if (dtFornecedores.Rows.Count > 0)
                {

                    dgvFornecedores.DataSource = dtFornecedores;


                    dgvFornecedores.Columns[0].HeaderText = "Código do Fornecedor";
                    dgvFornecedores.Columns[1].HeaderText = "Nome do Fornecedor";
                }
                else
                {
                    MessageBox.Show("Nenhum recebedor encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os recebedores: " + ex.Message);
            }
        }
    }
}
