namespace RecvPB
{
    partial class FormConsultaRecebimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaRecebimento));
            btnSalvar = new Button();
            dataGridView1 = new DataGridView();
            tboxFornecedor = new TextBox();
            label7 = new Label();
            btnVoltar = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dtPickerDataRecebimento = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top;
            btnSalvar.BackColor = Color.LightSeaGreen;
            btnSalvar.BackgroundImageLayout = ImageLayout.Center;
            btnSalvar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("SAPGUI-Icons", 15.75F);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.ImeMode = ImeMode.NoControl;
            btnSalvar.Location = new Point(644, 107);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(0, 0, 0, 4);
            btnSalvar.RightToLeft = RightToLeft.No;
            btnSalvar.Size = new Size(126, 36);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Pesquisar";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(861, 358);
            dataGridView1.TabIndex = 15;
            // 
            // tboxFornecedor
            // 
            tboxFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tboxFornecedor.Font = new Font("SAPGUI-Icons", 14.25F);
            tboxFornecedor.Location = new Point(132, 109);
            tboxFornecedor.Name = "tboxFornecedor";
            tboxFornecedor.Size = new Size(153, 30);
            tboxFornecedor.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 27.75F);
            label7.ForeColor = Color.White;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(234, 3);
            label7.Name = "label7";
            label7.Size = new Size(419, 50);
            label7.TabIndex = 17;
            label7.Text = "Consultar Recebimentos";
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top;
            btnVoltar.BackColor = Color.Goldenrod;
            btnVoltar.BackgroundImageLayout = ImageLayout.Center;
            btnVoltar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("SAPGUI-Icons", 15.75F);
            btnVoltar.ForeColor = SystemColors.ButtonHighlight;
            btnVoltar.ImeMode = ImeMode.NoControl;
            btnVoltar.Location = new Point(32, 527);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(0, 0, 0, 4);
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(861, 36);
            btnVoltar.TabIndex = 18;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.TopCenter;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("SAPGUI-Icons", 14.25F);
            textBox1.Location = new Point(311, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 30);
            textBox1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SAPGUI-Icons", 14.25F);
            label2.Location = new Point(489, 86);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 21;
            label2.Text = "Data Recebimento:";
            // 
            // dtPickerDataRecebimento
            // 
            dtPickerDataRecebimento.Checked = false;
            dtPickerDataRecebimento.DropDownAlign = LeftRightAlignment.Right;
            dtPickerDataRecebimento.Font = new Font("SAPGUI-Icons", 14.25F);
            dtPickerDataRecebimento.Format = DateTimePickerFormat.Short;
            dtPickerDataRecebimento.Location = new Point(489, 109);
            dtPickerDataRecebimento.Name = "dtPickerDataRecebimento";
            dtPickerDataRecebimento.Size = new Size(131, 30);
            dtPickerDataRecebimento.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SAPGUI-Icons", 14.25F);
            label1.Location = new Point(135, 86);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 22;
            label1.Text = "Código Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SAPGUI-Icons", 14.25F);
            label3.Location = new Point(314, 86);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 23;
            label3.Text = "Código Material:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(21, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 56);
            panel1.TabIndex = 24;
            // 
            // FormConsultaRecebimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 575);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dtPickerDataRecebimento);
            Controls.Add(textBox1);
            Controls.Add(btnVoltar);
            Controls.Add(tboxFornecedor);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormConsultaRecebimento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RecvPB - Consultar Recebimentos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private DataGridView dataGridView1;
        private TextBox tboxFornecedor;
        private Label label7;
        private Button btnVoltar;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dtPickerDataRecebimento;
        private Label label1;
        private Label label3;
        private Panel panel1;
    }
}