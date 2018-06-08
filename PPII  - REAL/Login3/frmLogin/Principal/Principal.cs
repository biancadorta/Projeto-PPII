using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : Form
    {
        DragDrop drag;
        String cs = Properties.Settings.Default.ConnectionString1;
        frmQuiz quiz;
        String email = "";
        public Principal()
        {
            InitializeComponent();           
            drag = new DragDrop(this);
            quiz = new frmQuiz(this, drag);
           
            
        }
        private void conexao(int var)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = cs;

                String consulta = "Select informacoes from Astro " +
                                  "where codAstro = @codAstro";
                SqlCommand cmd = new SqlCommand(consulta, con); //Representa um comando ou procedimento que sera feito bd
                cmd.Parameters.AddWithValue("@codAstro", var);

                con.Open(); //Abre a conexao com o banco de dados;

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                con.Close();//fecha a conexao
                lblInfo.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro.Message);
            }
        }

        public void setEmail(String e)
        {
            this.email = e;
        }

        public string getEmail()
        {
            return this.email;
        }
        private void arrastarPlanetinhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drag.Show();
            this.Hide();            
        }

        private void arrastarPlanetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                drag.Show();
                this.Hide();          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.conexao(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.conexao(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.conexao(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.conexao(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.conexao(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.conexao(7);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.conexao(8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.conexao(9);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.conexao(1);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void bookOfImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookOfImagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void perguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar o formulario do Quizz
            quiz.Show();
            this.Hide();
        }
    }
}
