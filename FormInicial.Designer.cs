

namespace RecvPB
{
    partial class FormInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            comboBoxRecebedores = new ComboBox();
            tboxFornecedor = new TextBox();
            tBoxMaterial = new TextBox();
            tBoxQuantidade = new TextBox();
            tBoxNumeroLote = new TextBox();
            dtPickerDataRecebimento = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSalvar = new Button();
            label7 = new Label();
            btnConsultarRecebimentos = new Button();
            btnCadastraRecebedor = new Button();
            btnCadastraFornecedor = new Button();
            panel1 = new Panel();
            dgvRecebimento = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecebimento).BeginInit();
            SuspendLayout();
            // 
            // comboBoxRecebedores
            // 
            comboBoxRecebedores.Font = new Font("SAPGUI-Icons", 14.25F);
            comboBoxRecebedores.FormattingEnabled = true;
            comboBoxRecebedores.Location = new Point(594, 85);
            comboBoxRecebedores.Name = "comboBoxRecebedores";
            comboBoxRecebedores.Size = new Size(184, 29);
            comboBoxRecebedores.TabIndex = 0;
            // 
            // tboxFornecedor
            // 
            tboxFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tboxFornecedor.Font = new Font("SAPGUI-Icons", 14.25F);
            tboxFornecedor.Location = new Point(139, 84);
            tboxFornecedor.Name = "tboxFornecedor";
            tboxFornecedor.PlaceholderText = "  Ex: 123456";
            tboxFornecedor.Size = new Size(153, 30);
            tboxFornecedor.TabIndex = 1;
            // 
            // tBoxMaterial
            // 
            tBoxMaterial.BorderStyle = BorderStyle.FixedSingle;
            tBoxMaterial.Font = new Font("SAPGUI-Icons", 14.25F);
            tBoxMaterial.Location = new Point(139, 139);
            tBoxMaterial.Name = "tBoxMaterial";
            tBoxMaterial.PlaceholderText = "  Ex: B1234";
            tBoxMaterial.Size = new Size(153, 30);
            tBoxMaterial.TabIndex = 2;
            // 
            // tBoxQuantidade
            // 
            tBoxQuantidade.BorderStyle = BorderStyle.FixedSingle;
            tBoxQuantidade.Font = new Font("SAPGUI-Icons", 14.25F);
            tBoxQuantidade.Location = new Point(359, 140);
            tBoxQuantidade.Name = "tBoxQuantidade";
            tBoxQuantidade.PlaceholderText = "Ex: 10";
            tBoxQuantidade.Size = new Size(153, 30);
            tBoxQuantidade.TabIndex = 3;
            // 
            // tBoxNumeroLote
            // 
            tBoxNumeroLote.BorderStyle = BorderStyle.FixedSingle;
            tBoxNumeroLote.Font = new Font("SAPGUI-Icons", 14.25F);
            tBoxNumeroLote.Location = new Point(594, 139);
            tBoxNumeroLote.Name = "tBoxNumeroLote";
            tBoxNumeroLote.PlaceholderText = "  Ex: 1234567";
            tBoxNumeroLote.Size = new Size(153, 30);
            tBoxNumeroLote.TabIndex = 4;
            // 
            // dtPickerDataRecebimento
            // 
            dtPickerDataRecebimento.Checked = false;
            dtPickerDataRecebimento.DropDownAlign = LeftRightAlignment.Right;
            dtPickerDataRecebimento.Font = new Font("SAPGUI-Icons", 14.25F);
            dtPickerDataRecebimento.Format = DateTimePickerFormat.Short;
            dtPickerDataRecebimento.Location = new Point(359, 85);
            dtPickerDataRecebimento.Name = "dtPickerDataRecebimento";
            dtPickerDataRecebimento.Size = new Size(131, 30);
            dtPickerDataRecebimento.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SAPGUI-Icons", 14.25F);
            label1.Location = new Point(142, 61);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 6;
            label1.Text = "Fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SAPGUI-Icons", 14.25F);
            label2.Location = new Point(362, 62);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 7;
            label2.Text = "Data Recebimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SAPGUI-Icons", 14.25F);
            label3.Location = new Point(597, 62);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 8;
            label3.Text = "Recebido Por:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SAPGUI-Icons", 14.25F);
            label4.Location = new Point(142, 116);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 9;
            label4.Text = "Material:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SAPGUI-Icons", 14.25F);
            label5.Location = new Point(362, 117);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 10;
            label5.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SAPGUI-Icons", 14.25F);
            label6.Location = new Point(597, 116);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 11;
            label6.Text = "Número Lote:";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top;
            btnSalvar.BackColor = Color.LightSeaGreen;
            btnSalvar.BackgroundImageLayout = ImageLayout.Center;
            btnSalvar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(139, 179);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(0, 0, 0, 4);
            btnSalvar.RightToLeft = RightToLeft.No;
            btnSalvar.Size = new Size(126, 36);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(165, 2);
            label7.Name = "label7";
            label7.Size = new Size(556, 50);
            label7.TabIndex = 14;
            label7.Text = "Registro de entrada de produtos";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConsultarRecebimentos
            // 
            btnConsultarRecebimentos.Anchor = AnchorStyles.Top;
            btnConsultarRecebimentos.BackColor = Color.Goldenrod;
            btnConsultarRecebimentos.BackgroundImage = Properties.Resources.procurar1;
            btnConsultarRecebimentos.BackgroundImageLayout = ImageLayout.Center;
            btnConsultarRecebimentos.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnConsultarRecebimentos.FlatAppearance.BorderSize = 0;
            btnConsultarRecebimentos.FlatStyle = FlatStyle.Flat;
            btnConsultarRecebimentos.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarRecebimentos.ForeColor = Color.White;
            btnConsultarRecebimentos.ImageAlign = ContentAlignment.TopCenter;
            btnConsultarRecebimentos.Location = new Point(139, 456);
            btnConsultarRecebimentos.Name = "btnConsultarRecebimentos";
            btnConsultarRecebimentos.Padding = new Padding(0, 0, 0, 4);
            btnConsultarRecebimentos.RightToLeft = RightToLeft.No;
            btnConsultarRecebimentos.Size = new Size(191, 121);
            btnConsultarRecebimentos.TabIndex = 15;
            btnConsultarRecebimentos.Text = "Consultar recebimentos";
            btnConsultarRecebimentos.TextAlign = ContentAlignment.BottomCenter;
            btnConsultarRecebimentos.UseVisualStyleBackColor = false;
            btnConsultarRecebimentos.Click += btnConsultarRecebimentos_Click;
            // 
            // btnCadastraRecebedor
            // 
            btnCadastraRecebedor.Anchor = AnchorStyles.Top;
            btnCadastraRecebedor.BackColor = Color.DodgerBlue;
            btnCadastraRecebedor.BackgroundImage = (Image)resources.GetObject("btnCadastraRecebedor.BackgroundImage");
            btnCadastraRecebedor.BackgroundImageLayout = ImageLayout.Center;
            btnCadastraRecebedor.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnCadastraRecebedor.FlatAppearance.BorderSize = 0;
            btnCadastraRecebedor.FlatStyle = FlatStyle.Flat;
            btnCadastraRecebedor.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastraRecebedor.ForeColor = SystemColors.ButtonHighlight;
            btnCadastraRecebedor.Location = new Point(587, 456);
            btnCadastraRecebedor.Name = "btnCadastraRecebedor";
            btnCadastraRecebedor.Padding = new Padding(0, 0, 0, 3);
            btnCadastraRecebedor.RightToLeft = RightToLeft.No;
            btnCadastraRecebedor.Size = new Size(191, 121);
            btnCadastraRecebedor.TabIndex = 18;
            btnCadastraRecebedor.Text = "Cadastrar Recebedor";
            btnCadastraRecebedor.TextAlign = ContentAlignment.BottomCenter;
            btnCadastraRecebedor.UseVisualStyleBackColor = false;
            btnCadastraRecebedor.Click += btnCadastraRecebedor_Click;
            // 
            // btnCadastraFornecedor
            // 
            btnCadastraFornecedor.Anchor = AnchorStyles.Top;
            btnCadastraFornecedor.BackColor = Color.MediumSlateBlue;
            btnCadastraFornecedor.BackgroundImage = (Image)resources.GetObject("btnCadastraFornecedor.BackgroundImage");
            btnCadastraFornecedor.BackgroundImageLayout = ImageLayout.Center;
            btnCadastraFornecedor.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnCadastraFornecedor.FlatAppearance.BorderSize = 0;
            btnCadastraFornecedor.FlatStyle = FlatStyle.Flat;
            btnCadastraFornecedor.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastraFornecedor.ForeColor = SystemColors.ButtonHighlight;
            btnCadastraFornecedor.Location = new Point(362, 456);
            btnCadastraFornecedor.Name = "btnCadastraFornecedor";
            btnCadastraFornecedor.Padding = new Padding(0, 0, 0, 4);
            btnCadastraFornecedor.RightToLeft = RightToLeft.No;
            btnCadastraFornecedor.Size = new Size(191, 121);
            btnCadastraFornecedor.TabIndex = 19;
            btnCadastraFornecedor.Text = "Cadastrar Fornecedor";
            btnCadastraFornecedor.TextAlign = ContentAlignment.BottomCenter;
            btnCadastraFornecedor.UseVisualStyleBackColor = false;
            btnCadastraFornecedor.Click += btnCadastraFornecedor_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(21, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 56);
            panel1.TabIndex = 25;
            // 
            // dgvRecebimento
            // 
            dgvRecebimento.BackgroundColor = Color.White;
            dgvRecebimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecebimento.Location = new Point(72, 225);
            dgvRecebimento.Name = "dgvRecebimento";
            dgvRecebimento.Size = new Size(781, 226);
            dgvRecebimento.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SAPGUI-Icons", 14.25F);
            label8.Location = new Point(384, 201);
            label8.Name = "label8";
            label8.Size = new Size(169, 21);
            label8.TabIndex = 27;
            label8.Text = "Últimos 10 recebimentos:";
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(925, 602);
            Controls.Add(label8);
            Controls.Add(dgvRecebimento);
            Controls.Add(panel1);
            Controls.Add(btnCadastraFornecedor);
            Controls.Add(btnCadastraRecebedor);
            Controls.Add(btnConsultarRecebimentos);
            Controls.Add(btnSalvar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtPickerDataRecebimento);
            Controls.Add(tBoxNumeroLote);
            Controls.Add(tBoxQuantidade);
            Controls.Add(tBoxMaterial);
            Controls.Add(tboxFornecedor);
            Controls.Add(comboBoxRecebedores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(941, 641);
            MinimumSize = new Size(941, 641);
            Name = "FormInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecvPB - Recebimento";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecebimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRecebedores;
        private TextBox tboxFornecedor;
        private TextBox tBoxMaterial;
        private TextBox tBoxQuantidade;
        private TextBox tBoxNumeroLote;
        private DateTimePicker dtPickerDataRecebimento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSalvar;
        private Label label7;
        private Button btnConsultarRecebimentos;
        private Button btnCadastraRecebedor;
        private Button btnCadastraFornecedor;
        private Panel panel1;
        private DataGridView dgvRecebimento;
        private Label label8;
    }
}
