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

namespace Login
{
    public partial class frmCadastro : Form
    {
        String cs = Properties.Settings.Default.ConnectionString;
        public frmCadastro()
        {
            InitializeComponent();
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
                    string str = "Insert into Usuario values(@email,@usuario,@senha)";
                    SqlCommand cmd = new SqlCommand(str,con);
                    cmd.Parameters.AddWithValue("@email",txtEmail.Text);
                    cmd.Parameters.AddWithValue("@usuario",txtUsu.Text);
                    cmd.Parameters.AddWithValue("@usuario", txtSenha.Text); //codificar senha
                    con.Open();

                    if(cmd.ExecuteNonQuery() == 1){
                        MessageBox.Show("Cadastro feito com sucesso.");
                        //Form.Close();
                        //frmLogin.Open();                        
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
                    MessageBox.Show("Erro: /n" + erro.Message);
                }
            }
        }
    }
}
