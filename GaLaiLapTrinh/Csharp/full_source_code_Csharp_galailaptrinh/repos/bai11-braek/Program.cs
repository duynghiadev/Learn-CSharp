using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_braek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tinh tong cac so tu 1 - 5 ( chi cong den 3 va thoat chuong trinh luon ) 0+1+2
            int tong = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    break;
                else
                {
                    Console.WriteLine("i=" + i);
                    tong += i; //tong = tong +i
                }
            }
            Console.WriteLine("tong can tim la " + tong);
            Console.ReadLine();
        }
    }
}
