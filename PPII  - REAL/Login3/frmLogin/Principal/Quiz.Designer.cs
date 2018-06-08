namespace Principal
{
    partial class frmQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aprenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aprender = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuestao = new System.Windows.Forms.Label();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.picProx = new System.Windows.Forms.PictureBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblpontuacao = new System.Windows.Forms.Label();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.pRefazer = new System.Windows.Forms.Panel();
            this.pbProximoRefazer = new System.Windows.Forms.PictureBox();
            this.btnEnviarR = new System.Windows.Forms.Button();
            this.rb3refazer = new System.Windows.Forms.RadioButton();
            this.rb2Refazer = new System.Windows.Forms.RadioButton();
            this.rb1Refazer = new System.Windows.Forms.RadioButton();
            this.lblInfoR = new System.Windows.Forms.Label();
            this.lblTitleR = new System.Windows.Forms.Label();
            this.lblRefazer = new System.Windows.Forms.LinkLabel();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProx)).BeginInit();
            this.pRefazer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProximoRefazer)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprenderToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(124, 26);
            // 
            // aprenderToolStripMenuItem
            // 
            this.aprenderToolStripMenuItem.Name = "aprenderToolStripMenuItem";
            this.aprenderToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aprenderToolStripMenuItem.Text = "Aprender";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprender,
            this.toolStripMenuItem1,
            this.perguntasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.bookOfImagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aprender
            // 
            this.aprender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprender.ForeColor = System.Drawing.SystemColors.Window;
            this.aprender.Image = ((System.Drawing.Image)(resources.GetObject("aprender.Image")));
            this.aprender.Name = "aprender";
            this.aprender.Size = new System.Drawing.Size(107, 24);
            this.aprender.Text = "Aprender";
            this.aprender.Click += new System.EventHandler(this.aprender_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(31, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // perguntasToolStripMenuItem
            // 
            this.perguntasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.perguntasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perguntasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.perguntasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("perguntasToolStripMenuItem.Image")));
            this.perguntasToolStripMenuItem.Name = "perguntasToolStripMenuItem";
            this.perguntasToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.perguntasToolStripMenuItem.Text = "Ordenar Planetas";
            this.perguntasToolStripMenuItem.Click += new System.EventHandler(this.perguntasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(31, 24);
            this.toolStripMenuItem2.Text = "|";
            // 
            // bookOfImagesToolStripMenuItem
            // 
            this.bookOfImagesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookOfImagesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.bookOfImagesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookOfImagesToolStripMenuItem.Image")));
            this.bookOfImagesToolStripMenuItem.Name = "bookOfImagesToolStripMenuItem";
            this.bookOfImagesToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.bookOfImagesToolStripMenuItem.Text = "Book of images";
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestao.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuestao.Location = new System.Drawing.Point(224, 35);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(90, 22);
            this.lblQuestao.TabIndex = 36;
            this.lblQuestao.Text = "Questão";
            // 
            // lblInformacao
            // 
            this.lblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.ForeColor = System.Drawing.SystemColors.Window;
            this.lblInformacao.Location = new System.Drawing.Point(28, 69);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(532, 87);
            this.lblInformacao.TabIndex = 37;
            // 
            // picProx
            // 
            this.picProx.BackColor = System.Drawing.Color.Transparent;
            this.picProx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProx.BackgroundImage")));
            this.picProx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProx.Location = new System.Drawing.Point(505, 296);
            this.picProx.Name = "picProx";
            this.picProx.Size = new System.Drawing.Size(55, 36);
            this.picProx.TabIndex = 45;
            this.picProx.TabStop = false;
            this.picProx.Click += new System.EventHandler(this.picProx_Click);
            // 
            // rb1
            // 
            this.rb1.BackColor = System.Drawing.Color.Transparent;
            this.rb1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.ForeColor = System.Drawing.SystemColors.Window;
            this.rb1.Location = new System.Drawing.Point(63, 171);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(239, 28);
            this.rb1.TabIndex = 46;
            this.rb1.TabStop = true;
            this.rb1.Text = "radioButton1";
            this.rb1.UseVisualStyleBackColor = false;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.BackColor = System.Drawing.Color.Transparent;
            this.rb2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.ForeColor = System.Drawing.SystemColors.Window;
            this.rb2.Location = new System.Drawing.Point(63, 205);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(239, 28);
            this.rb2.TabIndex = 47;
            this.rb2.TabStop = true;
            this.rb2.Text = "radioButton2";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // rb3
            // 
            this.rb3.BackColor = System.Drawing.Color.Transparent;
            this.rb3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.ForeColor = System.Drawing.SystemColors.Window;
            this.rb3.Location = new System.Drawing.Point(63, 239);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(239, 28);
            this.rb3.TabIndex = 48;
            this.rb3.TabStop = true;
            this.rb3.Text = "radioButton3";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(228, 296);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 27);
            this.btnSalvar.TabIndex = 49;
            this.btnSalvar.Text = "Enviar ";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblpontuacao
            // 
            this.lblpontuacao.AutoSize = true;
            this.lblpontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lblpontuacao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpontuacao.ForeColor = System.Drawing.SystemColors.Window;
            this.lblpontuacao.Location = new System.Drawing.Point(583, 35);
            this.lblpontuacao.Name = "lblpontuacao";
            this.lblpontuacao.Size = new System.Drawing.Size(119, 22);
            this.lblpontuacao.TabIndex = 50;
            this.lblpontuacao.Text = "Pontuação:";
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.Enabled = false;
            this.txtPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontuacao.Location = new System.Drawing.Point(583, 69);
            this.txtPontuacao.Multiline = true;
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.Size = new System.Drawing.Size(119, 27);
            this.txtPontuacao.TabIndex = 51;
            // 
            // pRefazer
            // 
            this.pRefazer.BackColor = System.Drawing.Color.Transparent;
            this.pRefazer.Controls.Add(this.pbProximoRefazer);
            this.pRefazer.Controls.Add(this.btnEnviarR);
            this.pRefazer.Controls.Add(this.rb3refazer);
            this.pRefazer.Controls.Add(this.rb2Refazer);
            this.pRefazer.Controls.Add(this.rb1Refazer);
            this.pRefazer.Controls.Add(this.lblInfoR);
            this.pRefazer.Controls.Add(this.lblTitleR);
            this.pRefazer.Location = new System.Drawing.Point(20, 31);
            this.pRefazer.Name = "pRefazer";
            this.pRefazer.Size = new System.Drawing.Size(546, 318);
            this.pRefazer.TabIndex = 56;
            this.pRefazer.Visible = false;
            // 
            // pbProximoRefazer
            // 
            this.pbProximoRefazer.BackColor = System.Drawing.Color.Transparent;
            this.pbProximoRefazer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbProximoRefazer.BackgroundImage")));
            this.pbProximoRefazer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProximoRefazer.Location = new System.Drawing.Point(479, 235);
            this.pbProximoRefazer.Name = "pbProximoRefazer";
            this.pbProximoRefazer.Size = new System.Drawing.Size(55, 36);
            this.pbProximoRefazer.TabIndex = 56;
            this.pbProximoRefazer.TabStop = false;
            this.pbProximoRefazer.Click += new System.EventHandler(this.pbProximoRefazer_Click);
            // 
            // btnEnviarR
            // 
            this.btnEnviarR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarR.Location = new System.Drawing.Point(210, 282);
            this.btnEnviarR.Name = "btnEnviarR";
            this.btnEnviarR.Size = new System.Drawing.Size(100, 27);
            this.btnEnviarR.TabIndex = 55;
            this.btnEnviarR.Text = "Enviar ";
            this.btnEnviarR.UseVisualStyleBackColor = true;
            this.btnEnviarR.Click += new System.EventHandler(this.btnEnviarR_Click);
            // 
            // rb3refazer
            // 
            this.rb3refazer.BackColor = System.Drawing.Color.Transparent;
            this.rb3refazer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3refazer.ForeColor = System.Drawing.SystemColors.Window;
            this.rb3refazer.Location = new System.Drawing.Point(44, 225);
            this.rb3refazer.Name = "rb3refazer";
            this.rb3refazer.Size = new System.Drawing.Size(239, 28);
            this.rb3refazer.TabIndex = 54;
            this.rb3refazer.TabStop = true;
            this.rb3refazer.Text = "radioButton3";
            this.rb3refazer.UseVisualStyleBackColor = false;
            // 
            // rb2Refazer
            // 
            this.rb2Refazer.BackColor = System.Drawing.Color.Transparent;
            this.rb2Refazer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2Refazer.ForeColor = System.Drawing.SystemColors.Window;
            this.rb2Refazer.Location = new System.Drawing.Point(44, 191);
            this.rb2Refazer.Name = "rb2Refazer";
            this.rb2Refazer.Size = new System.Drawing.Size(239, 28);
            this.rb2Refazer.TabIndex = 53;
            this.rb2Refazer.TabStop = true;
            this.rb2Refazer.Text = "radioButton2";
            this.rb2Refazer.UseVisualStyleBackColor = false;
            // 
            // rb1Refazer
            // 
            this.rb1Refazer.BackColor = System.Drawing.Color.Transparent;
            this.rb1Refazer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1Refazer.ForeColor = System.Drawing.SystemColors.Window;
            this.rb1Refazer.Location = new System.Drawing.Point(44, 157);
            this.rb1Refazer.Name = "rb1Refazer";
            this.rb1Refazer.Size = new System.Drawing.Size(239, 28);
            this.rb1Refazer.TabIndex = 52;
            this.rb1Refazer.TabStop = true;
            this.rb1Refazer.Text = "radioButton1";
            this.rb1Refazer.UseVisualStyleBackColor = false;
            // 
            // lblInfoR
            // 
            this.lblInfoR.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoR.ForeColor = System.Drawing.SystemColors.Window;
            this.lblInfoR.Location = new System.Drawing.Point(9, 55);
            this.lblInfoR.Name = "lblInfoR";
            this.lblInfoR.Size = new System.Drawing.Size(532, 87);
            this.lblInfoR.TabIndex = 51;
            // 
            // lblTitleR
            // 
            this.lblTitleR.AutoSize = true;
            this.lblTitleR.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleR.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitleR.Location = new System.Drawing.Point(205, 21);
            this.lblTitleR.Name = "lblTitleR";
            this.lblTitleR.Size = new System.Drawing.Size(90, 22);
            this.lblTitleR.TabIndex = 50;
            this.lblTitleR.Text = "Questão";
            // 
            // lblRefazer
            // 
            this.lblRefazer.AutoSize = true;
            this.lblRefazer.BackColor = System.Drawing.Color.Transparent;
            this.lblRefazer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefazer.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRefazer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblRefazer.Location = new System.Drawing.Point(644, 232);
            this.lblRefazer.Name = "lblRefazer";
            this.lblRefazer.Size = new System.Drawing.Size(55, 17);
            this.lblRefazer.TabIndex = 58;
            this.lblRefazer.TabStop = true;
            this.lblRefazer.Text = "Refazer";
            this.lblRefazer.Visible = false;
            this.lblRefazer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRefazer_LinkClicked);
            // 
            // lbMensagem
            // 
            this.lbMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lbMensagem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.SystemColors.Window;
            this.lbMensagem.Location = new System.Drawing.Point(584, 110);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(130, 120);
            this.lbMensagem.TabIndex = 57;
            this.lbMensagem.Text = "Biancaaaa";
            this.lbMensagem.Visible = false;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(714, 405);
            this.Controls.Add(this.lblRefazer);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.pRefazer);
            this.Controls.Add(this.txtPontuacao);
            this.Controls.Add(this.lblpontuacao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.picProx);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.lblQuestao);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "frmQuiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProx)).EndInit();
            this.pRefazer.ResumeLayout(false);
            this.pRefazer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProximoRefazer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aprenderToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aprender;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perguntasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bookOfImagesToolStripMenuItem;
        private System.Windows.Forms.Label lblQuestao;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.PictureBox picProx;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblpontuacao;
        private System.Windows.Forms.TextBox txtPontuacao;
        private System.Windows.Forms.Panel pRefazer;
        private System.Windows.Forms.PictureBox pbProximoRefazer;
        private System.Windows.Forms.Button btnEnviarR;
        private System.Windows.Forms.RadioButton rb3refazer;
        private System.Windows.Forms.RadioButton rb2Refazer;
        private System.Windows.Forms.RadioButton rb1Refazer;
        private System.Windows.Forms.Label lblInfoR;
        private System.Windows.Forms.Label lblTitleR;
        private System.Windows.Forms.LinkLabel lblRefazer;
        private System.Windows.Forms.Label lbMensagem;
    }
}