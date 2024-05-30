using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tinh tong cac so tu 1 - 5 ( nhung o bao gom 3 ) 1+2+4+5
            int tong = 0;
            for (int i = 0; i<=5; i++)
            {
                if (i == 3)
                    continue; // neu i =3 thi no se bo qua 
                else
                {
                    Console.WriteLine("i=" +i);
                    tong += i; //tong = tong +i
                }
            }
            Console.WriteLine("tong can tim la " +tong);
            Console.ReadLine();
        }
        
    }
}
