namespace WinFormsApp1
{
    partial class Form_CRUD_Usuario
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
            CboxEscolha = new ComboBox();
            lblTitulo = new Label();
            LblCpf = new Label();
            TxtNome = new TextBox();
            lblNome = new Label();
            LblDtNasc = new Label();
            LblCadSenha = new Label();
            TxtSenha = new TextBox();
            LblCargo = new Label();
            TxtCargo = new TextBox();
            TxtFuncao = new TextBox();
            LblFun = new Label();
            BtnProcurar = new Button();
            BtnAtualizar = new Button();
            BtnApagar = new Button();
            MaskedCpf = new MaskedTextBox();
            MaskedDtNasc = new MaskedTextBox();
            BtnAdd = new Button();
            SuspendLayout();
            // 
            // CboxEscolha
            // 
            CboxEscolha.FormattingEnabled = true;
            CboxEscolha.Items.AddRange(new object[] { "Adicionar", "Procurar", "Delete" });
            CboxEscolha.Location = new Point(111, 93);
            CboxEscolha.Name = "CboxEscolha";
            CboxEscolha.Size = new Size(121, 23);
            CboxEscolha.TabIndex = 0;
            CboxEscolha.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("High Tower Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Snow;
            lblTitulo.Location = new Point(111, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(121, 26);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Você deseja";
            // 
            // LblCpf
            // 
            LblCpf.AutoSize = true;
            LblCpf.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblCpf.ForeColor = SystemColors.Window;
            LblCpf.Location = new Point(62, 175);
            LblCpf.Name = "LblCpf";
            LblCpf.Size = new Size(35, 19);
            LblCpf.TabIndex = 2;
            LblCpf.Text = "Cpf";
            LblCpf.Visible = false;
            LblCpf.Click += label2_Click;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(180, 207);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(100, 23);
            TxtNome.TabIndex = 4;
            TxtNome.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.Window;
            lblNome.Location = new Point(59, 211);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 19);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            lblNome.Visible = false;
            lblNome.Click += label3_Click;
            // 
            // LblDtNasc
            // 
            LblDtNasc.AutoSize = true;
            LblDtNasc.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblDtNasc.ForeColor = SystemColors.Window;
            LblDtNasc.Location = new Point(38, 240);
            LblDtNasc.Name = "LblDtNasc";
            LblDtNasc.Size = new Size(136, 19);
            LblDtNasc.TabIndex = 7;
            LblDtNasc.Text = "Data de nascimento";
            LblDtNasc.Visible = false;
            LblDtNasc.Click += label4_Click;
            // 
            // LblCadSenha
            // 
            LblCadSenha.AutoSize = true;
            LblCadSenha.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblCadSenha.ForeColor = SystemColors.Window;
            LblCadSenha.Location = new Point(38, 341);
            LblCadSenha.Name = "LblCadSenha";
            LblCadSenha.Size = new Size(112, 19);
            LblCadSenha.TabIndex = 13;
            LblCadSenha.Text = "Cadastrar senha";
            LblCadSenha.Visible = false;
            LblCadSenha.Click += label5_Click;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(180, 341);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(100, 23);
            TxtSenha.TabIndex = 12;
            TxtSenha.Visible = false;
            // 
            // LblCargo
            // 
            LblCargo.AutoSize = true;
            LblCargo.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblCargo.ForeColor = SystemColors.Window;
            LblCargo.Location = new Point(59, 307);
            LblCargo.Name = "LblCargo";
            LblCargo.Size = new Size(50, 19);
            LblCargo.TabIndex = 11;
            LblCargo.Text = "Cargo";
            LblCargo.Visible = false;
            LblCargo.Click += label6_Click;
            // 
            // TxtCargo
            // 
            TxtCargo.Location = new Point(180, 303);
            TxtCargo.Name = "TxtCargo";
            TxtCargo.Size = new Size(100, 23);
            TxtCargo.TabIndex = 10;
            TxtCargo.Visible = false;
            // 
            // TxtFuncao
            // 
            TxtFuncao.Location = new Point(180, 270);
            TxtFuncao.Name = "TxtFuncao";
            TxtFuncao.Size = new Size(100, 23);
            TxtFuncao.TabIndex = 9;
            TxtFuncao.Visible = false;
            // 
            // LblFun
            // 
            LblFun.AutoSize = true;
            LblFun.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblFun.ForeColor = SystemColors.Window;
            LblFun.Location = new Point(59, 274);
            LblFun.Name = "LblFun";
            LblFun.Size = new Size(57, 19);
            LblFun.TabIndex = 8;
            LblFun.Text = "Função";
            LblFun.Visible = false;
            LblFun.Click += label7_Click;
            // 
            // BtnProcurar
            // 
            BtnProcurar.FlatStyle = FlatStyle.Flat;
            BtnProcurar.Image = Properties.Resources.lupa__2_;
            BtnProcurar.Location = new Point(225, 370);
            BtnProcurar.Name = "BtnProcurar";
            BtnProcurar.Size = new Size(55, 49);
            BtnProcurar.TabIndex = 17;
            BtnProcurar.UseVisualStyleBackColor = true;
            BtnProcurar.Visible = false;
            BtnProcurar.Click += button2_Click;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.FlatStyle = FlatStyle.Flat;
            BtnAtualizar.Image = Properties.Resources.up;
            BtnAtualizar.Location = new Point(107, 370);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(52, 49);
            BtnAtualizar.TabIndex = 18;
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Visible = false;
            BtnAtualizar.Click += button3_Click;
            // 
            // BtnApagar
            // 
            BtnApagar.BackColor = Color.FromArgb(57, 61, 66);
            BtnApagar.FlatStyle = FlatStyle.Flat;
            BtnApagar.Image = Properties.Resources.menos;
            BtnApagar.Location = new Point(165, 370);
            BtnApagar.Name = "BtnApagar";
            BtnApagar.Size = new Size(54, 49);
            BtnApagar.TabIndex = 19;
            BtnApagar.UseVisualStyleBackColor = false;
            BtnApagar.Visible = false;
            BtnApagar.Click += button4_Click;
            // 
            // MaskedCpf
            // 
            MaskedCpf.Location = new Point(180, 171);
            MaskedCpf.Mask = "000,000,000-00";
            MaskedCpf.Name = "MaskedCpf";
            MaskedCpf.Size = new Size(100, 23);
            MaskedCpf.TabIndex = 20;
            MaskedCpf.Visible = false;
            // 
            // MaskedDtNasc
            // 
            MaskedDtNasc.Location = new Point(180, 240);
            MaskedDtNasc.Mask = "00/00/0000";
            MaskedDtNasc.Name = "MaskedDtNasc";
            MaskedDtNasc.Size = new Size(100, 23);
            MaskedDtNasc.TabIndex = 21;
            MaskedDtNasc.Visible = false;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(57, 61, 66);
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Image = Properties.Resources.mais__1_;
            BtnAdd.Location = new Point(46, 370);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(55, 49);
            BtnAdd.TabIndex = 22;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Visible = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // Form_CRUD_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 61, 66);
            ClientSize = new Size(335, 450);
            Controls.Add(BtnAdd);
            Controls.Add(MaskedDtNasc);
            Controls.Add(MaskedCpf);
            Controls.Add(BtnApagar);
            Controls.Add(BtnAtualizar);
            Controls.Add(BtnProcurar);
            Controls.Add(LblCadSenha);
            Controls.Add(TxtSenha);
            Controls.Add(LblCargo);
            Controls.Add(TxtCargo);
            Controls.Add(TxtFuncao);
            Controls.Add(LblFun);
            Controls.Add(LblDtNasc);
            Controls.Add(lblNome);
            Controls.Add(TxtNome);
            Controls.Add(LblCpf);
            Controls.Add(lblTitulo);
            Controls.Add(CboxEscolha);
            Name = "Form_CRUD_Usuario";
            Text = "CRUD Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CboxEscolha;
        private Label lblTitulo;
        private Label LblCpf;
        private TextBox TxtNome;
        private Label lblNome;
        private Label LblDtNasc;
        private Label LblCadSenha;
        private TextBox TxtSenha;
        private Label LblCargo;
        private TextBox TxtCargo;
        private TextBox TxtFuncao;
        private Label LblFun;
        private Label label8;
        private TextBox textBox7;
        private Button BtnCadastrar;
        private Button BtnProcurar;
        private Button BtnAtualizar;
        private Button BtnApagar;
        private MaskedTextBox MaskedCpf;
        private MaskedTextBox MaskedDtNasc;
        private Button BtnAdd;
    }
}