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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnSalvar.Location = new Point(682, 104);
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(901, 349);
            dataGridView1.TabIndex = 15;
            // 
            // tboxFornecedor
            // 
            tboxFornecedor.BorderStyle = BorderStyle.FixedSingle;
            tboxFornecedor.Font = new Font("SAPGUI-Icons", 14.25F);
            tboxFornecedor.Location = new Point(140, 110);
            tboxFornecedor.Name = "tboxFornecedor";
            tboxFornecedor.Size = new Size(153, 30);
            tboxFornecedor.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Segoe UI", 27.75F);
            label7.ForeColor = Color.DodgerBlue;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(264, 9);
            label7.Name = "label7";
            label7.Size = new Size(419, 50);
            label7.TabIndex = 17;
            label7.Text = "Consultar Recebimentos";
            // 
            // FormConsultaRecebimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 602);
            Controls.Add(label7);
            Controls.Add(tboxFornecedor);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalvar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.NoControl;
            Name = "FormConsultaRecebimento";
            Text = "RecvPB - Consultar Recebimentos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private DataGridView dataGridView1;
        private TextBox tboxFornecedor;
        private Label label7;
    }
}