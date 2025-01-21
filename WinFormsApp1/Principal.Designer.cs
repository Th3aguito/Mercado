namespace WinFormsApp1
{
    partial class Form_Principal
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
            lblnomeusuario = new Label();
            dateTimePicker1 = new DateTimePicker();
            GboxNotas = new GroupBox();
            LboxNotas = new ListBox();
            RtxtNota = new RichTextBox();
            GboxCaixa = new GroupBox();
            lblPreenchaNome = new Label();
            LblPreenchaUni = new Label();
            BtnAddItem = new Button();
            txttotal = new TextBox();
            txtpreco = new TextBox();
            LblPrecoT = new Label();
            LblPrecoU = new Label();
            mskquantidade = new MaskedTextBox();
            LblQuantidade = new Label();
            txtcodigo = new TextBox();
            LblCodigo = new Label();
            lbltitulo = new Label();
            gbPagamento = new GroupBox();
            LblPrecoFinal = new Label();
            btnPix = new Button();
            btnCrédito = new Button();
            btnDebito = new Button();
            btnDinheiro = new Button();
            LblPreco = new Label();
            txtvalorrecebido = new TextBox();
            gbtroco = new GroupBox();
            LblDevolver = new Label();
            BtnConfirmDinheiro = new Button();
            BtnFinalizar = new Button();
            LblValorRecebido = new Label();
            lblTroco = new Label();
            LblOperador = new Label();
            Lblcaixa = new Label();
            GboxNotas.SuspendLayout();
            GboxCaixa.SuspendLayout();
            gbPagamento.SuspendLayout();
            gbtroco.SuspendLayout();
            SuspendLayout();
            // 
            // lblnomeusuario
            // 
            lblnomeusuario.AutoSize = true;
            lblnomeusuario.Location = new Point(570, 561);
            lblnomeusuario.Name = "lblnomeusuario";
            lblnomeusuario.Size = new Size(0, 15);
            lblnomeusuario.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(771, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // GboxNotas
            // 
            GboxNotas.Controls.Add(LboxNotas);
            GboxNotas.Controls.Add(RtxtNota);
            GboxNotas.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GboxNotas.ForeColor = SystemColors.ControlLightLight;
            GboxNotas.Location = new Point(252, 56);
            GboxNotas.Name = "GboxNotas";
            GboxNotas.Size = new Size(768, 331);
            GboxNotas.TabIndex = 10;
            GboxNotas.TabStop = false;
            GboxNotas.Text = "Cliente";
            // 
            // LboxNotas
            // 
            LboxNotas.FormattingEnabled = true;
            LboxNotas.ItemHeight = 19;
            LboxNotas.Items.AddRange(new object[] { "Codigo | Descrição | Unidades | Valor" });
            LboxNotas.Location = new Point(6, 25);
            LboxNotas.Name = "LboxNotas";
            LboxNotas.Size = new Size(756, 289);
            LboxNotas.TabIndex = 0;
            // 
            // RtxtNota
            // 
            RtxtNota.Location = new Point(177, 185);
            RtxtNota.Name = "RtxtNota";
            RtxtNota.Size = new Size(100, 96);
            RtxtNota.TabIndex = 1;
            RtxtNota.Text = "";
            // 
            // GboxCaixa
            // 
            GboxCaixa.Controls.Add(lblPreenchaNome);
            GboxCaixa.Controls.Add(LblPreenchaUni);
            GboxCaixa.Controls.Add(BtnAddItem);
            GboxCaixa.Controls.Add(txttotal);
            GboxCaixa.Controls.Add(txtpreco);
            GboxCaixa.Controls.Add(LblPrecoT);
            GboxCaixa.Controls.Add(LblPrecoU);
            GboxCaixa.Controls.Add(mskquantidade);
            GboxCaixa.Controls.Add(LblQuantidade);
            GboxCaixa.Controls.Add(txtcodigo);
            GboxCaixa.Controls.Add(LblCodigo);
            GboxCaixa.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GboxCaixa.ForeColor = SystemColors.ControlLightLight;
            GboxCaixa.Location = new Point(12, 70);
            GboxCaixa.Name = "GboxCaixa";
            GboxCaixa.Size = new Size(234, 317);
            GboxCaixa.TabIndex = 9;
            GboxCaixa.TabStop = false;
            GboxCaixa.Text = "Caixa";
            // 
            // lblPreenchaNome
            // 
            lblPreenchaNome.AutoSize = true;
            lblPreenchaNome.Font = new Font("High Tower Text", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreenchaNome.Location = new Point(105, 88);
            lblPreenchaNome.Name = "lblPreenchaNome";
            lblPreenchaNome.Size = new Size(57, 14);
            lblPreenchaNome.TabIndex = 16;
            lblPreenchaNome.Text = "*Preencha";
            lblPreenchaNome.Visible = false;
            // 
            // LblPreenchaUni
            // 
            LblPreenchaUni.AutoSize = true;
            LblPreenchaUni.Font = new Font("High Tower Text", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LblPreenchaUni.Location = new Point(112, 156);
            LblPreenchaUni.Name = "LblPreenchaUni";
            LblPreenchaUni.Size = new Size(57, 14);
            LblPreenchaUni.TabIndex = 15;
            LblPreenchaUni.Text = "*Preencha";
            LblPreenchaUni.Visible = false;
            // 
            // BtnAddItem
            // 
            BtnAddItem.BackColor = Color.FromArgb(57, 61, 66);
            BtnAddItem.FlatStyle = FlatStyle.Flat;
            BtnAddItem.Location = new Point(177, 58);
            BtnAddItem.Name = "BtnAddItem";
            BtnAddItem.Size = new Size(36, 26);
            BtnAddItem.TabIndex = 14;
            BtnAddItem.UseVisualStyleBackColor = false;
            BtnAddItem.Click += button1_Click;
            // 
            // txttotal
            // 
            txttotal.Enabled = false;
            txttotal.Location = new Point(8, 270);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(153, 26);
            txttotal.TabIndex = 7;
            // 
            // txtpreco
            // 
            txtpreco.Enabled = false;
            txtpreco.Location = new Point(6, 196);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(156, 26);
            txtpreco.TabIndex = 6;
            // 
            // LblPrecoT
            // 
            LblPrecoT.AutoSize = true;
            LblPrecoT.Location = new Point(6, 238);
            LblPrecoT.Name = "LblPrecoT";
            LblPrecoT.Size = new Size(89, 19);
            LblPrecoT.TabIndex = 5;
            LblPrecoT.Text = "Preço Total";
            // 
            // LblPrecoU
            // 
            LblPrecoU.AutoSize = true;
            LblPrecoU.Location = new Point(5, 174);
            LblPrecoU.Name = "LblPrecoU";
            LblPrecoU.Size = new Size(108, 19);
            LblPrecoU.TabIndex = 4;
            LblPrecoU.Text = "Preço Unitário";
            // 
            // mskquantidade
            // 
            mskquantidade.Location = new Point(6, 127);
            mskquantidade.Mask = "000";
            mskquantidade.Name = "mskquantidade";
            mskquantidade.Size = new Size(155, 26);
            mskquantidade.TabIndex = 3;
            mskquantidade.Text = "1";
            mskquantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // LblQuantidade
            // 
            LblQuantidade.AutoSize = true;
            LblQuantidade.Location = new Point(6, 105);
            LblQuantidade.Name = "LblQuantidade";
            LblQuantidade.Size = new Size(84, 19);
            LblQuantidade.TabIndex = 2;
            LblQuantidade.Text = "Quantidade";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(6, 59);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(155, 26);
            txtcodigo.TabIndex = 1;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(6, 37);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(58, 19);
            LblCodigo.TabIndex = 0;
            LblCodigo.Text = "Código";
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BorderStyle = BorderStyle.Fixed3D;
            lbltitulo.Font = new Font("High Tower Text", 29.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbltitulo.ForeColor = SystemColors.Menu;
            lbltitulo.Location = new Point(351, 8);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(323, 46);
            lbltitulo.TabIndex = 8;
            lbltitulo.Text = "CAIXA RÁPIDO";
            // 
            // gbPagamento
            // 
            gbPagamento.Controls.Add(LblPrecoFinal);
            gbPagamento.Controls.Add(btnPix);
            gbPagamento.Controls.Add(btnCrédito);
            gbPagamento.Controls.Add(btnDebito);
            gbPagamento.Controls.Add(btnDinheiro);
            gbPagamento.Controls.Add(LblPreco);
            gbPagamento.ForeColor = Color.White;
            gbPagamento.Location = new Point(12, 394);
            gbPagamento.Margin = new Padding(3, 2, 3, 2);
            gbPagamento.Name = "gbPagamento";
            gbPagamento.Padding = new Padding(3, 2, 3, 2);
            gbPagamento.Size = new Size(552, 182);
            gbPagamento.TabIndex = 14;
            gbPagamento.TabStop = false;
            gbPagamento.Text = "Forma de pagamento";
            // 
            // LblPrecoFinal
            // 
            LblPrecoFinal.AutoSize = true;
            LblPrecoFinal.Font = new Font("High Tower Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblPrecoFinal.Location = new Point(132, 39);
            LblPrecoFinal.Name = "LblPrecoFinal";
            LblPrecoFinal.Size = new Size(0, 26);
            LblPrecoFinal.TabIndex = 8;
            // 
            // btnPix
            // 
            btnPix.ForeColor = Color.Black;
            btnPix.Location = new Point(417, 84);
            btnPix.Margin = new Padding(3, 2, 3, 2);
            btnPix.Name = "btnPix";
            btnPix.Size = new Size(118, 36);
            btnPix.TabIndex = 10;
            btnPix.Text = "Pix";
            btnPix.UseVisualStyleBackColor = true;
            btnPix.Click += btnPix_Click;
            // 
            // btnCrédito
            // 
            btnCrédito.ForeColor = Color.Black;
            btnCrédito.Location = new Point(277, 84);
            btnCrédito.Margin = new Padding(3, 2, 3, 2);
            btnCrédito.Name = "btnCrédito";
            btnCrédito.Size = new Size(118, 36);
            btnCrédito.TabIndex = 9;
            btnCrédito.Text = "Crédito";
            btnCrédito.UseVisualStyleBackColor = true;
            btnCrédito.Click += btnCrédito_Click;
            // 
            // btnDebito
            // 
            btnDebito.ForeColor = Color.Black;
            btnDebito.Location = new Point(146, 84);
            btnDebito.Margin = new Padding(3, 2, 3, 2);
            btnDebito.Name = "btnDebito";
            btnDebito.Size = new Size(118, 36);
            btnDebito.TabIndex = 8;
            btnDebito.Text = "Débito";
            btnDebito.UseVisualStyleBackColor = true;
            btnDebito.Click += btnDebito_Click;
            // 
            // btnDinheiro
            // 
            btnDinheiro.ForeColor = SystemColors.WindowText;
            btnDinheiro.Location = new Point(5, 84);
            btnDinheiro.Margin = new Padding(3, 2, 3, 2);
            btnDinheiro.Name = "btnDinheiro";
            btnDinheiro.Size = new Size(118, 36);
            btnDinheiro.TabIndex = 5;
            btnDinheiro.Text = "Dinheiro";
            btnDinheiro.UseVisualStyleBackColor = true;
            btnDinheiro.Click += btnDinheiro_Click;
            // 
            // LblPreco
            // 
            LblPreco.AutoSize = true;
            LblPreco.Font = new Font("High Tower Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblPreco.Location = new Point(8, 39);
            LblPreco.Name = "LblPreco";
            LblPreco.Size = new Size(129, 26);
            LblPreco.TabIndex = 0;
            LblPreco.Text = "Preço Final : ";
            // 
            // txtvalorrecebido
            // 
            txtvalorrecebido.Location = new Point(201, 63);
            txtvalorrecebido.Margin = new Padding(3, 2, 3, 2);
            txtvalorrecebido.Name = "txtvalorrecebido";
            txtvalorrecebido.Size = new Size(130, 23);
            txtvalorrecebido.TabIndex = 3;
            // 
            // gbtroco
            // 
            gbtroco.Controls.Add(LblDevolver);
            gbtroco.Controls.Add(BtnConfirmDinheiro);
            gbtroco.Controls.Add(BtnFinalizar);
            gbtroco.Controls.Add(LblValorRecebido);
            gbtroco.Controls.Add(lblTroco);
            gbtroco.Controls.Add(txtvalorrecebido);
            gbtroco.ForeColor = Color.White;
            gbtroco.Location = new Point(570, 394);
            gbtroco.Margin = new Padding(3, 2, 3, 2);
            gbtroco.Name = "gbtroco";
            gbtroco.Padding = new Padding(3, 2, 3, 2);
            gbtroco.Size = new Size(464, 182);
            gbtroco.TabIndex = 15;
            gbtroco.TabStop = false;
            gbtroco.Text = "Dinheiro";
            gbtroco.Visible = false;
            // 
            // LblDevolver
            // 
            LblDevolver.AutoSize = true;
            LblDevolver.Font = new Font("High Tower Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblDevolver.Location = new Point(155, 97);
            LblDevolver.Name = "LblDevolver";
            LblDevolver.Size = new Size(0, 26);
            LblDevolver.TabIndex = 17;
            // 
            // BtnConfirmDinheiro
            // 
            BtnConfirmDinheiro.BackColor = Color.White;
            BtnConfirmDinheiro.ForeColor = SystemColors.WindowText;
            BtnConfirmDinheiro.Location = new Point(375, 97);
            BtnConfirmDinheiro.Margin = new Padding(3, 2, 3, 2);
            BtnConfirmDinheiro.Name = "BtnConfirmDinheiro";
            BtnConfirmDinheiro.Size = new Size(75, 23);
            BtnConfirmDinheiro.TabIndex = 11;
            BtnConfirmDinheiro.Text = "Confirmar";
            BtnConfirmDinheiro.UseVisualStyleBackColor = false;
            BtnConfirmDinheiro.Click += button2_Click_1;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.BackColor = Color.White;
            BtnFinalizar.ForeColor = Color.Black;
            BtnFinalizar.Location = new Point(375, 136);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(75, 23);
            BtnFinalizar.TabIndex = 16;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.UseVisualStyleBackColor = false;
            BtnFinalizar.Visible = false;
            BtnFinalizar.Click += button2_Click;
            // 
            // LblValorRecebido
            // 
            LblValorRecebido.AutoSize = true;
            LblValorRecebido.Font = new Font("High Tower Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblValorRecebido.Location = new Point(16, 57);
            LblValorRecebido.Name = "LblValorRecebido";
            LblValorRecebido.Size = new Size(158, 26);
            LblValorRecebido.TabIndex = 7;
            LblValorRecebido.Text = "Valor Recebido:";
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("High Tower Text", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTroco.Location = new Point(77, 96);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(72, 26);
            lblTroco.TabIndex = 2;
            lblTroco.Text = "Troco:";
            // 
            // LblOperador
            // 
            LblOperador.AutoSize = true;
            LblOperador.Location = new Point(586, 589);
            LblOperador.Name = "LblOperador";
            LblOperador.Size = new Size(38, 15);
            LblOperador.TabIndex = 16;
            LblOperador.Text = "label1";
            // 
            // Lblcaixa
            // 
            Lblcaixa.AutoSize = true;
            Lblcaixa.Location = new Point(517, 589);
            Lblcaixa.Name = "Lblcaixa";
            Lblcaixa.Size = new Size(63, 15);
            Lblcaixa.TabIndex = 17;
            Lblcaixa.Text = "Operador :";
            // 
            // Form_Principal
            // 
            AcceptButton = BtnAddItem;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 61, 66);
            ClientSize = new Size(1046, 613);
            Controls.Add(Lblcaixa);
            Controls.Add(LblOperador);
            Controls.Add(gbPagamento);
            Controls.Add(gbtroco);
            Controls.Add(lblnomeusuario);
            Controls.Add(dateTimePicker1);
            Controls.Add(GboxNotas);
            Controls.Add(GboxCaixa);
            Controls.Add(lbltitulo);
            ForeColor = Color.White;
            Name = "Form_Principal";
            Text = "Mercado";
            Closing += Form2_Closing;
            Load += Form2_Load;
            GboxNotas.ResumeLayout(false);
            GboxCaixa.ResumeLayout(false);
            GboxCaixa.PerformLayout();
            gbPagamento.ResumeLayout(false);
            gbPagamento.PerformLayout();
            gbtroco.ResumeLayout(false);
            gbtroco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnomeusuario;
        private Label lblusuario;
        private DateTimePicker dateTimePicker1;
        private GroupBox GboxNotas;
        private RichTextBox richClientes;
        private GroupBox GboxCaixa;
        private TextBox txttotal;
        private TextBox txtpreco;
        private Label LblPrecoT;
        private Label LblPrecoU;
        private MaskedTextBox mskquantidade;
        private Label LblQuantidade;
        private TextBox txtcodigo;
        private Label LblCodigo;
        private Label lbltitulo;
        private Button BtnAddItem;
        private ListBox LboxNotas;
        private Label LblPreco;
        private GroupBox gbPagamento;
        private Button btnPix;
        private Button btnCrédito;
        private Button btnDebito;
        private Button btnDinheiro;
        private Label lblValor;
        private TextBox txtvalorrecebido;
        private GroupBox gbtroco;
        private Label lblTroco;
        private Label LblValorRecebido;
        private Label LblPrecoFinal;
        private Label LblPreenchaUni;
        private Label lblPreenchaNome;
        private Button BtnFinalizar;
        private RichTextBox richTextBox1;
        private RichTextBox RtxtNota;
        private Button BtnConfirmDinheiro;
        private Label LblDevolver;
        private Label LblOperador;
        private Label Lblcaixa;
    }
}