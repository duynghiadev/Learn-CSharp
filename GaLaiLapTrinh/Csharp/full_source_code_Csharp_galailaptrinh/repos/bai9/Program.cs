using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhập vào 1 số kiểm tra chẵn lẻ
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("mời nhập vào số nguyên a: ");
            a = int.Parse(Console.ReadLine());
            int div = a % 2;
            // sưitch case
            switch (div)
            {
                case 0:
                    Console.WriteLine("Số {0} là số chẵn", a);
                    goto case 1;
                case 1:
                    Console.WriteLine("Số {0} là số lẻ", a);
                    break;

            }
            Console.ReadKey();

        }
    }
}
