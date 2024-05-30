using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_oop1
{
    public class SinhVien
    {
        #region biến lớp 
        //Khai báo biến lớp 
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion
        #region constructor 
        // Khai báo constructor 
        //(Gán giá trị mặc định cho đối tượng)
        public SinhVien()
        {   
            this.maSV = 0;
            this.tenSV = "No name";
            this.diemThiDH = 0;
        }
        // Khai báo constructor 
        //(Khởi tạo giá trị cho đối tượng do người dùng truyền vào)
        public SinhVien(int maSV, string tenSV, float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH=diemThiDH;
        }

        public SinhVien(int maSV,  float diemThiDH, string tenSV)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH = diemThiDH;
        }
        #endregion
        #region Properties
        //Khai báo Properties để có thể truy xuất sửa đổi dữ liệu:
        public string TenSV
        {
            get { return tenSV; } // get giá trị để đọc 
            set { tenSV = value; } // set giá trị 
        }
        public int MaSV
        {
            set { maSV = value; }
            get { return maSV; }
        }

        public float DiemThiDH
        {
            get { return diemThiDH; }
            set { diemThiDH = value;}
        }
        #endregion
        #region các phương thức 
        //Phương thức Tostring
        public override string ToString()
        {
            return this.MaSV + "\t" + this.TenSV;
        }

        // support method
        //kiểm tra điều kiện nhập sinh viên mới
        private bool CheckDiemThiDH()
        {
            return (this.diemThiDH -21>= 0);
        }

        //service method (xuất thông tin)
        public void XuatThongTin()
        {
            if (CheckDiemThiDH()==false)
                Console.WriteLine("Điểm thi DH <21, cần kiểm tra lại HS sv này");
            else
                Console.WriteLine(ToString());
        }

        // tổng 
        public int Tong(int x, int y)
        {
            return x + y;
        }

        public int Tong(int x, int y, int z)
        {
            return x + y+z;
        }

        public double Tong(double x, double y, double z)
        {
            return x + y + z;
        }

        //Parametter List Method 
        //tính tổng điểm TB kết thúc học kỳ 
        public float TBKEtThuCHocKy(params float[] mang)
        {
            float s = 0;
            foreach (float f in mang)
            {
                s += f;
            }
            return (s / mang.Count());

        }
        #endregion
    }
}
