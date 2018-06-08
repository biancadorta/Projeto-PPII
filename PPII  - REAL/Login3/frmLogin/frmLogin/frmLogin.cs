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
using System.Security.Cryptography;


namespace frmLogin
{

    public partial class frmLogin : Form
    {
        String cs = Properties.Settings.Default.ConnectionString1;
        Principal.Principal p;
        public frmLogin()
        {
            InitializeComponent();
            p = new Principal.Principal();
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

                    String consulta = "Select email,senha from Usuario " +
                                      "where email = @email and  senha = @senha";
                    SqlCommand cmd = new SqlCommand(consulta, con); //Representa um comando ou procedimento que sera feito bd
                    cmd.Parameters.AddWithValue("@email", txtName.Text);
                    cmd.Parameters.AddWithValue("@senha", Codificar(txtSenha.Text));

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
                        p.Show();
                        p.setEmail(txtName.Text);
                        this.Hide();
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

                    if (consulta(txtEmail.Text.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtUsu.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@senha", Codificar(txtSenhaCad.Text)); //codificar senha 
                        //MessageBox.Show(Codificar(txtSenhaCad.Text).Length.ToString());
                        cmd.Parameters.AddWithValue("@pontuacao", 0);
                        con.Open();

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Cadastro feito com sucesso.");
                            txtEmail.Clear();
                            txtSenhaCad.Clear();
                            txtUsu.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erro no cadastro, tente-o novamente.");
                            txtEmail.Clear();
                            txtSenha.Clear();
                            txtUsu.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Já existe um usuário com este email");
                        txtName.Clear();
                        txtSenha.Clear();
                        txtEmail.Clear();
                    }
                
                }              

                catch (SqlException erro)
                {
                    MessageBox.Show("Erro1: " + erro.Message.ToString());
                }
            }
        }

        private bool consulta(string text)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = cs;
            string str = "select email from Usuario where email=@email";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@email", text);            

            con.Open(); //Abre a conexao com o banco de dados;

            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data.Fill(ds);
            con.Close();//fecha a conexao

            if (ds.Tables[0].Rows.Count == 0) //Se não retornou nada do bd
            {
                return true;
            }
            else
            {
                return false;
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
            txtSenha.PasswordChar = '*';

        }
        public static string Codificar(string entrada)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(entrada);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

    }
}
