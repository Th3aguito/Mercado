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
    public partial class Form_Principal : Form
    {
        double Soma, Preco_final;
        public Form_Principal()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LblOperador.Text = variaveis.Usuario.ToString();

        }

        private void Form2_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F:
                    txtcodigo.Text = string.Empty;
                    Form_Acao form3 = new Form_Acao();
                    form3.Show();

                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            string Produto = "";
            string Descricao = "";
            string Valor = "";

            try
            {


                string Conexao = "Server = localhost; Database = Mercado; User Id = root; Password = 123456;";
                MySqlConnection conexao = new MySqlConnection(Conexao);

                MySqlCommand comando = new MySqlCommand();
                string sql;
                sql = "select * from Produtos where Produto = " + txtcodigo.Text + ";";
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
                    double total = 0, quantidade = 0;
                    txtcodigo.Text = Produto;
                    txtpreco.Text = Descricao;
                    txtpreco.Text = Valor;

                    quantidade = double.Parse(mskquantidade.Text);
                    total = double.Parse(txtpreco.Text);
                    double Preco_produto = total * quantidade;

                    txttotal.Text = Preco_produto.ToString();
                    LboxNotas.Items.Add(Produto + " | " + Descricao + " | " + quantidade + " | " + "R$ " + Preco_produto);
                    Preco_final = Preco_final + Preco_produto;
                    LblPrecoFinal.Text = Preco_final.ToString();
                    LblPreenchaUni.Visible = false;
                    LblPreenchaUni.ForeColor = Color.Black;
                    lblPreenchaNome.Visible = false;
                    lblPreenchaNome.ForeColor = Color.Black;
                    txtcodigo.Focus();
                    txtcodigo.Text = "";
                    mskquantidade.Text = "1";
                    txtpreco.Text = "";
                    txttotal.Text = "";

                }
                conexao.Close();
            }
            //catch ()
            //{
            //    MessageBox.Show("Preencha os campos em brancos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    lblPreenchaNome.Visible = true;
            //    lblPreenchaNome.ForeColor = Color.Red;
            //}
            catch (FormatException ex)
            {
                MessageBox.Show("Preencha os campos em brancos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblPreenchaUni.Visible = true;
                LblPreenchaUni.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            gbtroco.Visible = true;
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            gbtroco.Visible = false;
            button2_Click(sender, e);
        }

        private void btnCrédito_Click(object sender, EventArgs e)
        {
            gbtroco.Visible = false;
            button2_Click(sender, e);
        }

        private void btnPix_Click(object sender, EventArgs e)
        {

            Form_Pix form4 = new Form_Pix();
            form4.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {



            string texto;
            RtxtNota.Text = LboxNotas.Text;
            foreach (var item in LboxNotas.Items)
            {
                texto = item.ToString();
                RtxtNota.Text = RtxtNota.Text + texto;
            }
            if (RtxtNota.Text == "Codigo | Descrição | Unidades | Valor")
            {
                MessageBox.Show("Inicie uma nova compra", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                try
                {
                    MySqlConnection conexao = new MySqlConnection("Server = localhost; database = Mercado; user ID = root; password = 123456;");
                    int RowAffect = 0;
                    MySqlCommand Comando = new MySqlCommand();
                    String sql;
                    sql = "Insert into Cupom_Fiscal (Cupom) values ('" + RtxtNota.Text + "'); ";
                    conexao.Open();
                    Comando.Connection = conexao;
                    Comando.CommandText = sql;
                    RowAffect = Comando.ExecuteNonQuery();
                    if (RowAffect == 1)
                    {
                        MessageBox.Show("Venda Finalizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LboxNotas.Items.Clear();
                        LboxNotas.Items.Add(LboxNotas.Text = "Codigo | Descrição | Unidades | Valor\n");
                        LblPrecoFinal.Text = "";
                        LblDevolver.Text = "";
                        txtvalorrecebido.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível finalizar a venda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conexao.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados: " + ex.Message);
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (LblPrecoFinal.Text == "")
            {
                MessageBox.Show("Inicie uma nova compra", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {


                double valor_recebido, valor_final, valor_Compra;
                valor_Compra = double.Parse(LblPrecoFinal.Text);
                valor_recebido = double.Parse(txtvalorrecebido.Text);
                valor_final = valor_recebido - valor_Compra;
                LblDevolver.Text = valor_final.ToString("C2");
                if (valor_final < 0)
                {
                    lblTroco.Text = "Faltam ";
                    valor_final = valor_recebido - valor_Compra;
                    LblDevolver.Text = valor_final.ToString();


                }
                else
                {
                    lblTroco.Text = "Troco ";
                    BtnFinalizar.Visible = true;
                }
            }

        }
    }
}

