namespace WinFormsApp1
{
    partial class Form_CRUD_Produto
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
            BtnProcurarProduto = new Button();
            TxtDescricao = new TextBox();
            TxtValor = new TextBox();
            BtnAddProduto = new Button();
            BtnAtualizarProduto = new Button();
            BtnDeletarProduto = new Button();
            TxtCodigo = new TextBox();
            LblCodigo = new Label();
            LblDescricao = new Label();
            LblValor = new Label();
            SuspendLayout();
            // 
            // BtnProcurarProduto
            // 
            BtnProcurarProduto.BackColor = Color.FromArgb(57, 61, 66);
            BtnProcurarProduto.FlatStyle = FlatStyle.Flat;
            BtnProcurarProduto.Image = Properties.Resources.lupa__2_;
            BtnProcurarProduto.Location = new Point(198, 38);
            BtnProcurarProduto.Name = "BtnProcurarProduto";
            BtnProcurarProduto.Size = new Size(42, 43);
            BtnProcurarProduto.TabIndex = 1;
            BtnProcurarProduto.UseVisualStyleBackColor = false;
            BtnProcurarProduto.Click += button1_Click_1;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(85, 101);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(100, 23);
            TxtDescricao.TabIndex = 3;
            // 
            // TxtValor
            // 
            TxtValor.Location = new Point(85, 150);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(100, 23);
            TxtValor.TabIndex = 4;
            // 
            // BtnAddProduto
            // 
            BtnAddProduto.BackColor = Color.FromArgb(57, 61, 66);
            BtnAddProduto.FlatStyle = FlatStyle.Flat;
            BtnAddProduto.Image = Properties.Resources.mais__1_;
            BtnAddProduto.Location = new Point(18, 260);
            BtnAddProduto.Name = "BtnAddProduto";
            BtnAddProduto.Size = new Size(70, 58);
            BtnAddProduto.TabIndex = 5;
            BtnAddProduto.UseVisualStyleBackColor = false;
            BtnAddProduto.Click += button2_Click_1;
            // 
            // BtnAtualizarProduto
            // 
            BtnAtualizarProduto.BackColor = Color.FromArgb(57, 61, 66);
            BtnAtualizarProduto.FlatStyle = FlatStyle.Flat;
            BtnAtualizarProduto.Image = Properties.Resources.up;
            BtnAtualizarProduto.Location = new Point(94, 260);
            BtnAtualizarProduto.Name = "BtnAtualizarProduto";
            BtnAtualizarProduto.Size = new Size(70, 58);
            BtnAtualizarProduto.TabIndex = 6;
            BtnAtualizarProduto.UseVisualStyleBackColor = false;
            BtnAtualizarProduto.Click += button3_Click;
            // 
            // BtnDeletarProduto
            // 
            BtnDeletarProduto.BackColor = Color.FromArgb(57, 61, 66);
            BtnDeletarProduto.FlatStyle = FlatStyle.Flat;
            BtnDeletarProduto.Image = Properties.Resources.menos;
            BtnDeletarProduto.Location = new Point(170, 260);
            BtnDeletarProduto.Name = "BtnDeletarProduto";
            BtnDeletarProduto.Size = new Size(70, 58);
            BtnDeletarProduto.TabIndex = 7;
            BtnDeletarProduto.UseVisualStyleBackColor = false;
            BtnDeletarProduto.Click += button4_Click;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(85, 45);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(100, 23);
            TxtCodigo.TabIndex = 8;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblCodigo.ForeColor = SystemColors.Window;
            LblCodigo.Location = new Point(5, 45);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(58, 19);
            LblCodigo.TabIndex = 10;
            LblCodigo.Text = "Código";
            LblCodigo.Visible = false;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblDescricao.ForeColor = SystemColors.Window;
            LblDescricao.Location = new Point(5, 105);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(74, 19);
            LblDescricao.TabIndex = 11;
            LblDescricao.Text = "Descrição";
            LblDescricao.Visible = false;
            // 
            // LblValor
            // 
            LblValor.AutoSize = true;
            LblValor.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblValor.ForeColor = SystemColors.Window;
            LblValor.Location = new Point(5, 154);
            LblValor.Name = "LblValor";
            LblValor.Size = new Size(48, 19);
            LblValor.TabIndex = 12;
            LblValor.Text = "Valor";
            LblValor.Visible = false;
            // 
            // Form_CRUD_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 61, 66);
            ClientSize = new Size(252, 330);
            Controls.Add(LblValor);
            Controls.Add(LblDescricao);
            Controls.Add(LblCodigo);
            Controls.Add(TxtCodigo);
            Controls.Add(BtnDeletarProduto);
            Controls.Add(BtnAtualizarProduto);
            Controls.Add(BtnAddProduto);
            Controls.Add(TxtValor);
            Controls.Add(TxtDescricao);
            Controls.Add(BtnProcurarProduto);
            Name = "Form_CRUD_Produto";
            Text = "CRUD Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button BtnProcurarProduto;
        private Label label1;
        private TextBox TxtDescricao;
        private TextBox TxtValor;
        private Button BtnAddProduto;
        private Button BtnAtualizarProduto;
        private Button BtnDeletarProduto;
        private TextBox textBox3;
        private TextBox TxtCodigo;
        private Label lblTitulo;
        private Label LblCodigo;
        private Label LblDescricao;
        private Label LblValor;
    }
}