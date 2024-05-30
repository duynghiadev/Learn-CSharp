namespace slide8_bt
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
            this.lblSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grbDSSố = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnXoaPTDangChon = new System.Windows.Forms.Button();
            this.btnXoaptDauCuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grbDSSố.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(13, 25);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(55, 13);
            this.lblSo.TabIndex = 0;
            this.lblSo.Text = "Nhập Số: ";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(93, 18);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(387, 20);
            this.txtSo.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(486, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grbDSSố
            // 
            this.grbDSSố.Controls.Add(this.lstSo);
            this.grbDSSố.Location = new System.Drawing.Point(16, 57);
            this.grbDSSố.Name = "grbDSSố";
            this.grbDSSố.Size = new System.Drawing.Size(264, 280);
            this.grbDSSố.TabIndex = 3;
            this.grbDSSố.TabStop = false;
            this.grbDSSố.Text = "Danh Sách Số";
            // 
            // lstSo
            // 
            this.lstSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.Location = new System.Drawing.Point(3, 16);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(258, 261);
            this.lstSo.TabIndex = 0;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnLe);
            this.grbChucNang.Controls.Add(this.btnChan);
            this.grbChucNang.Controls.Add(this.btnBinhPhuong);
            this.grbChucNang.Controls.Add(this.btnTangLen2);
            this.grbChucNang.Controls.Add(this.btnXoaPTDangChon);
            this.grbChucNang.Controls.Add(this.btnXoaptDauCuoi);
            this.grbChucNang.Controls.Add(this.btnTong);
            this.grbChucNang.Location = new System.Drawing.Point(297, 57);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(264, 280);
            this.grbChucNang.TabIndex = 4;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(21, 234);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(211, 23);
            this.btnLe.TabIndex = 6;
            this.btnLe.Text = "Chọn số lẻ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(21, 205);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(211, 23);
            this.btnChan.TabIndex = 5;
            this.btnChan.Text = "Chọn số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(21, 169);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(211, 23);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.Location = new System.Drawing.Point(21, 132);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(211, 23);
            this.btnTangLen2.TabIndex = 3;
            this.btnTangLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = true;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnXoaPTDangChon
            // 
            this.btnXoaPTDangChon.Location = new System.Drawing.Point(21, 97);
            this.btnXoaPTDangChon.Name = "btnXoaPTDangChon";
            this.btnXoaPTDangChon.Size = new System.Drawing.Size(211, 23);
            this.btnXoaPTDangChon.TabIndex = 2;
            this.btnXoaPTDangChon.Text = "Xóa pt đang chọn";
            this.btnXoaPTDangChon.UseVisualStyleBackColor = true;
            this.btnXoaPTDangChon.Click += new System.EventHandler(this.btnXoaPTDangChon_Click);
            // 
            // btnXoaptDauCuoi
            // 
            this.btnXoaptDauCuoi.Location = new System.Drawing.Point(21, 60);
            this.btnXoaptDauCuoi.Name = "btnXoaptDauCuoi";
            this.btnXoaptDauCuoi.Size = new System.Drawing.Size(211, 23);
            this.btnXoaptDauCuoi.TabIndex = 1;
            this.btnXoaptDauCuoi.Text = "Xóa pt đầu và cuối";
            this.btnXoaptDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaptDauCuoi.Click += new System.EventHandler(this.btnXoaptDauCuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(21, 20);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(211, 23);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng của danh sách";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(16, 343);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(545, 23);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(580, 383);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbDSSố);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblSo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbDSSố.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grbDSSố;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnXoaPTDangChon;
        private System.Windows.Forms.Button btnXoaptDauCuoi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

