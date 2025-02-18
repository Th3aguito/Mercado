using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form_CRUD_Produto : Form
    {
        public Form_CRUD_Produto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            MySqlDataReader dr;
            string Produto = "";
            string Descricao = "";
            string Valor = "";
            if (variaveis.Perfil == "Atendente")
            {
                BtnAddProduto.Enabled = false;
                BtnAtualizarProduto.Enabled = false;
                BtnDeletarProduto.Enabled = false;
            }


            try
            {




                string Conexao = "Server = localhost; Database = Mercado; User Id = root; Password = ;";
                MySqlConnection conexao = new MySqlConnection(Conexao);

                MySqlCommand comando = new MySqlCommand();
                string sql;
                sql = "select * from Produtos where Produto = " + TxtCodigo.Text + ";";
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = sql;
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Produto = dr.GetInt32(0).ToString();
                    Descricao = dr.GetString(1);
                    Valor = dr.GetString(2);

                }
                if (Produto.ToString() == "" && Descricao.ToString() == "" && Valor.ToString() == "")
                {
                    MessageBox.Show("Não há nenhum registro no banco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TxtCodigo.Text = Produto;
                    TxtDescricao.Text = Descricao;
                    TxtValor.Text = Valor;
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void button2_Click_1(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (variaveis.Perfil != "Atendente")
            {
                bool resultadoBd = InteracaoBD.InstanciaPublica().AtualizarProduto(TxtCodigo.Text, TxtDescricao.Text, TxtValor.Text);
                if (resultadoBd == true)
                {
                    TxtCodigo.Text = "";
                    TxtDescricao.Text = "";
                    TxtValor.Text = "";
                    TxtCodigo.Focus();
                }
                else
                {

                    MessageBox.Show("Não foi possível Atualizar, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCodigo.Focus();
                }

            }
            BtnDeletarProduto.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (variaveis.Perfil != "Atendente")
                if (TxtCodigo.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);


                }
                else if (TxtDescricao.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);

                }
                else if (TxtValor.Text == "")
                {
                    MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);

                }
                else
                {
                    
                bool resultadoBd = InteracaoBD.InstanciaPublica().DeletarProduto(TxtCodigo.Text, TxtDescricao.Text, TxtValor.Text);
                if (resultadoBd == true)
                {
                    TxtCodigo.Text = "";
                    TxtDescricao.Text = "";
                    TxtValor.Text = "";
                    TxtCodigo.Focus();
                }
                else
                {

                    MessageBox.Show("Não foi possível deletar, verifique os campos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCodigo.Focus();
                }

            }
        }

            private void Click_ButtonAddProduto(object sender, EventArgs e)
            {
                if (variaveis.Perfil != "Atendente")
                {
                    if (TxtCodigo.Text == "")
                    {
                        MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);


                    }
                    else if (TxtDescricao.Text == "")
                    {
                        MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);

                    }
                    else if (TxtValor.Text == "")
                    {
                        MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);

                    }
                    else
                    {
                        bool resultadoBD = InteracaoBD.InstanciaPublica().AddProduto(TxtCodigo.Text, TxtDescricao.Text, TxtValor.Text);
                        if (resultadoBD == true)
                        {
                            MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCodigo.Text = "";
                            TxtDescricao.Text = "";
                            TxtValor.Text = "";
                            TxtDescricao.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar produto, tente novamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                MessageBox.Show("Você não esta autorizado");

            }
        }
    }

