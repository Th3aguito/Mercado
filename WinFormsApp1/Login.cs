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
            MySqlDataReader dr;
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



                try
                {
                    string Conexao = "Server = localhost; Database = Mercado; User Id = root; Password = ;";
                    MySqlConnection conexao = new MySqlConnection(Conexao);

                    MySqlCommand comando = new MySqlCommand();
                    string sql;
                    sql = "select Cpf, Senha, Funcao, Nome from Usuario where Cpf = ('" + MskUsuario.Text + "') and Senha =  (" + txtSenha.Text + ");";
                    conexao.Open();
                    comando.Connection = conexao;
                    comando.CommandText = sql;
                    dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        cpf = dr.GetString(0);
                        senha = dr.GetString(1);
                        variaveis.Perfil = dr.GetString(2);
                        variaveis.Usuario = dr.GetString(3);
                    }
                    if (cpf.ToString() == "" && senha.ToString() == "")
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
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MskUsuario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}