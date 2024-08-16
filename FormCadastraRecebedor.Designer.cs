namespace RecvPB
{
    partial class FormCadastraRecebedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraRecebedor));
            btnVoltar = new Button();
            label1 = new Label();
            label7 = new Label();
            txtBoxNomeRecebedor = new TextBox();
            btnSalvar = new Button();
            dgvRecebedores = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRecebedores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnVoltar.Location = new Point(32, 527);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Padding = new Padding(0, 0, 0, 4);
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(860, 36);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.TopCenter;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SAPGUI-Icons", 14.25F);
            label1.Location = new Point(195, 85);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 25;
            label1.Text = "Nome do recebedor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(224, 3);
            label7.Name = "label7";
            label7.Size = new Size(448, 50);
            label7.TabIndex = 24;
            label7.Text = "Cadastrar novo recebedor";
            // 
            // txtBoxNomeRecebedor
            // 
            txtBoxNomeRecebedor.BorderStyle = BorderStyle.FixedSingle;
            txtBoxNomeRecebedor.Font = new Font("SAPGUI-Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNomeRecebedor.Location = new Point(192, 109);
            txtBoxNomeRecebedor.Name = "txtBoxNomeRecebedor";
            txtBoxNomeRecebedor.PlaceholderText = "  Insira o nome do funcionário que irá receber os produtos...";
            txtBoxNomeRecebedor.Size = new Size(527, 32);
            txtBoxNomeRecebedor.TabIndex = 23;
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
            btnSalvar.Location = new Point(192, 159);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(0, 0, 0, 4);
            btnSalvar.RightToLeft = RightToLeft.No;
            btnSalvar.Size = new Size(527, 36);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Cadastrar recebedor";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvRecebedores
            // 
            dgvRecebedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecebedores.BackgroundColor = Color.White;
            dgvRecebedores.BorderStyle = BorderStyle.Fixed3D;
            dgvRecebedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecebedores.Location = new Point(195, 214);
            dgvRecebedores.Name = "dgvRecebedores";
            dgvRecebedores.Size = new Size(527, 296);
            dgvRecebedores.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(21, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 56);
            panel1.TabIndex = 29;
            // 
            // FormCadastraRecebedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 575);
            Controls.Add(panel1);
            Controls.Add(dgvRecebedores);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(txtBoxNomeRecebedor);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastraRecebedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RecvPB - Cadastrar Recebedor";
            Load += FormCadastraRecebedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecebedores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label label1;
        private Label label7;
        private TextBox txtBoxNomeRecebedor;
        private Button btnSalvar;
        private DataGridView dgvRecebedores;
        private Panel panel1;
    }
}