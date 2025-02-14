using MySql.Data.MySqlClient;
using System;
using WinFormsApp1;
using static System.Net.Mime.MediaTypeNames;

public class InteracaoBD
{
    private static InteracaoBD instanciaInterna;
    public static InteracaoBD InstanciaPublica()
    {
        if (instanciaInterna == null)
            instanciaInterna = new InteracaoBD();

        return instanciaInterna;
    }
    public string LoginUsuario(string cpf, string senha)
    {
        string tipoDoUsuario = "nenhum"; // Declaração de variável

        MySqlDataReader dr;
        {
            try
            {
                string Conexao = "Server = localhost; Database = Mercado; User Id = root; Password = ;";
                MySqlConnection conexao = new MySqlConnection(Conexao);

                MySqlCommand comando = new MySqlCommand();
                string sql;
                sql = "select Cpf, Senha, Funcao, Nome from Usuario where Cpf = ('" + cpf + "') and Senha =  (" + senha + ");";
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
                    conexao.Close();
                    return tipoDoUsuario; // Nenhum
                }
                else
                {
                    /*
                    Form_Principal form2 = new Form_Principal();
                    form2.Show();

                    this.Hide();
                    */
                    conexao.Close();

                    return variaveis.Perfil;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return tipoDoUsuario;
            }
        }
    }

    public bool AddUsuario(string cpf, string Nome, string DtNasc, string Funcao, string Cargo, string senha)
    {
        int RowAffect = 0;

        try
        {
            string strigConexao = "Server = localhost; Database = Mercado; User Id = root; Password = ;";
            MySqlConnection conexao = new MySqlConnection(strigConexao);

            MySqlCommand comando = new MySqlCommand();
            string sql;
            sql = "INSERT INTO Usuario (Cpf, Nome, Data_Nasc, Funcao, Cargo, Senha) VALUES " + "('" + cpf + "', '" + Nome + "', '" + DtNasc + "', '" + Funcao + "', '" + Cargo + "' , ' " + senha + "')";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql;

            RowAffect = comando.ExecuteNonQuery();

            if (RowAffect >= 1)
            {
                return true;
                //MessageBox.Show("Dados adicionados com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                return false;
               // MessageBox.Show("Ocorreu um erro ao tentar adicionar dados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;

        }

    }
    public bool AddUpdate(string Nome,string cpf,  string DtNasc, string Funcao, string Cargo, string senha)
    {
        int RowAffect = 0;

        try
        {
            MySqlConnection conexao = new MySqlConnection("Server = localhost; database = mercado; user ID = root; password = ;");
            
            MySqlCommand Comando = new MySqlCommand();
            String sql;
            sql = "UPDATE Usuario SET Nome = '" + Nome + "', Cpf = '" + cpf + "', Data_Nasc = '" + DtNasc + "', Funcao =  '" + Funcao + "', Cargo = '" + Cargo + "' WHERE Cpf = " + "'" + cpf + "'";
            conexao.Open();
            Comando.Connection = conexao;
            Comando.CommandText = sql;
            RowAffect = Comando.ExecuteNonQuery();

            if (RowAffect >= 1)
            {
                return true;
                //MessageBox.Show("Atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                conexao.Close();
                return false;
                
                // MessageBox.Show("Não foi possível atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }

        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false; 

            //MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados: " + ex.Message);
        }
    }
    public bool RemoverUsuario(string Nome, string cpf, string DtNasc, string Funcao, string Cargo, string senha)
    {
        int RowAffect = 0;
        MySqlDataReader dr;
        try
        {

            MySqlConnection conexao = new MySqlConnection("Server = localhost; database = Mercado; user ID = root; password = ;");
            //int RowAffect = 0;
            MySqlCommand comando = new MySqlCommand();
            String sql;
            sql = "DELETE FROM Usuario WHERE Cpf = " + " '" + cpf + "'";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql;
            RowAffect = comando.ExecuteNonQuery();
            if (RowAffect >= 1)
            {
                //MessageBox.Show("Deletado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Nome = "";
                //cpf = "";
                //DtNasc = "";
                //Funcao = "";
                //Cargo = "";
                //senha = "";
                //
                return true;
            }
            else
            {
                return false;
                //MessageBox.Show("Não foi possível deletar, verifique os campos nulos e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados: " + ex.Message);
            return false;
        }
    }

    public bool searchUsuario(string cpf, out string Nome, out string DtNasc, out string Funcao, out string Cargo)
    {
        MySqlDataReader dr;
        Nome = ""; DtNasc = ""; Funcao = ""; Cargo = "";
        try
        {


            string Conexao = "Server = localhost; Database = Mercado; User Id = root; Password = ;";
            MySqlConnection conexao = new MySqlConnection(Conexao);

            MySqlCommand comando = new MySqlCommand();
            string sql;
            sql = "select * from Usuario where cpf = " + "('" + cpf + "')";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql;
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cpf = dr.GetString(0);
                Nome = dr.GetString(1);
                DtNasc = dr.GetString(2);
                Funcao = dr.GetString(3);
                Cargo = dr.GetString(4);

            }
            conexao.Close();
            if (cpf.ToString() == "")
            {
                MessageBox.Show("Não há nenhum registro no banco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
            
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
    }

    public bool AddProduto( string Codigo, string Descricao, string Valor)
    {
        int RowAffect = 0;
        try
        {


            string strigConexao = "Server = localhost; Database = Mercado; User Id = root; Password = ;";
            MySqlConnection conexao = new MySqlConnection(strigConexao);

            MySqlCommand comando = new MySqlCommand();
            string sql;
            sql = "INSERT INTO Produtos (Produto, Descricao, Valor) VALUES (" + Codigo + ", '" + Descricao + "'," + Valor + ");";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql;
            if (Codigo == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (Descricao == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else if (Valor == "")
            {
                MessageBox.Show("Não é possivel salvar: Existe componentes em brancos", "Aviso", MessageBoxButtons.OK);
            }
            else
                RowAffect = comando.ExecuteNonQuery();

            if (RowAffect >= 1)
            {
                MessageBox.Show("Dados adicionados com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
                //TxtCodigo.Text = "";
                //TxtDescricao.Text = "";
                //TxtValor.Text = "";
                //TxtDescricao.Focus();

            }
            else if (RowAffect == 0)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar dados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro ao tentar acessar o banco" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
    }
         
}

