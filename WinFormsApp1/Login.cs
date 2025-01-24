using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            PreencherComboBoxUsuarios();

        }
      
        private void PreencherComboBoxUsuarios()
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MskUsuario.Focus();

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {

            string cpf = "";
            string senha = "";
            if (txtSenha.Text.Trim() == "")
            {
                LblIncorreto.Visible = true;
                LblIncorreto.ForeColor = Color.Red;
                MskUsuario.ForeColor = Color.Red;
                txtSenha.ForeColor = Color.Red;
            }
            else
            {
                string resultadoBD = InteracaoBD.InstanciaPublica().LoginUsuario(MskUsuario.Text, txtSenha.Text);

                if (resultadoBD == "nenhum")
                {
                    LblIncorreto.Visible = true;
                    LblIncorreto.ForeColor = Color.Red;
                    MskUsuario.ForeColor = Color.Red;
                    txtSenha.ForeColor = Color.Red;
                }
                else
                {
                    Form_Principal form2 = new Form_Principal();
                    form2.Show();

                    this.Hide();
                }
            }
        }

        private void MskUsuario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}