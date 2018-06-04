namespace Login
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aprenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testarConhecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDosPlanetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprenderToolStripMenuItem,
            this.testarConhecimentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aprenderToolStripMenuItem
            // 
            this.aprenderToolStripMenuItem.Name = "aprenderToolStripMenuItem";
            this.aprenderToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aprenderToolStripMenuItem.Text = "Aprender";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // testarConhecimentoToolStripMenuItem
            // 
            this.testarConhecimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemDosPlanetasToolStripMenuItem,
            this.perguntasToolStripMenuItem});
            this.testarConhecimentoToolStripMenuItem.Name = "testarConhecimentoToolStripMenuItem";
            this.testarConhecimentoToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.testarConhecimentoToolStripMenuItem.Text = "Testar Conhecimento";
            // 
            // ordemDosPlanetasToolStripMenuItem
            // 
            this.ordemDosPlanetasToolStripMenuItem.Name = "ordemDosPlanetasToolStripMenuItem";
            this.ordemDosPlanetasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordemDosPlanetasToolStripMenuItem.Text = "Ordem dos planetas";
            this.ordemDosPlanetasToolStripMenuItem.Click += new System.EventHandler(this.ordemDosPlanetasToolStripMenuItem_Click);
            // 
            // perguntasToolStripMenuItem
            // 
            this.perguntasToolStripMenuItem.Name = "perguntasToolStripMenuItem";
            this.perguntasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perguntasToolStripMenuItem.Text = "Perguntas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 297);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aprenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testarConhecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDosPlanetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perguntasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}