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

            String Path = @"\\domain\sistemas\MF60.xls";

            pastaDeTrabalho = app.Workbooks.Open(Path);

            planilha = (Microsoft.Office.Interop.Excel.Worksheet)pastaDeTrabalho.Sheets[1];

            planilha.Cells[6, 2] = lote;
            planilha.Cells[3, 2] = codMat;
            planilha.Cells[7, 2] = DateTime.Now.ToString("dd/MM/yyyy");

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
            try
            {
                string file = @"\\domain\sistemas\MF60.xls";
                var excelApp = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks books = excelApp.Workbooks;
                Microsoft.Office.Interop.Excel._Workbook sheet = books.Open(file);
                excelApp.Visible = true; // true will open Excel
                sheet.PrintPreview();
                excelApp.Visible = false; // hides excel file when user closes preview

                books.Close();
                sheet.Close();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(books);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);

                GC.Collect();
                GC.WaitForPendingFinalizers();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormImprimirRecebimento_Load(object sender, EventArgs e)
        {

        }
    }
}
