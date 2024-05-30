using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_3_oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nv1 = new NhanVien();
            nv1.TenNV = " Nhân viên 1";
            nv1.MaNV = 1;
            Console.WriteLine("tên nhân viên là:" +nv1.TenNV + " mã nv là : "+nv1.MaNV);
            Console.WriteLine("lương nhân viên 1 là: "+nv1.TinhLuong());

            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.TenNV = "hành văn chính";
            hc1.MaNV = 2;
            Console.WriteLine("tên nhân viên là:" + hc1.TenNV + " mã nv là : " + hc1.MaNV);
            Console.WriteLine("lương nhân viên hc1 là" + hc1.TinhLuong());

            NhanVienDiCa ca1= new NhanVienDiCa();
            ca1.TenNV = "Nguyễn văn ca";
            ca1.MaNV = 3;
            ca1.Ca = "Ca ngày";
            Console.WriteLine("tên nhân viên là:" + ca1.TenNV + " mã nv là : " + ca1.MaNV+ "nhân viên đang làm" +ca1.Ca);
            Console.WriteLine("nhân viên ca1 có lương là: "+ ca1.TinhLuong());

            Console.WriteLine("******************");
            Console.WriteLine(nv1.ThuongDuCong(26));
            Console.WriteLine(hc1.ThuongDuCong(26));
            Console.WriteLine(ca1.ThuongDuCong(26));
            Console.ReadKey();
        }
    }
}
