namespace Classe_Herança_Gráfico
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarUsuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btncadprof = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem1,
            this.btncadprof,
            this.sairToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // cadastrarUsuárioToolStripMenuItem1
            // 
            resources.ApplyResources(this.cadastrarUsuárioToolStripMenuItem1, "cadastrarUsuárioToolStripMenuItem1");
            this.cadastrarUsuárioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem1});
            this.cadastrarUsuárioToolStripMenuItem1.Name = "cadastrarUsuárioToolStripMenuItem1";
            this.cadastrarUsuárioToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btncadprof
            // 
            resources.ApplyResources(this.btncadprof, "btncadprof");
            this.btncadprof.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem});
            this.btncadprof.Name = "btncadprof";
            this.btncadprof.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem
            // 
            resources.ApplyResources(this.testeToolStripMenuItem, "testeToolStripMenuItem");
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            // 
            // testeToolStripMenuItem1
            // 
            resources.ApplyResources(this.testeToolStripMenuItem1, "testeToolStripMenuItem1");
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            // 
            // menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btncadprof;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
    }
}

