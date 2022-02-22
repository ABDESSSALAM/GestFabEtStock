
namespace EFM01
{
    partial class Sisaire
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
            this.aricleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabriquatinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aricleToolStripMenuItem,
            this.depotToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.fabriquatinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aricleToolStripMenuItem
            // 
            this.aricleToolStripMenuItem.Name = "aricleToolStripMenuItem";
            this.aricleToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.aricleToolStripMenuItem.Text = "Aricle";
            this.aricleToolStripMenuItem.Click += new System.EventHandler(this.aricleToolStripMenuItem_Click);
            // 
            // depotToolStripMenuItem
            // 
            this.depotToolStripMenuItem.Name = "depotToolStripMenuItem";
            this.depotToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.depotToolStripMenuItem.Text = "Depot";
            this.depotToolStripMenuItem.Click += new System.EventHandler(this.depotToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // fabriquatinToolStripMenuItem
            // 
            this.fabriquatinToolStripMenuItem.Name = "fabriquatinToolStripMenuItem";
            this.fabriquatinToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
            this.fabriquatinToolStripMenuItem.Text = "Fabriquation";
            this.fabriquatinToolStripMenuItem.Click += new System.EventHandler(this.fabriquatinToolStripMenuItem_Click);
            // 
            // Sisaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 641);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sisaire";
            this.Text = "Saisiar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sisaire_FormClosed);
            this.Load += new System.EventHandler(this.Sisaire_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aricleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabriquatinToolStripMenuItem;
    }
}