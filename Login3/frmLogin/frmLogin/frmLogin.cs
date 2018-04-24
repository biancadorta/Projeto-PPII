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

namespace frmLogin
{
   
    public partial class frmLogin : Form
    {
        String cs = Properties.Settings.Default.ConnectionString;
        public frmLogin()
        {
            InitializeComponent();
        }
       
        private void lCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogar.Hide();
            panelCadastrar.Show();
        }

        private void btnLogar_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Por favor, preencha os campos corretamente.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = cs;

                    String consulta = "Select email from Usuario " +
                                      "where email = @email and  senha = @senha";
                    SqlCommand cmd = new SqlCommand(consulta, con); //Representa um comando ou procedimento que sera feito bd
                    cmd.Parameters.AddWithValue("@email", txtName.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                    con.Open(); //Abre a conexao com o banco de dados;

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    data.Fill(ds);
                    con.Close();//fecha a conexao

                    if (ds.Tables[0].Rows.Count == 0) //Se não retornou nada do bd
                    {
                        MessageBox.Show("Não está cadastrado...");
                        txtName.Clear();
                        txtSenha.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Está cadastrado :)");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsu.Text.Equals("") || txtSenhaCad.Text.Equals("") || txtEmail.Text.Equals(""))
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
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtUsu.Clear();
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

        private void lLogar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelCadastrar.Hide();
            panelLogar.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelCadastrar.Hide();
            panelLogar.Show();
            txtSenhaCad.PasswordChar = '*';
            
        }

        private void panelCadastrar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
