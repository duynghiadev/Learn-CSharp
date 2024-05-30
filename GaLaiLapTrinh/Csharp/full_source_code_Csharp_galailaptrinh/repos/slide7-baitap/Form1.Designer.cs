namespace slide7_baitap
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
            this.components = new System.ComponentModel.Container();
            this.grbThongTinDangKy = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.dtpDK = new System.Windows.Forms.DateTimePicker();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbThongTinDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinDangKy
            // 
            this.grbThongTinDangKy.Controls.Add(this.btnDangKy);
            this.grbThongTinDangKy.Controls.Add(this.dtpDK);
            this.grbThongTinDangKy.Controls.Add(this.txtTuoi);
            this.grbThongTinDangKy.Controls.Add(this.txtPhone);
            this.grbThongTinDangKy.Controls.Add(this.label3);
            this.grbThongTinDangKy.Controls.Add(this.label2);
            this.grbThongTinDangKy.Controls.Add(this.label1);
            this.grbThongTinDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinDangKy.Location = new System.Drawing.Point(32, 29);
            this.grbThongTinDangKy.Name = "grbThongTinDangKy";
            this.grbThongTinDangKy.Size = new System.Drawing.Size(339, 190);
            this.grbThongTinDangKy.TabIndex = 0;
            this.grbThongTinDangKy.TabStop = false;
            this.grbThongTinDangKy.Text = "Thông tin đăng ký";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tuổi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày ĐK :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(91, 32);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 21);
            this.txtPhone.TabIndex = 3;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(91, 69);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(200, 21);
            this.txtTuoi.TabIndex = 4;
            // 
            // dtpDK
            // 
            this.dtpDK.CustomFormat = "dd/MM/yyyy";
            this.dtpDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDK.Location = new System.Drawing.Point(91, 110);
            this.dtpDK.Name = "dtpDK";
            this.dtpDK.Size = new System.Drawing.Size(200, 21);
            this.dtpDK.TabIndex = 5;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(143, 148);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(395, 231);
            this.Controls.Add(this.grbThongTinDangKy);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Xem Phim";
            this.grbThongTinDangKy.ResumeLayout(false);
            this.grbThongTinDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinDangKy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DateTimePicker dtpDK;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

