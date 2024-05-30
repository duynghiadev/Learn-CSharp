using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_oop1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            //1. Tạo 1 đối tượng mới không truyền giá trị
            SinhVien sinhVien1 = new SinhVien();
            SinhVien sinhVien2 = new SinhVien();

            // xuất
            Console.WriteLine(sinhVien1.MaSV);
            Console.WriteLine(sinhVien2.MaSV);
            Console.WriteLine(sinhVien1.TenSV);
            Console.WriteLine(sinhVien2.TenSV);
            Console.WriteLine("Tên sinh viên là: "+ sinhVien1.TenSV );

            //Service Method & Support MEthod
            SinhVien sinhVien3=new SinhVien(3,"Nguyễn Văn Ba", 20);
            // check điểm
            Console.WriteLine(sinhVien3.Tong(1,2));
            Console.WriteLine(sinhVien3.Tong(1.5,2.4,3.7));

            //Parametter List Method 
            Console.WriteLine(sinhVien2.TBKEtThuCHocKy(7,8,9,4,5,8,7,5,4,7,8,9));
            Console.WriteLine(sinhVien1.TBKEtThuCHocKy(10,10,10,10,10,7,8,9,4,5,8,7,5,4,7,8,9));

            //Auto-Implemented Properties 
            HocSinh hocSinh1 = new HocSinh();
            hocSinh1.Name = "Tèo";
            hocSinh1.Phone = "09xx";
            hocSinh1.Email = "teo@gmail.com";
            Console.WriteLine(hocSinh1);
            Console.ReadKey();
        }
    }
}
