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
            btnPesquisar = new Button();
            dgvRecebimento = new DataGridView();
            label7 = new Label();
            btnVoltar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            tbNumeroLote = new TextBox();
            tbCodFornecedor = new TextBox();
            tbCodMaterial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecebimento).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top;
            btnPesquisar.BackColor = SystemColors.Highlight;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Center;
            btnPesquisar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("SAPGUI-Icons", 15.75F);
            btnPesquisar.ForeColor = SystemColors.ButtonHighlight;
            btnPesquisar.ImeMode = ImeMode.NoControl;
            btnPesquisar.Location = new Point(660, 101);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Padding = new Padding(0, 0, 0, 4);
            btnPesquisar.RightToLeft = RightToLeft.No;
            btnPesquisar.Size = new Size(126, 36);
            btnPesquisar.TabIndex = 14;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.TopCenter;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvRecebimento
            // 
            dgvRecebimento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecebimento.BackgroundColor = Color.White;
            dgvRecebimento.BorderStyle = BorderStyle.Fixed3D;
            dgvRecebimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecebimento.Location = new Point(32, 157);
            dgvRecebimento.Name = "dgvRecebimento";
            dgvRecebimento.Size = new Size(861, 358);
            dgvRecebimento.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(311, 11);
            label7.Name = "label7";
            label7.Size = new Size(272, 32);
            label7.TabIndex = 17;
            label7.Text = "Consultar Recebimentos";
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top;
            btnVoltar.BackColor = Color.Black;
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
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 56);
            panel1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SAPGUI-Icons", 14.25F);
            label4.Location = new Point(473, 82);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 26;
            label4.Text = "Nº Lote:";
            // 
            // tbNumeroLote
            // 
            tbNumeroLote.BorderStyle = BorderStyle.FixedSingle;
            tbNumeroLote.Font = new Font("SAPGUI-Icons", 14.25F);
            tbNumeroLote.Location = new Point(473, 106);
            tbNumeroLote.Name = "tbNumeroLote";
            tbNumeroLote.Size = new Size(152, 30);
            tbNumeroLote.TabIndex = 25;
            // 
            // tbCodFornecedor
            // 
            tbCodFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tbCodFornecedor.Font = new Font("SAPGUI-Icons", 14.25F);
            tbCodFornecedor.Location = new Point(101, 106);
            tbCodFornecedor.Name = "tbCodFornecedor";
            tbCodFornecedor.Size = new Size(152, 30);
            tbCodFornecedor.TabIndex = 29;
            // 
            // tbCodMaterial
            // 
            tbCodMaterial.BorderStyle = BorderStyle.FixedSingle;
            tbCodMaterial.Font = new Font("SAPGUI-Icons", 14.25F);
            tbCodMaterial.Location = new Point(288, 106);
            tbCodMaterial.Name = "tbCodMaterial";
            tbCodMaterial.Size = new Size(152, 30);
            tbCodMaterial.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SAPGUI-Icons", 14.25F);
            label1.Location = new Point(288, 82);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 31;
            label1.Text = "Código Material";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SAPGUI-Icons", 14.25F);
            label2.Location = new Point(101, 82);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 32;
            label2.Text = "Código Fornecedor";
            // 
            // FormConsultaRecebimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 575);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCodMaterial);
            Controls.Add(tbCodFornecedor);
            Controls.Add(label4);
            Controls.Add(tbNumeroLote);
            Controls.Add(panel1);
            Controls.Add(btnVoltar);
            Controls.Add(dgvRecebimento);
            Controls.Add(btnPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormConsultaRecebimento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RecvPB - Consultar Recebimentos";
            Load += FormConsultaRecebimento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecebimento).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dgvRecebimento;
        private Label label7;
        private Button btnVoltar;
        private Panel panel1;
        private Label label4;
        private TextBox tbNumeroLote;
        private TextBox tbCodFornecedor;
        private TextBox tbCodMaterial;
        private Label label1;
        private Label label2;
    }
}