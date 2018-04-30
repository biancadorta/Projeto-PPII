namespace Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aprenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrastarPlanetinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprenderToolStripMenuItem,
            this.exercitarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aprenderToolStripMenuItem
            // 
            this.aprenderToolStripMenuItem.Name = "aprenderToolStripMenuItem";
            this.aprenderToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aprenderToolStripMenuItem.Text = "Aprender";
            // 
            // exercitarToolStripMenuItem
            // 
            this.exercitarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perguntasToolStripMenuItem,
            this.arrastarPlanetinhasToolStripMenuItem});
            this.exercitarToolStripMenuItem.Name = "exercitarToolStripMenuItem";
            this.exercitarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exercitarToolStripMenuItem.Text = "Exercitar";
            // 
            // perguntasToolStripMenuItem
            // 
            this.perguntasToolStripMenuItem.Name = "perguntasToolStripMenuItem";
            this.perguntasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.perguntasToolStripMenuItem.Text = "Perguntas";
            // 
            // arrastarPlanetinhasToolStripMenuItem
            // 
            this.arrastarPlanetinhasToolStripMenuItem.Name = "arrastarPlanetinhasToolStripMenuItem";
            this.arrastarPlanetinhasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.arrastarPlanetinhasToolStripMenuItem.Text = "Arrastar planetinhas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
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
        private System.Windows.Forms.ToolStripMenuItem exercitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perguntasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrastarPlanetinhasToolStripMenuItem;
    }
}