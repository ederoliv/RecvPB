using Microsoft.Office.Interop.Excel;
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
    public partial class FormImprimirRecebimento : Form
    {
        public FormImprimirRecebimento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Data.DataTable dt = RecebimentoRepository.BuscaUltimosRecebimentos(1);

            if (dt != null)
            {

                DataRow row = dt.Rows[0];

                String lote = row[columnName: "nro_lote"].ToString();
                String codMat = row[columnName: "cod_mat"].ToString();

                MessageBox.Show($"{lote} and {codMat}");


                SalvaEtiqueta(lote, codMat);
                imprimeEtiqueta();

                this.Close();

            }
            else
            {

                MessageBox.Show("Erro ao obter último recebimento!");

            }
        }

        public void SalvaEtiqueta(String lote, String codMat)
        {

            Microsoft.Office.Interop.Excel.Application app = new();

            Workbook pastaDeTrabalho;
            Worksheet planilha;

            String Path = @"C:\PROD\MF60.xls";

            pastaDeTrabalho = app.Workbooks.Open(Path);

            planilha = (Microsoft.Office.Interop.Excel.Worksheet)pastaDeTrabalho.Sheets[1];

            planilha.Cells[6, 2] = lote;
            planilha.Cells[3, 2] = codMat;

            pastaDeTrabalho.SaveAs(Path);
            pastaDeTrabalho.Close(false);

            //Libera os objetos COM para evitar que o Excel continue rodando em segundo plano
            System.Runtime.InteropServices.Marshal.ReleaseComObject(planilha);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(pastaDeTrabalho);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);

            // Força a coleta de lixo para limpar a memória usada
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        public void imprimeEtiqueta()
        {
            //imprime aqui
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormImprimirRecebimento_Load(object sender, EventArgs e)
        {

        }
    }
}
