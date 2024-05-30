using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            //tính tổng các số từ 1 - 5
            int a = 1;
            int tong = 0;
            do
            {
                tong += a; // tong=tong+a
                a++; // a=a+1
            }
            while (a<=5);
            Console.WriteLine("tổng từ 1 đến 5 là: " + tong);
            Console.ReadKey();

        }
    }
}
