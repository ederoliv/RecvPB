namespace RecvPB
{
    partial class FormCadastraFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraFornecedor));
            btnSalvar = new Button();
            tboxCodFornecedor = new TextBox();
            tboxNomeFornecedor = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnVoltar = new Button();
            dgvFornecedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
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
            btnSalvar.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(177, 179);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(0, 0, 0, 4);
            btnSalvar.RightToLeft = RightToLeft.No;
            btnSalvar.Size = new Size(527, 36);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Cadastrar fornecedor";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tboxCodFornecedor
            // 
            tboxCodFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tboxCodFornecedor.Font = new Font("SAPGUI-Icons", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxCodFornecedor.Location = new Point(181, 124);
            tboxCodFornecedor.Name = "tboxCodFornecedor";
            tboxCodFornecedor.Size = new Size(158, 35);
            tboxCodFornecedor.TabIndex = 15;
            // 
            // tboxNomeFornecedor
            // 
            tboxNomeFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tboxNomeFornecedor.Font = new Font("SAPGUI-Icons", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxNomeFornecedor.Location = new Point(368, 124);
            tboxNomeFornecedor.Name = "tboxNomeFornecedor";
            tboxNomeFornecedor.Size = new Size(340, 35);
            tboxNomeFornecedor.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(217, 9);
            label7.Name = "label7";
            label7.Size = new Size(462, 50);
            label7.TabIndex = 17;
            label7.Text = "Cadastrar novo fornecedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SAPGUI-Icons", 14.25F);
            label1.Location = new Point(368, 101);
            label1.Name = "label1";
            label1.Size = new Size(235, 21);
            label1.TabIndex = 18;
            label1.Text = "Nome/Razão Social do Fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SAPGUI-Icons", 14.25F);
            label2.Location = new Point(184, 101);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 19;
            label2.Text = "Código do Fornecedor:";
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top;
            btnVoltar.BackColor = Color.Goldenrod;
            btnVoltar.BackgroundImageLayout = ImageLayout.Center;
            btnVoltar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = SystemColors.ButtonHighlight;
            btnVoltar.Location = new Point(177, 527);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(0, 0, 0, 4);
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(527, 36);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.TopCenter;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedores.BackgroundColor = Color.White;
            dgvFornecedores.BorderStyle = BorderStyle.Fixed3D;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Location = new Point(177, 238);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.Size = new Size(527, 263);
            dgvFornecedores.TabIndex = 29;
            // 
            // FormCadastraFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 575);
            Controls.Add(dgvFornecedores);
            Controls.Add(btnVoltar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(tboxNomeFornecedor);
            Controls.Add(tboxCodFornecedor);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastraFornecedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RecvPB - Cadastrar Fornecedor";
            Load += FormCadastraFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox tboxCodFornecedor;
        private TextBox tboxNomeFornecedor;
        private Label label7;
        private Label label1;
        private Label label2;
        private Button btnVoltar;
        private DataGridView dgvFornecedores;
    }
}