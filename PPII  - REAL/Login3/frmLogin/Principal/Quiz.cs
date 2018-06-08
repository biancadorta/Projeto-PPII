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
    public partial class frmQuiz : Form
    {
        Principal princ;
        DragDrop d;
        String a, b, c, resposta, pergunta;
        String email = "";
        int aux = 0;
        String cs = Properties.Settings.Default.ConnectionString1;
        int pontos;
        private int r = 0;
        private int tam = 0;
        private int auxR = 0;
        private int[] questoesErradas = new int[16];  
        private int i = 0;

        public frmQuiz(Principal prin, DragDrop dr)
        {
            InitializeComponent();
            princ = prin;
            d = dr;            
        }

        private void aprenderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            princ.Show();
            this.Hide();
        }

        private void perguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.Show();
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private void picProx_Click(object sender, EventArgs e)
        {
            if (aux < 16)
            {
                aux++; //aumentá-lo para pegar no BD, até chegar na ultima pergunta
                lblQuestao.Text = "Questão " + aux;
            }

            if (aux <= 16) //ver se ja chegou no ultimo, se for menor ou igual buscar no BD, se nao mostrar a pontuacao final do usuário
            {
                SqlConnection conexao = new SqlConnection(cs);
                String conPerg = "Select pergunta,resposta,a, b, c from pergunta where codPergunta = @cod";
                SqlCommand cmd = new SqlCommand(conPerg, conexao);
                cmd.Parameters.AddWithValue("@cod", aux);
                conexao.Open();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                conexao.Close(); //fecha a conexao
                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0]; //Pegar o valor que foi trazido do banco na primeira linha
                    pergunta = dr.ItemArray[0].ToString();
                    resposta = dr.ItemArray[1].ToString();
                    a = dr.ItemArray[2].ToString();
                    b = dr.ItemArray[3].ToString();
                    c = dr.ItemArray[4].ToString();
                    lblInformacao.Text = pergunta;
                    rb1.Text = a;
                    rb2.Text = b;
                    rb3.Text = c;
                    btnSalvar.Enabled = true;

                    if (aux == 16)
                    {
                        lbMensagem.Visible = true;
                        lblRefazer.Visible = true;
                        MessageBox.Show("Parabéns pelo desempenho hoje!!!");
                        if (i == 1)
                            lbMensagem.Text = "Você errou " + i + " questão deseja refazê-la?";
                        else
                            lbMensagem.Text = "Você errou " + i + " questões, deseja refazê-las?";

                        picProx.Enabled = false;
                    }
                }
            }
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!(rb1.Checked || rb2.Checked || rb3.Checked))
                MessageBox.Show("Selecione uma resposta para enviar.");
            else
            {
                //pegar a resposta que ele deu e validar buscando no BD
                String respUsuario = "";
                if (rb1.Checked)
                    respUsuario = rb1.Text;
                else
                    if (rb2.Checked)
                    respUsuario = rb2.Text;
                else
                    respUsuario = rb3.Text;

                SqlConnection con = new SqlConnection(cs);
                String consulta = "Select resposta from pergunta where codPergunta = @aux";
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@aux", aux);
                con.Open();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                con.Close();
                DataRow dr = ds.Tables[0].Rows[0]; //Pegar o valor que foi trazido do banco na primeira linha
                resposta = dr.ItemArray[0].ToString();  //pegando o valor correto da resposta

                if (resposta.Equals(respUsuario)) //Ele acertou a quetão  acrescentar na pontuacao dele 
                {
                    this.email = princ.getEmail();
                    SqlConnection conexao = new SqlConnection(cs);
                    string cons = "UPDATE Usuario set pontuacao = pontuacao + 10 where email = @email";
                    SqlCommand command = new SqlCommand(cons, conexao);
                    command.Parameters.AddWithValue("@email", this.email);
                    conexao.Open();
                    SqlDataAdapter dataAd = new SqlDataAdapter(command);
                    DataSet dset = new DataSet();
                    dataAd.Fill(dset);
                    conexao.Close();

                    SqlConnection cone = new SqlConnection(cs);
                    string consul = "select pontuacao from Usuario where email = @em";
                    SqlCommand commando = new SqlCommand(consul, cone);
                    commando.Parameters.AddWithValue("@em", this.email);
                    SqlDataAdapter dataa = new SqlDataAdapter(commando);
                    DataSet d = new DataSet();
                    dataa.Fill(d);
                    DataRow dr2 = d.Tables[0].Rows[0];
                    pontos = (int)dr2.ItemArray[0];
                    txtPontuacao.Text = pontos.ToString();
                    conexao.Close(); //fecha a conexao
                }
                else //errou a questão, fazer algo para ajudá-lo a refazê-la
                {
                    questoesErradas[i] = aux;
                    i++;
                    MessageBox.Show("Errou a questão");
                }
            }
            btnSalvar.Enabled = false;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviarR_Click(object sender, EventArgs e)
        {
            btnEnviarR.Enabled = false; //para que ele nao envia a mesma resposta mais de uma vez
            if (r  == tam-1) //nao ha porque deixar enabled true se ja acabou
                pbProximoRefazer.Enabled = false;
            //valido a a questao
            String respUsuarioR = "";
            if (rb1Refazer.Checked)
                respUsuarioR = rb1Refazer.Text;
            else
                if (rb2Refazer.Checked)
                respUsuarioR = rb2Refazer.Text;
            else
                respUsuarioR = rb3refazer.Text;

            try
            {
                SqlConnection con = new SqlConnection(cs);
                String consulta = "Select resposta from pergunta where codPergunta = @aux";
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@aux", auxR);
                con.Open();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                con.Close();
                DataRow dr = ds.Tables[0].Rows[0]; //Pegar o valor que foi trazido do banco na primeira linha
                resposta = dr.ItemArray[0].ToString();  //pegando o valor correto da resposta

                if (resposta.Equals(respUsuarioR)) //Ele acertou a quetão  acrescentar na pontuacao dele 
                {
                    this.email = princ.getEmail();
                    SqlConnection conexao = new SqlConnection(cs);
                    string cons = "UPDATE Usuario set pontuacao = pontuacao + 10 where email = @email";
                    SqlCommand command = new SqlCommand(cons, conexao);
                    command.Parameters.AddWithValue("@email", this.email);
                    conexao.Open();
                    SqlDataAdapter dataAd = new SqlDataAdapter(command);
                    DataSet dset = new DataSet();
                    dataAd.Fill(dset);
                    conexao.Close();

                    SqlConnection cone = new SqlConnection(cs);
                    string consul = "select pontuacao from Usuario where email = @em";
                    SqlCommand commando = new SqlCommand(consul, cone);
                    commando.Parameters.AddWithValue("@em", this.email);
                    SqlDataAdapter dataa = new SqlDataAdapter(commando);
                    DataSet d = new DataSet();
                    dataa.Fill(d);
                    DataRow dr2 = d.Tables[0].Rows[0];
                    pontos = (int)dr2.ItemArray[0];
                    txtPontuacao.Text = pontos.ToString();
                    conexao.Close(); //fecha a conexao
                }
                else
                if (!(resposta.Equals(respUsuarioR)))
                //errou a questão, fazer algo para ajudá-lo a refazê-la
                {
                    MessageBox.Show("Errou a questão");
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show("Erro: "+ s.Message);
            }
        }

        private void pbProximoRefazer_Click(object sender, EventArgs e)
        {
            if (r < tam) // quer dizer que posso incrementar 
            {
                r++;
                auxR = questoesErradas[r];
                
            }
            if (r <= tam) //ver se ja chegou no ultimo, se for menor ou igual buscar no BD, se nao mostrar a pontuacao final do usuário
            {
                lblTitleR.Text = "Questão " + auxR;
                SqlConnection conexao = new SqlConnection(cs);
                String conPerg = "Select pergunta,resposta,a, b, c from pergunta where codPergunta = @cod";
                SqlCommand cmd = new SqlCommand(conPerg, conexao);
                cmd.Parameters.AddWithValue("@cod", auxR);
                conexao.Open();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                conexao.Close(); //fecha a conexao
                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0]; //Pegar o valor que foi trazido do banco na primeira linha
                    lblInfoR.Text = dr.ItemArray[0].ToString();
                    rb1Refazer.Text = dr.ItemArray[2].ToString();
                    rb2Refazer.Text = dr.ItemArray[3].ToString();
                    rb3refazer.Text = dr.ItemArray[4].ToString();
                }
            }
            else
            {
                MessageBox.Show("Parabéns pelo desempenho hoje!!!");
                if (i == 1)
                    lbMensagem.Text = "Você errou " + i + "questão deseja refazê-la?";
                else
                    lbMensagem.Text = "Você errou " + i + "questões, deseja refazê-las?";

                picProx.Enabled = false;
            }
        }

        private void lblRefazer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //mostrar o panel de refazer e carregar nele as questoes erradas com base no vetor
            //que esta com os ids das questoes erradas
            pRefazer.Visible = true;
            tam = questoesErradas.Length;
            auxR = questoesErradas[r];
            lblRefazer.Visible = false;
            lblTitleR.Text = "Questão" + auxR;
            try //ver se ja chegou no ultimo, se for menor ou igual buscar no BD, se nao mostrar a pontuacao final do usuário
            {
                SqlConnection conexao = new SqlConnection(cs);
                String con = "Select pergunta,resposta,a, b, c from pergunta where codPergunta = @cod";
                SqlCommand cmd = new SqlCommand(con, conexao);
                cmd.Parameters.AddWithValue("@cod", auxR);
                conexao.Open();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                conexao.Close(); //fecha a conexao
                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0]; //Pegar o valor que foi trazido do banco na primeira linha
                    lblInfoR.Text = dr.ItemArray[0].ToString();
                    rb1Refazer.Text = dr.ItemArray[2].ToString();
                    rb2Refazer.Text = dr.ItemArray[3].ToString();
                    rb3refazer.Text = dr.ItemArray[4].ToString();
                    btnEnviarR.Enabled = true;
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void aprender_Click(object sender, EventArgs e)
        {
            princ.Show();
            this.Hide();
        }

        private void lblresp1_MouseHover(object sender, EventArgs e)
        {
           // lbl1.BackColor = Color.Snow;
        }

        private void lbl1_MouseLeave(object sender, EventArgs e)
        {
            //lbl1.BackColor = Color.Transparent;
        }

        public void iniciar()
        {
            InitializeComponent();
            lblQuestao.Text = "Questão 1";
            this.email = princ.getEmail();

            //comecar ja pela questão 1 e carregar do BD
            aux = 1;
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string retorno = "Select pergunta, resposta, a, b, c from pergunta where codPergunta = @aux";
                SqlCommand cmd = new SqlCommand(retorno, con);
                cmd.Parameters.AddWithValue("@aux", aux);

                con.Open(); //Abre a conexao com o banco de dados;
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                con.Close(); //fecha a conexao

                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0]; //Pegar o valor que foi trazido do banco na primeira linha
                    pergunta = dr.ItemArray[0].ToString();
                    resposta = dr.ItemArray[1].ToString();
                    a = dr.ItemArray[2].ToString();
                    b = dr.ItemArray[3].ToString();
                    c = dr.ItemArray[4].ToString();
                    lblInformacao.Text = pergunta;
                    rb1.Text = a;
                    rb2.Text = b;
                    rb3.Text = c;
                }

            }
            catch (SqlException err)
            {
                MessageBox.Show("Erro no BD:" + err.ToString());
            }
            //pegar a pontucao daquele usuário e exibi-lá no txtPontuacao
            try
            {
                SqlConnection conec = new SqlConnection(cs);
                String consulta = "Select pontuacao from Usuario where email = @email";
                SqlCommand cmd = new SqlCommand(consulta, conec);
                cmd.Parameters.AddWithValue("@email", this.email);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                conec.Close(); //fecha a conexao
                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtPontuacao.Text = dr.ItemArray[0].ToString();
                }

            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }    

        private void frmQuiz_Load(object sender, EventArgs e)
        {
            lblQuestao.Text = "Questão 1";
            this.email = princ.getEmail();
            
            //comecar ja pela questão 1 e carregar do BD
            aux = 1;
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string retorno = "Select pergunta, resposta, a, b, c from pergunta where codPergunta = @aux";
                SqlCommand cmd = new SqlCommand(retorno,con);
                cmd.Parameters.AddWithValue("@aux", aux);

                con.Open(); //Abre a conexao com o banco de dados;
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                con.Close(); //fecha a conexao

                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0]; //Pegar o valor que foi trazido do banco na primeira linha
                    pergunta = dr.ItemArray[0].ToString();
                    resposta = dr.ItemArray[1].ToString();
                    a        = dr.ItemArray[2].ToString();
                    b        = dr.ItemArray[3].ToString();
                    c        = dr.ItemArray[4].ToString();                   
                    lblInformacao.Text = pergunta;
                    rb1.Text = a;
                    rb2.Text = b;
                    rb3.Text = c;                         
                }    
                
            }
            catch (SqlException err)
            {
                MessageBox.Show("Erro no BD:"+err.ToString());
            }
            //pegar a pontucao daquele usuário e exibi-lá no txtPontuacao
            try
            {
                SqlConnection conec = new SqlConnection(cs);
                String consulta = "Select pontuacao from Usuario where email = @email";
                SqlCommand cmd = new SqlCommand(consulta, conec);
                cmd.Parameters.AddWithValue("@email", this.email);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                conec.Close(); //fecha a conexao
                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtPontuacao.Text = dr.ItemArray[0].ToString();
                }

            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
