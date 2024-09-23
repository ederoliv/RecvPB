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
    public partial class FormCadastraProduto : Form
    {
        public FormCadastraProduto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(tboxDescricaoProduto.Text) && (String.IsNullOrWhiteSpace(tboxCodProduto.Text)))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (ProdutoRepository.InsereProduto(tboxCodProduto.Text, tboxDescricaoProduto.Text))
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
            }
        }

        private void FormCadastraProduto_Load(object sender, EventArgs e)
        {
            CarregaGridProduto();
        }

        private void CarregaGridProduto()
        {

            try
            {
                DataTable dtProduto = ProdutoRepository.BuscaTodosProdutos();

                if (dtProduto.Rows.Count > 0)
                {
                    dgvProdutos.DataSource = dtProduto;

                    dgvProdutos.Columns[0].HeaderText = "Código Produto";
                    dgvProdutos.Columns[1].HeaderText = "Descrição Produto";

                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos" + ex.Message);
            }
        }
    }
}
