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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
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
                        "              where email = @email and  senha = @senha";
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
                        throw new Exception("Não está cadastrado.");
                    }
                    else
                    {
                        principal.Show();
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
            }
        }
    }
}
