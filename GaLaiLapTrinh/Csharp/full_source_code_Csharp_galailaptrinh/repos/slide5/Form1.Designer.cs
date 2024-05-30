namespace slide5
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
            this.grbSoThich = new System.Windows.Forms.GroupBox();
            this.chkNgheNhac = new System.Windows.Forms.CheckBox();
            this.chkChoiTheThao = new System.Windows.Forms.CheckBox();
            this.chkDuLich = new System.Windows.Forms.CheckBox();
            this.shkShop = new System.Windows.Forms.CheckBox();
            this.chkXemPhim = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.grbSoThich.SuspendLayout();
            this.grbGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSoThich
            // 
            this.grbSoThich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grbSoThich.Controls.Add(this.chkNgheNhac);
            this.grbSoThich.Controls.Add(this.chkChoiTheThao);
            this.grbSoThich.Controls.Add(this.chkDuLich);
            this.grbSoThich.Controls.Add(this.shkShop);
            this.grbSoThich.Controls.Add(this.chkXemPhim);
            this.grbSoThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSoThich.Location = new System.Drawing.Point(25, 31);
            this.grbSoThich.Name = "grbSoThich";
            this.grbSoThich.Size = new System.Drawing.Size(178, 154);
            this.grbSoThich.TabIndex = 0;
            this.grbSoThich.TabStop = false;
            this.grbSoThich.Text = "Sở Thích";
            // 
            // chkNgheNhac
            // 
            this.chkNgheNhac.AutoSize = true;
            this.chkNgheNhac.Location = new System.Drawing.Point(19, 128);
            this.chkNgheNhac.Name = "chkNgheNhac";
            this.chkNgheNhac.Size = new System.Drawing.Size(103, 20);
            this.chkNgheNhac.TabIndex = 4;
            this.chkNgheNhac.Text = "Nghe Nhạc";
            this.chkNgheNhac.UseVisualStyleBackColor = true;
            // 
            // chkChoiTheThao
            // 
            this.chkChoiTheThao.AutoSize = true;
            this.chkChoiTheThao.Location = new System.Drawing.Point(19, 102);
            this.chkChoiTheThao.Name = "chkChoiTheThao";
            this.chkChoiTheThao.Size = new System.Drawing.Size(128, 20);
            this.chkChoiTheThao.TabIndex = 3;
            this.chkChoiTheThao.Text = "Chơi Thể Thao";
            this.chkChoiTheThao.UseVisualStyleBackColor = true;
            // 
            // chkDuLich
            // 
            this.chkDuLich.AutoSize = true;
            this.chkDuLich.Location = new System.Drawing.Point(19, 75);
            this.chkDuLich.Name = "chkDuLich";
            this.chkDuLich.Size = new System.Drawing.Size(77, 20);
            this.chkDuLich.TabIndex = 2;
            this.chkDuLich.Text = "Du Lịch";
            this.chkDuLich.UseVisualStyleBackColor = true;
            // 
            // shkShop
            // 
            this.shkShop.AutoSize = true;
            this.shkShop.Location = new System.Drawing.Point(19, 49);
            this.shkShop.Name = "shkShop";
            this.shkShop.Size = new System.Drawing.Size(92, 20);
            this.shkShop.TabIndex = 1;
            this.shkShop.Text = "Shopping";
            this.shkShop.UseVisualStyleBackColor = true;
            // 
            // chkXemPhim
            // 
            this.chkXemPhim.AutoSize = true;
            this.chkXemPhim.Location = new System.Drawing.Point(19, 22);
            this.chkXemPhim.Name = "chkXemPhim";
            this.chkXemPhim.Size = new System.Drawing.Size(94, 20);
            this.chkXemPhim.TabIndex = 0;
            this.chkXemPhim.Text = "Xem Phim";
            this.chkXemPhim.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(130, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.radNu);
            this.grbGioiTinh.Controls.Add(this.radNam);
            this.grbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGioiTinh.Location = new System.Drawing.Point(222, 31);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(178, 154);
            this.grbGioiTinh.TabIndex = 2;
            this.grbGioiTinh.TabStop = false;
            this.grbGioiTinh.Text = "Giới Tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(16, 34);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(16, 61);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(44, 20);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 213);
            this.Controls.Add(this.grbGioiTinh);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.grbSoThich);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSoThich.ResumeLayout(false);
            this.grbSoThich.PerformLayout();
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSoThich;
        private System.Windows.Forms.CheckBox chkNgheNhac;
        private System.Windows.Forms.CheckBox chkChoiTheThao;
        private System.Windows.Forms.CheckBox chkDuLich;
        private System.Windows.Forms.CheckBox shkShop;
        private System.Windows.Forms.CheckBox chkXemPhim;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
    }
}

