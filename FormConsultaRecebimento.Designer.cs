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
            tboxFornecedor = new TextBox();
            label7 = new Label();
            btnVoltar = new Button();
            tboxMaterial = new TextBox();
            label2 = new Label();
            dtPickerDataRecebimento = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRecebimento).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top;
            btnPesquisar.BackColor = Color.LightSeaGreen;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Center;
            btnPesquisar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("SAPGUI-Icons", 15.75F);
            btnPesquisar.ForeColor = SystemColors.ButtonHighlight;
            btnPesquisar.ImeMode = ImeMode.NoControl;
            btnPesquisar.Location = new Point(644, 107);
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
            // tboxMaterial
            // 
            tboxMaterial.BorderStyle = BorderStyle.FixedSingle;
            tboxMaterial.Font = new Font("SAPGUI-Icons", 14.25F);
            tboxMaterial.Location = new Point(311, 109);
            tboxMaterial.Name = "tboxMaterial";
            tboxMaterial.Size = new Size(153, 30);
            tboxMaterial.TabIndex = 19;
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
            Controls.Add(tboxMaterial);
            Controls.Add(btnVoltar);
            Controls.Add(tboxFornecedor);
            Controls.Add(dgvRecebimento);
            Controls.Add(btnPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormConsultaRecebimento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RecvPB - Consultar Recebimentos";
            ((System.ComponentModel.ISupportInitialize)dgvRecebimento).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView dgvRecebimento;
        private TextBox tboxFornecedor;
        private Label label7;
        private Button btnVoltar;
        private TextBox tboxMaterial;
        private Label label2;
        private DateTimePicker dtPickerDataRecebimento;
        private Label label1;
        private Label label3;
        private Panel panel1;
    }
}