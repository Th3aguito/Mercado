namespace WinFormsApp1
{
    partial class Form_Login
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
            MskUsuario = new MaskedTextBox();
            txtSenha = new TextBox();
            lblsenha = new Label();
            lblusuario = new Label();
            lbllogin = new Label();
            BtnEntrar = new Button();
            LblIncorreto = new Label();
            SuspendLayout();
            // 
            // MskUsuario
            // 
            MskUsuario.Location = new Point(179, 153);
            MskUsuario.Mask = "000,000,000-00";
            MskUsuario.Name = "MskUsuario";
            MskUsuario.Size = new Size(155, 26);
            MskUsuario.TabIndex = 12;
            MskUsuario.MaskInputRejected += MskUsuario_MaskInputRejected;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(179, 206);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(155, 26);
            txtSenha.TabIndex = 11;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(90, 209);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(52, 19);
            lblsenha.TabIndex = 10;
            lblsenha.Text = "Senha:";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(90, 156);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(66, 19);
            lblusuario.TabIndex = 9;
            lblusuario.Text = "Usúario:";
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("High Tower Text", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbllogin.Location = new Point(179, 16);
            lbllogin.Margin = new Padding(4, 0, 4, 0);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(97, 39);
            lbllogin.TabIndex = 8;
            lbllogin.Text = "Login";
            // 
            // BtnEntrar
            // 
            BtnEntrar.ForeColor = SystemColors.ActiveCaptionText;
            BtnEntrar.Location = new Point(196, 293);
            BtnEntrar.Margin = new Padding(4);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(124, 35);
            BtnEntrar.TabIndex = 7;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += button1_Click_1;
            // 
            // LblIncorreto
            // 
            LblIncorreto.AutoSize = true;
            LblIncorreto.Font = new Font("Humnst777 BlkCn BT", 12F, FontStyle.Italic, GraphicsUnit.Point);
            LblIncorreto.ForeColor = Color.FromArgb(57, 61, 66);
            LblIncorreto.Location = new Point(165, 269);
            LblIncorreto.Name = "LblIncorreto";
            LblIncorreto.Size = new Size(189, 20);
            LblIncorreto.TabIndex = 13;
            LblIncorreto.Text = "Usúario ou senha inorreta";
            LblIncorreto.Visible = false;
            // 
            // Form_Login
            // 
            AcceptButton = BtnEntrar;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 61, 66);
            ClientSize = new Size(470, 344);
            Controls.Add(LblIncorreto);
            Controls.Add(MskUsuario);
            Controls.Add(txtSenha);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Controls.Add(BtnEntrar);
            Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(4);
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxUsuarios;
        private MaskedTextBox MskUsuario;
        private TextBox txtSenha;
        private Label lblsenha;
        private Label lblusuario;
        private Label lbllogin;
        private Button BtnEntrar;
        private Label LblIncorreto;
    }
}