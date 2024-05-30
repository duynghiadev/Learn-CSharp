namespace bai3_selenium_upanh
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
            this.btnUpanh = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDangXuLy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpanh
            // 
            this.btnUpanh.Location = new System.Drawing.Point(266, 66);
            this.btnUpanh.Name = "btnUpanh";
            this.btnUpanh.Size = new System.Drawing.Size(96, 36);
            this.btnUpanh.TabIndex = 0;
            this.btnUpanh.Text = "Upanh";
            this.btnUpanh.UseVisualStyleBackColor = true;
            this.btnUpanh.Click += new System.EventHandler(this.btnUpanh_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(169, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(279, 20);
            this.txtInput.TabIndex = 1;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(169, 124);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(279, 20);
            this.txtOut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhap vao url anh tren may";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Link anh cua cu o day ";
            // 
            // lblDangXuLy
            // 
            this.lblDangXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuLy.ForeColor = System.Drawing.Color.Blue;
            this.lblDangXuLy.Location = new System.Drawing.Point(169, 182);
            this.lblDangXuLy.Name = "lblDangXuLy";
            this.lblDangXuLy.Size = new System.Drawing.Size(279, 23);
            this.lblDangXuLy.TabIndex = 5;
            this.lblDangXuLy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 248);
            this.Controls.Add(this.lblDangXuLy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnUpanh);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpanh;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDangXuLy;
    }
}

