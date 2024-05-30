using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen;
            float diemToan;
            float diemVan;

            Console.WriteLine("Mời nhập vào họ tên :");
            hoTen = Console.ReadLine();

            Console.WriteLine("mời nhập vào điểm toán: ");
            diemToan = float.Parse(Console.ReadLine());

            Console.WriteLine("mời nhập vào điểm văn: ");
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine("Học sinh {0} có điểm toán là {1}, điểm văn là {2}" ,hoTen, diemToan, diemVan);
            Console.ReadKey();





        }
    }
}
