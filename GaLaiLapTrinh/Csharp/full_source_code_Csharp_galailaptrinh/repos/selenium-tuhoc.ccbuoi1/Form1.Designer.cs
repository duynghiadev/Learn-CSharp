namespace selenium_tuhoc.ccbuoi1
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
            this.btnopenBrowser = new System.Windows.Forms.Button();
            this.openBrowser2 = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnopenBrowser
            // 
            this.btnopenBrowser.Location = new System.Drawing.Point(35, 61);
            this.btnopenBrowser.Name = "btnopenBrowser";
            this.btnopenBrowser.Size = new System.Drawing.Size(116, 43);
            this.btnopenBrowser.TabIndex = 0;
            this.btnopenBrowser.Text = "open Browser";
            this.btnopenBrowser.UseVisualStyleBackColor = true;
            this.btnopenBrowser.Click += new System.EventHandler(this.btnopenBrowser_Click);
            // 
            // openBrowser2
            // 
            this.openBrowser2.Location = new System.Drawing.Point(184, 61);
            this.openBrowser2.Name = "openBrowser2";
            this.openBrowser2.Size = new System.Drawing.Size(113, 43);
            this.openBrowser2.TabIndex = 1;
            this.openBrowser2.Text = "open Browser 2";
            this.openBrowser2.UseVisualStyleBackColor = true;
            this.openBrowser2.Click += new System.EventHandler(this.openBrowser2_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(81, 26);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(216, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Url ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.openBrowser2);
            this.Controls.Add(this.btnopenBrowser);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnopenBrowser;
        private System.Windows.Forms.Button openBrowser2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
    }
}

