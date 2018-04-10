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
        String cs = Properties.Settings.Default.ConnectionString;
        frmCadastro cadastro;
        public frmLogin()
        {
            InitializeComponent();
            cadastro = new frmCadastro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastro.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Por favor, preencha os campos corretamente.");
            }
            else {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = cs;

                    String consulta = "Select Usuario where email = @email and  senha = @senha";
                    SqlCommand cmd = new SqlCommand(consulta,con); //Representa um comando ou procedimento que sera feito bd
                    cmd.Parameters.AddWithValue("@email", txtName.Text);
                    cmd.Parameters.AddWithValue("@senha",txtName.Text);

                    SqlDataAdapter data = new SqlDataAdapter(); 
                    

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.ToString());
                }
            }
        }
    }
}
