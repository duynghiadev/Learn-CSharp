using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemTN;
            Console.WriteLine("moi nhap vao diem tot nghiep:");
            diemTN =float.Parse(Console.ReadLine());

            //chek dieu kien
            if (diemTN > 7)
            {
                Console.WriteLine("diem tot nghiep cua ban la {0} , ban da do", diemTN);
                Console.WriteLine("day la dong lenh 2");
                Console.WriteLine("day la dong lenh 3");
            }
                
            else
                Console.WriteLine("diem tot nghiep cua ban la {0} , ban da tach", diemTN);
            Console.WriteLine("Het chuong trinh roi");
            Console.ReadKey();


        }
    }
}
