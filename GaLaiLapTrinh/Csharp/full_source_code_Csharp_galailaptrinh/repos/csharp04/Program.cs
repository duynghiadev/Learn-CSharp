using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp04
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            //Tìm x, y khi biết tổng và hiệu của chúng 
            /*
            case test
            Tong = 14
            hieu = 4 
            => x=9, y = 5 

            case 2
            Tong = 8
            hieu = 5 
            => x=6.5, y = 1.5 
            */
            double tong, hieu;
            Console.WriteLine("mời nhập vào tổng 2 số : ");
            tong = double.Parse(Console.ReadLine());

            Console.WriteLine("mời nhập vào hiệu 2 số : ");
            hieu = double.Parse(Console.ReadLine());

            double x = (tong + hieu) / 2;
            double y = (tong - x);
            //xuất kết quả
            Console.WriteLine("Giá trị của x cần tìm là: " +x);
            Console.WriteLine("Giá trị của y cần tìm là: " +y);
            Console.ReadLine();
        }
    }
}
