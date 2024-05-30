namespace bai_12
{
    partial class Form1
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sx1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sx2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sx3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sx4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.sapXepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenForm1,
            this.mnuOpenForm2,
            this.mnuOpenForm3,
            this.mnuOpenForm4});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // mnuOpenForm1
            // 
            this.mnuOpenForm1.Name = "mnuOpenForm1";
            this.mnuOpenForm1.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm1.Text = "form 1";
            this.mnuOpenForm1.Click += new System.EventHandler(this.mnuOpenForm1_Click);
            // 
            // mnuOpenForm2
            // 
            this.mnuOpenForm2.Name = "mnuOpenForm2";
            this.mnuOpenForm2.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm2.Text = "form 2";
            this.mnuOpenForm2.Click += new System.EventHandler(this.mnuOpenForm2_Click);
            // 
            // mnuOpenForm3
            // 
            this.mnuOpenForm3.Name = "mnuOpenForm3";
            this.mnuOpenForm3.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm3.Text = "form 3";
            this.mnuOpenForm3.Click += new System.EventHandler(this.mnuOpenForm3_Click);
            // 
            // mnuOpenForm4
            // 
            this.mnuOpenForm4.Name = "mnuOpenForm4";
            this.mnuOpenForm4.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm4.Text = "form 4";
            this.mnuOpenForm4.Click += new System.EventHandler(this.mnuOpenForm4_Click);
            // 
            // sapXepToolStripMenuItem
            // 
            this.sapXepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sx1ToolStripMenuItem,
            this.sx2ToolStripMenuItem,
            this.sx3ToolStripMenuItem,
            this.sx4ToolStripMenuItem});
            this.sapXepToolStripMenuItem.Name = "sapXepToolStripMenuItem";
            this.sapXepToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sapXepToolStripMenuItem.Text = "Sap xep";
            // 
            // sx1ToolStripMenuItem
            // 
            this.sx1ToolStripMenuItem.Name = "sx1ToolStripMenuItem";
            this.sx1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sx1ToolStripMenuItem.Text = "sx1";
            this.sx1ToolStripMenuItem.Click += new System.EventHandler(this.sx1ToolStripMenuItem_Click);
            // 
            // sx2ToolStripMenuItem
            // 
            this.sx2ToolStripMenuItem.Name = "sx2ToolStripMenuItem";
            this.sx2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sx2ToolStripMenuItem.Text = "sx2";
            this.sx2ToolStripMenuItem.Click += new System.EventHandler(this.sx2ToolStripMenuItem_Click);
            // 
            // sx3ToolStripMenuItem
            // 
            this.sx3ToolStripMenuItem.Name = "sx3ToolStripMenuItem";
            this.sx3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sx3ToolStripMenuItem.Text = "sx3";
            this.sx3ToolStripMenuItem.Click += new System.EventHandler(this.sx3ToolStripMenuItem_Click);
            // 
            // sx4ToolStripMenuItem
            // 
            this.sx4ToolStripMenuItem.Name = "sx4ToolStripMenuItem";
            this.sx4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sx4ToolStripMenuItem.Text = "sx4";
            this.sx4ToolStripMenuItem.Click += new System.EventHandler(this.sx4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 298);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm2;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm3;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm4;
        private System.Windows.Forms.ToolStripMenuItem sapXepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sx1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sx2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sx3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sx4ToolStripMenuItem;
    }
}

