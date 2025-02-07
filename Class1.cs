using MySql.Data.MySqlClient;
using System;
using WinFormsApp1;

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
                return tipoDoUsuario;subindoo
            }
        }
    }

}
