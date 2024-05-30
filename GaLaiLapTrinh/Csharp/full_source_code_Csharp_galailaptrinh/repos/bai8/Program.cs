using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhập vào 1 số n , ktra xem n là chẵn hay lẻ
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("mời nhập vào số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            string traLoi = (n % 2 == 0) ? "Số chẵn" : "Số lẻ";
            Console.WriteLine("só {0} là {1}", n,traLoi);
            Console.ReadKey();
        }
    }
}
