

namespace RecvPB
{
    partial class Form1
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
            btnSobre = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBoxRecebedores
            // 
            comboBoxRecebedores.Font = new Font("SAPGUI-Icons", 14.25F);
            comboBoxRecebedores.FormattingEnabled = true;
            comboBoxRecebedores.Location = new Point(588, 166);
            comboBoxRecebedores.Name = "comboBoxRecebedores";
            comboBoxRecebedores.Size = new Size(184, 29);
            comboBoxRecebedores.TabIndex = 0;
            // 
            // tboxFornecedor
            // 
            tboxFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tboxFornecedor.Font = new Font("SAPGUI-Icons", 14.25F);
            tboxFornecedor.Location = new Point(132, 166);
            tboxFornecedor.Name = "tboxFornecedor";
            tboxFornecedor.Size = new Size(153, 30);
            tboxFornecedor.TabIndex = 1;
            // 
            // tBoxMaterial
            // 
            tBoxMaterial.BorderStyle = BorderStyle.FixedSingle;
            tBoxMaterial.Font = new Font("SAPGUI-Icons", 14.25F);
            tBoxMaterial.Location = new Point(132, 239);
            tBoxMaterial.Name = "tBoxMaterial";
            tBoxMaterial.Size = new Size(153, 30);
            tBoxMaterial.TabIndex = 2;
            // 
            // tBoxQuantidade
            // 
            tBoxQuantidade.BorderStyle = BorderStyle.FixedSingle;
            tBoxQuantidade.Font = new Font("SAPGUI-Icons", 14.25F);
            tBoxQuantidade.Location = new Point(353, 236);
            tBoxQuantidade.Name = "tBoxQuantidade";
            tBoxQuantidade.Size = new Size(153, 30);
            tBoxQuantidade.TabIndex = 3;
            // 
            // tBoxNumeroLote
            // 
            tBoxNumeroLote.BorderStyle = BorderStyle.FixedSingle;
            tBoxNumeroLote.Font = new Font("SAPGUI-Icons", 14.25F);
            tBoxNumeroLote.Location = new Point(588, 236);
            tBoxNumeroLote.Name = "tBoxNumeroLote";
            tBoxNumeroLote.Size = new Size(153, 30);
            tBoxNumeroLote.TabIndex = 4;
            // 
            // dtPickerDataRecebimento
            // 
            dtPickerDataRecebimento.Checked = false;
            dtPickerDataRecebimento.DropDownAlign = LeftRightAlignment.Right;
            dtPickerDataRecebimento.Font = new Font("SAPGUI-Icons", 14.25F);
            dtPickerDataRecebimento.Format = DateTimePickerFormat.Short;
            dtPickerDataRecebimento.Location = new Point(353, 166);
            dtPickerDataRecebimento.Name = "dtPickerDataRecebimento";
            dtPickerDataRecebimento.Size = new Size(131, 30);
            dtPickerDataRecebimento.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SAPGUI-Icons", 14.25F);
            label1.Location = new Point(132, 145);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 6;
            label1.Text = "Fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SAPGUI-Icons", 14.25F);
            label2.Location = new Point(353, 145);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 7;
            label2.Text = "Data Recebimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SAPGUI-Icons", 14.25F);
            label3.Location = new Point(588, 145);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 8;
            label3.Text = "Recebido Por:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SAPGUI-Icons", 14.25F);
            label4.Location = new Point(132, 215);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 9;
            label4.Text = "Material:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SAPGUI-Icons", 14.25F);
            label5.Location = new Point(353, 215);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 10;
            label5.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SAPGUI-Icons", 14.25F);
            label6.Location = new Point(588, 215);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 11;
            label6.Text = "Número Lote:";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top;
            btnSalvar.BackColor = Color.DodgerBlue;
            btnSalvar.BackgroundImageLayout = ImageLayout.Center;
            btnSalvar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(132, 298);
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
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(185, 44);
            label7.Name = "label7";
            label7.Size = new Size(556, 50);
            label7.TabIndex = 14;
            label7.Text = "Registro de entrada de produtos";
            // 
            // btnConsultarRecebimentos
            // 
            btnConsultarRecebimentos.Anchor = AnchorStyles.Top;
            btnConsultarRecebimentos.BackColor = Color.Goldenrod;
            btnConsultarRecebimentos.BackgroundImageLayout = ImageLayout.Center;
            btnConsultarRecebimentos.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnConsultarRecebimentos.FlatAppearance.BorderSize = 0;
            btnConsultarRecebimentos.FlatStyle = FlatStyle.Flat;
            btnConsultarRecebimentos.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarRecebimentos.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarRecebimentos.Location = new Point(133, 500);
            btnConsultarRecebimentos.Name = "btnConsultarRecebimentos";
            btnConsultarRecebimentos.Padding = new Padding(0, 0, 0, 4);
            btnConsultarRecebimentos.RightToLeft = RightToLeft.No;
            btnConsultarRecebimentos.Size = new Size(191, 36);
            btnConsultarRecebimentos.TabIndex = 15;
            btnConsultarRecebimentos.Text = "Consultar recebimentos";
            btnConsultarRecebimentos.TextAlign = ContentAlignment.TopCenter;
            btnConsultarRecebimentos.UseVisualStyleBackColor = false;
            btnConsultarRecebimentos.Click += btnConsultarRecebimentos_Click;
            // 
            // btnSobre
            // 
            btnSobre.Anchor = AnchorStyles.Top;
            btnSobre.BackColor = Color.LightSeaGreen;
            btnSobre.BackgroundImageLayout = ImageLayout.Center;
            btnSobre.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSobre.ForeColor = SystemColors.ButtonHighlight;
            btnSobre.Location = new Point(133, 554);
            btnSobre.Name = "btnSobre";
            btnSobre.Padding = new Padding(0, 0, 0, 4);
            btnSobre.RightToLeft = RightToLeft.No;
            btnSobre.Size = new Size(639, 36);
            btnSobre.TabIndex = 16;
            btnSobre.Text = "Sobre";
            btnSobre.TextAlign = ContentAlignment.TopCenter;
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.MediumSlateBlue;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(354, 500);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 0, 4);
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(191, 36);
            button1.TabIndex = 17;
            button1.Text = "Cadastrar Fonecedor";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Brown;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(581, 500);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 0, 4);
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(191, 36);
            button2.TabIndex = 18;
            button2.Text = "Cadastrar Fonecedor";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(925, 602);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSobre);
            Controls.Add(btnConsultarRecebimentos);
            Controls.Add(label7);
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
            Name = "Form1";
            Text = "RecvPB - Recebimento";
            Load += Form1_Load;
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
        private Button btnSobre;
        private Button button1;
        private Button button2;
    }
}
