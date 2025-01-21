namespace WinFormsApp1
{
    partial class Form_Pix
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
            PboxPix = new PictureBox();
            BtnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)PboxPix).BeginInit();
            SuspendLayout();
            // 
            // PboxPix
            // 
            PboxPix.Image = Properties.Resources.Untitled;
            PboxPix.Location = new Point(96, 63);
            PboxPix.Name = "PboxPix";
            PboxPix.Size = new Size(308, 303);
            PboxPix.SizeMode = PictureBoxSizeMode.Zoom;
            PboxPix.TabIndex = 0;
            PboxPix.TabStop = false;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.FlatStyle = FlatStyle.Flat;
            BtnFinalizar.ForeColor = Color.Transparent;
            BtnFinalizar.Location = new Point(174, 389);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(166, 40);
            BtnFinalizar.TabIndex = 1;
            BtnFinalizar.Text = "Finalzar";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += button1_Click;
            // 
            // Form_Pix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 61, 66);
            ClientSize = new Size(490, 450);
            Controls.Add(BtnFinalizar);
            Controls.Add(PboxPix);
            Name = "Form_Pix";
            Text = "Qr-Code";
            ((System.ComponentModel.ISupportInitialize)PboxPix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PboxPix;
        private Button BtnFinalizar;
    }
}