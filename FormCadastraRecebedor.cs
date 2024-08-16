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
    public partial class FormCadastraRecebedor : Form
    {
        public FormCadastraRecebedor()
        {
            InitializeComponent();
        }

        private void FormCadastraRecebedor_Load(object sender, EventArgs e)
        {
            CarregaGridRecebedores();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtBoxNomeRecebedor.Text))
            {
                if (RecebedoresRepository.InsereRecebedor(txtBoxNomeRecebedor.Text))
                {
                    MessageBox.Show("Recebedor cadastrado com sucesso!");
                    CarregaGridRecebedores();

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar recebedor!");
                }
            }
            else
            {
                MessageBox.Show("Insira o nome do recebedor que deseja cadastrar!");
            }

            txtBoxNomeRecebedor.Text = string.Empty;

        }

        private void CarregaGridRecebedores()
        {
            try
            {

                DataTable dtRecebedores = RecebedoresRepository.BuscaTodosRecebedoresNomeId();

                if (dtRecebedores.Rows.Count > 0)
                {

                    dgvRecebedores.DataSource = dtRecebedores;


                    dgvRecebedores.Columns[0].HeaderText = "ID do Recebedor";
                    dgvRecebedores.Columns[1].HeaderText = "Nome do Recebedor";
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
