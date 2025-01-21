using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form_Acao : Form
    {
        public Form_Acao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int opcao;
            try
            {


                opcao = int.Parse(txtacao.Text);

                if (opcao != 6)
                {
                    if (variaveis.Perfil == "Atendente")
                    {
                        MessageBox.Show("Você não está autorizado");
                    }
                    else
                    {
                        switch (opcao)
                        {
                            case 1:
                                {
                                    MySqlDataReader dr;
                                    string Cargo = "";

                                    Form_CRUD_Usuario form5 = new Form_CRUD_Usuario();
                                    form5.Show();
                                    this.Hide();  
                                    break;
                                }



                            case 2:
                                {
                                    Form_CRUD_Usuario form5 = new Form_CRUD_Usuario();
                                    form5.Show();
                                    this.Hide();
                                    break;

                                }
                            case 3:
                                {
                                    Form_CRUD_Usuario form5 = new Form_CRUD_Usuario();
                                    form5.Show();
                                    this.Hide();
                                    break;

                                }
                            case 4:
                                {
                                    Form_CRUD_Usuario form5 = new Form_CRUD_Usuario();
                                    form5.Show();
                                    this.Hide();
                                    break;

                                }
                            case 5:
                                {
                                    Form_CRUD_Produto form6 = new Form_CRUD_Produto();
                                    form6.Show();
                                    this.Hide();
                                    break;


                                }
                            case 7:
                                {
                                    Form_CRUD_Produto form6 = new Form_CRUD_Produto();
                                    form6.Show();
                                    this.Hide();
                                    break;
                                }
                            case 8:
                                {
                                    Form_CRUD_Produto form6 = new Form_CRUD_Produto();
                                    form6.Show();
                                    this.Hide();
                                    break;
                                }
                            case 9:
                                {
                                    Form_CRUD_Produto form6 = new Form_CRUD_Produto();
                                    form6.Show();
                                    this.Hide();
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    Form_CRUD_Produto form6 = new Form_CRUD_Produto();
                    form6.Show();
                    this.Hide();

                }
            }

            catch (Exception ex)
            {
                LblCatch.Visible = true;    
            }
        }
    }
}
