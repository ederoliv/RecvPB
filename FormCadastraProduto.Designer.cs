namespace RecvPB
{
    partial class FormCadastraProduto
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
            panel1 = new Panel();
            label3 = new Label();
            dgvFornecedores = new DataGridView();
            btnVoltar = new Button();
            label2 = new Label();
            label1 = new Label();
            tboxNomeFornecedor = new TextBox();
            tboxCodFornecedor = new TextBox();
            btnSalvar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 56);
            panel1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(320, 11);
            label3.Name = "label3";
            label3.Size = new Size(267, 32);
            label3.TabIndex = 24;
            label3.Text = "Cadastrar novo produto";
            label3.Click += label3_Click;
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedores.BackgroundColor = Color.White;
            dgvFornecedores.BorderStyle = BorderStyle.Fixed3D;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Location = new Point(196, 204);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.Size = new Size(527, 305);
            dgvFornecedores.TabIndex = 38;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top;
            btnVoltar.BackColor = Color.Black;
            btnVoltar.BackgroundImageLayout = ImageLayout.Center;
            btnVoltar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = SystemColors.ButtonHighlight;
            btnVoltar.Location = new Point(196, 521);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(0, 0, 0, 4);
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(527, 36);
            btnVoltar.TabIndex = 37;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.TopCenter;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SAPGUI-Icons", 14.25F);
            label2.Location = new Point(199, 77);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 36;
            label2.Text = "Código do Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SAPGUI-Icons", 14.25F);
            label1.Location = new Point(386, 77);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 35;
            label1.Text = "Descrição do Produto";
            // 
            // tboxNomeFornecedor
            // 
            tboxNomeFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tboxNomeFornecedor.Font = new Font("SAPGUI-Icons", 15.75F);
            tboxNomeFornecedor.Location = new Point(383, 100);
            tboxNomeFornecedor.Name = "tboxNomeFornecedor";
            tboxNomeFornecedor.PlaceholderText = "  Ex: MOTOR 1CV 4P D56 110/220V 60HZ";
            tboxNomeFornecedor.Size = new Size(340, 32);
            tboxNomeFornecedor.TabIndex = 34;
            // 
            // tboxCodFornecedor
            // 
            tboxCodFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tboxCodFornecedor.Font = new Font("SAPGUI-Icons", 15.75F);
            tboxCodFornecedor.Location = new Point(196, 100);
            tboxCodFornecedor.Name = "tboxCodFornecedor";
            tboxCodFornecedor.PlaceholderText = "   Ex: P1234";
            tboxCodFornecedor.Size = new Size(158, 32);
            tboxCodFornecedor.TabIndex = 33;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top;
            btnSalvar.BackColor = SystemColors.Highlight;
            btnSalvar.BackgroundImageLayout = ImageLayout.Center;
            btnSalvar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(196, 154);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(0, 0, 0, 4);
            btnSalvar.RightToLeft = RightToLeft.No;
            btnSalvar.Size = new Size(527, 36);
            btnSalvar.TabIndex = 32;
            btnSalvar.Text = "Cadastrar Produto";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastraProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 575);
            Controls.Add(dgvFornecedores);
            Controls.Add(btnVoltar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tboxNomeFornecedor);
            Controls.Add(tboxCodFornecedor);
            Controls.Add(btnSalvar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastraProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormCadastraProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private DataGridView dgvFornecedores;
        private Button btnVoltar;
        private Label label2;
        private Label label1;
        private TextBox tboxNomeFornecedor;
        private TextBox tboxCodFornecedor;
        private Button btnSalvar;
    }
}