using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xuat cac so chan ti 0-10
            int tong = 0;
            for (int i = 0; i<=10; i+=4)
            {
                Console.WriteLine("i=" +i);
                tong = tong + i;
                Console.WriteLine("tong" +tong);
            }
            Console.ReadKey();
        }
    }
}
