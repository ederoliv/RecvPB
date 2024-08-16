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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtBoxNomeRecebedor.Text))
            {
                if (RecebedoresRepository.CadastraRecebedor(txtBoxNomeRecebedor.Text))
                {
                    MessageBox.Show("Recebedor cadastrado com sucesso!");
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
        }
    }
}
