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
            string cpf, Nome, DtNasc, Funcao, Cargo;
            bool resultadoBD = InteracaoBD.InstanciaPublica().searchUsuario(MaskedCpf.Text,out Nome, out DtNasc, out Funcao, out Cargo);

            if(resultadoBD== true)
            {
                lblNome.Visible = true;
                LblDtNasc.Visible = true;
                LblCargo.Visible = true;
                LblFun.Visible = true;
                txtNome.Visible = true;
                MaskedDtNasc.Visible = true;
                TxtCargo.Visible = true;
                TxtFuncao.Visible = true;
                txtNome.Text = Nome;
                MaskedDtNasc.Text = DtNasc;
                TxtFuncao.Text = Funcao;
                TxtCargo.Text = Cargo;
                TxtSenha.Visible = true;
                LblCadSenha.Visible = true;
                BtnAtualizar.Visible = true;
            }
            else
            {

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
            bool resultadoBD = InteracaoBD.InstanciaPublica().RemoverUsuario(txtNome.Text, MaskedCpf.Text, MaskedDtNasc.Text, TxtFuncao.Text, TxtCargo.Text, TxtSenha.Text);

            if(resultadoBD == true)
            {
                MessageBox.Show("Usuário removido com sucesso!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Usuário não removido, tente novamente!", "Aviso", MessageBoxButtons.OK);
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



