namespace WinFormsApp1
{
    partial class Form_Acao
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
            lblação = new Label();
            txtacao = new TextBox();
            lstCRUD = new ListBox();
            BtnAcessar = new Button();
            LblCatch = new Label();
            SuspendLayout();
            // 
            // lblação
            // 
            lblação.AutoSize = true;
            lblação.Font = new Font("High Tower Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblação.ForeColor = SystemColors.Window;
            lblação.Location = new Point(20, 29);
            lblação.Name = "lblação";
            lblação.Size = new Size(237, 26);
            lblação.TabIndex = 0;
            lblação.Text = "Digite o número da ação:";
            // 
            // txtacao
            // 
            txtacao.Location = new Point(324, 36);
            txtacao.Name = "txtacao";
            txtacao.Size = new Size(112, 21);
            txtacao.TabIndex = 1;
            // 
            // lstCRUD
            // 
            lstCRUD.BackColor = Color.FromArgb(57, 61, 66);
            lstCRUD.Font = new Font("High Tower Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lstCRUD.ForeColor = SystemColors.Window;
            lstCRUD.FormattingEnabled = true;
            lstCRUD.ItemHeight = 26;
            lstCRUD.Items.AddRange(new object[] { "01-Cadastrar funcionario", "02-Buscar funcionario", "03-Atualizar funcionario", "04-Excluir Usuario", "05-Cadastrar produto", "06-Buscar produto", "07-Atualizar produto", "09-Apagar produto" });
            lstCRUD.Location = new Point(12, 81);
            lstCRUD.Name = "lstCRUD";
            lstCRUD.Size = new Size(580, 290);
            lstCRUD.TabIndex = 2;
            // 
            // BtnAcessar
            // 
            BtnAcessar.BackColor = Color.Transparent;
            BtnAcessar.FlatStyle = FlatStyle.Flat;
            BtnAcessar.ForeColor = Color.White;
            BtnAcessar.Location = new Point(255, 377);
            BtnAcessar.Name = "BtnAcessar";
            BtnAcessar.Size = new Size(111, 23);
            BtnAcessar.TabIndex = 3;
            BtnAcessar.Text = "Acessar";
            BtnAcessar.UseVisualStyleBackColor = false;
            BtnAcessar.Click += button1_Click;
            // 
            // LblCatch
            // 
            LblCatch.AutoSize = true;
            LblCatch.Font = new Font("High Tower Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LblCatch.ForeColor = Color.Red;
            LblCatch.Location = new Point(303, 60);
            LblCatch.Name = "LblCatch";
            LblCatch.Size = new Size(152, 16);
            LblCatch.TabIndex = 4;
            LblCatch.Text = "Insira um número de 1 a 9";
            LblCatch.Visible = false;
            // 
            // Form_Acao
            // 
            AcceptButton = BtnAcessar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 61, 66);
            ClientSize = new Size(610, 405);
            Controls.Add(LblCatch);
            Controls.Add(BtnAcessar);
            Controls.Add(lstCRUD);
            Controls.Add(txtacao);
            Controls.Add(lblação);
            Font = new Font("High Tower Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form_Acao";
            Text = "Ação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblação;
        private TextBox txtacao;
        private ListBox lstCRUD;
        private Button BtnAcessar;
        private Label LblCatch;
    }
}