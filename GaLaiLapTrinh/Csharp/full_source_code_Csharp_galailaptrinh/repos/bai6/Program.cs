using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kq;
            int a = 6, b = 10;
            kq = !((a != b) && (a < 3));
            Console.WriteLine("gia tri cua ket qua la: " + kq);
            Console.ReadKey();
        }
    }
}
