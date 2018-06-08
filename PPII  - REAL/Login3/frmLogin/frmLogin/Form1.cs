using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Principal
{
    public partial class Form1 : Form
    {
        String cs = Properties.Settings.Default.ConnectionString;
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtUsu.Text.Equals("") || txtSenha.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Por favor, preencha os campos corretamente.");
                return;
            }
            else
            {
                try
                {
                    // 1 - Estabelecer a conexao 
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = cs;
                    string str = "Insert into Usuario values(@nome,@email,@senha,@pontuacao)";
                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.Parameters.AddWithValue("@nome", txtUsu.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    //cmd.Parameters.AddWithValue("@senha", txtSenha.Text); //codificar senha
                    cmd.Parameters.AddWithValue("@pontuacao", 0);
                    con.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Cadastro feito com sucesso.");
                        
                        //login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro, tente-o novamente.");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtUsu.Clear();
                    }

                    // 2 - Pegar os dados preenchidos
                    // 3 - Fazer o insert no BD 
                    // 4 - Depois de tudo finalizado, voltar para o frmLogin para que ele logue

                }
                catch (SqlException erro)
                {
                    MessageBox.Show("Erro: " + erro.Message.ToString());
                }
            }
        }

        private void lCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void lblLogar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }
    }
}
