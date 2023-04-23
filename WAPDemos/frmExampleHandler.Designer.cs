
namespace WAPDemos
{
    partial class frmExampleHandler
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuDemo01 = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuDemo02 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuManagement});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuClose});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // subMenuClose
            // 
            this.subMenuClose.Name = "subMenuClose";
            this.subMenuClose.Size = new System.Drawing.Size(103, 22);
            this.subMenuClose.Text = "Close";
            this.subMenuClose.Click += new System.EventHandler(this.subMenuClose_Click);
            // 
            // menuManagement
            // 
            this.menuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuDemo01,
            this.submenuDemo02});
            this.menuManagement.Name = "menuManagement";
            this.menuManagement.Size = new System.Drawing.Size(90, 20);
            this.menuManagement.Text = "Management";
            // 
            // submenuDemo01
            // 
            this.submenuDemo01.Name = "submenuDemo01";
            this.submenuDemo01.Size = new System.Drawing.Size(180, 22);
            this.submenuDemo01.Text = "Demo01";
            this.submenuDemo01.Click += new System.EventHandler(this.submenuDemo01_Click);
            // 
            // submenuDemo02
            // 
            this.submenuDemo02.Name = "submenuDemo02";
            this.submenuDemo02.Size = new System.Drawing.Size(180, 22);
            this.submenuDemo02.Text = "Demo02";
            this.submenuDemo02.Click += new System.EventHandler(this.submenuDemo02_Click);
            // 
            // frmExampleHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmExampleHandler";
            this.Text = "frmExampleHandler";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem subMenuClose;
        private System.Windows.Forms.ToolStripMenuItem menuManagement;
        private System.Windows.Forms.ToolStripMenuItem submenuDemo01;
        private System.Windows.Forms.ToolStripMenuItem submenuDemo02;
    }
}