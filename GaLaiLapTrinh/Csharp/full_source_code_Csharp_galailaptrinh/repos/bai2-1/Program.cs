using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            float z = a / b;
            Console.WriteLine("Gia tri cua z la: " + z);
            float z2 = (float) a / b;
            Console.WriteLine("Gia tri cua z2 la: " + z2);


            Console.ReadKey();
        }
    }
}
