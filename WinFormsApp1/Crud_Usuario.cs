using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form_CRUD_Usuario : Form
    {
        public Form_CRUD_Usuario()
        {
            InitializeComponent();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxEscolha.SelectedIndex == 0)
            {
                LblCpf.Visible = true;
                lblNome.Visible = true;
                LblDtNasc.Visible = true;
                LblCadSenha.Visible = true;
                LblCargo.Visible = true;
                LblFun.Visible = true;

                MaskedCpf.Visible = true;
                txtNome.Visible = true;
                MaskedDtNasc.Visible = true;
                TxtSenha.Visible = true;
                TxtCargo.Visible = true;
                TxtFuncao.Visible = true;

                BtnAdd.Visible = true;
                BtnProcurar.Visible = false;
                BtnApagar.Visible = false;
            }
            else if (CboxEscolha.SelectedIndex == 1)
            {
                LblCpf.Visible = true;
                lblNome.Visible = false;
                LblDtNasc.Visible = false;
                LblCadSenha.Visible = false;
                LblCargo.Visible = false;
                LblFun.Visible = false;
                MaskedCpf.Visible = true;
                txtNome.Visible = false;
                MaskedDtNasc.Visible = false;
                TxtSenha.Visible = false;
                TxtCargo.Visible = false;
                TxtFuncao.Visible = false;

                BtnAdd.Visible = false;
                BtnProcurar.Visible = true;
                BtnApagar.Visible = false;
            }
            else
            {
                LblCpf.Visible = true;
                lblNome.Visible = false;
                LblDtNasc.Visible = false;
                LblCadSenha.Visible = false;
                LblCargo.Visible = false;
                LblFun.Visible = false;

                MaskedCpf.Visible = true;
                txtNome.Visible = false;
                MaskedDtNasc.Visible = false;
                TxtSenha.Visible = false;
                TxtCargo.Visible = false;
                TxtFuncao.Visible = false;

                BtnAdd.Visible = false;
                BtnProcurar.Visible = false;
                BtnAtualizar.Visible = false;
                BtnApagar.Visible = true;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            string cpf = "";
            string nome = "";
            string Data_Nasc = "";
            string Funcao = "";
            string Cargo = "";

            try
            {


                string Conexao = "Server = localhost; Database = Mercado; User Id = root; Password = ;";
                MySqlConnection conexao = new MySqlConnection(Conexao);

                MySqlCommand comando = new MySqlCommand();
                string sql;
                sql = "select * from Usuario where cpf = " + "('" + MaskedCpf.Text + "')";
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = sql;
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    cpf = dr.GetString(0);
                    nome = dr.GetString(1);
                    Data_Nasc = dr.GetString(2);
                    Funcao = dr.GetString(3);
                    Cargo = dr.GetString(4);

                }
                if (cpf.ToString() == "")
                {
                    MessageBox.Show("Não há nenhum registro no banco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblNome.Visible = true;
                    LblDtNasc.Visible = true;
                    LblCargo.Visible = true;
                    LblFun.Visible = true;
                    txtNome.Visible = true;
                    MaskedDtNasc.Visible = true;
                    TxtCargo.Visible = true;
                    TxtFuncao.Visible = true;
                    MaskedCpf.Text = cpf;
                    txtNome.Text = nome;
                    MaskedDtNasc.Text = Data_Nasc;
                    TxtFuncao.Text = Funcao;
                    TxtCargo.Text = Cargo;
                    TxtSenha.Visible= true;
                    LblCadSenha.Visible = true;
                    BtnAtualizar.Visible = true;
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MaskedCpf.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (MaskedDtNasc.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (TxtFuncao.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (TxtCargo.Text == "")
            {

                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
          
            else
            {
                bool resultadoBD = InteracaoBD.InstanciaPublica().AddUpdate(txtNome.Text, MaskedCpf.Text, MaskedDtNasc.Text, TxtFuncao.Text, TxtCargo.Text, TxtSenha.Text);

                if (resultadoBD == true)
                {
                    MessageBox.Show("Usuário atualizado com sucesso!", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar. Tente novamente mais tarde.", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server = localhost; database = Mercado; user ID = root; password = 123456;");
                int RowAffect = 0;
                MySqlCommand comando = new MySqlCommand();
                String sql;
                sql = "DELETE FROM Usuario WHERE Cpf = " + " '" + MaskedCpf.Text + "'";
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = sql;
                RowAffect = comando.ExecuteNonQuery();
                if (RowAffect == 1)
                {
                    MessageBox.Show("Deletado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Text = "";
                    MaskedDtNasc.Text = "";
                    TxtFuncao.Text = "";
                    TxtCargo.Text = "";
                    MaskedCpf.Focus();

                }
                else
                {

                    MessageBox.Show("Não foi possível deletar, verifique os campos nulos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MaskedCpf.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {


            if (MaskedCpf.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (MaskedDtNasc.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (TxtFuncao.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (TxtCargo.Text == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                bool resultadoBD = InteracaoBD.InstanciaPublica().AddUsuario(MaskedCpf.Text, txtNome.Text, MaskedDtNasc.Text, TxtFuncao.Text, TxtCargo.Text, TxtSenha.Text);

                if (resultadoBD == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Erro no cadastro do usuário. Tente novamente mais tarde.", "Aviso", MessageBoxButtons.OK);
                }
            }


        }

        private void MaskedDtNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}



