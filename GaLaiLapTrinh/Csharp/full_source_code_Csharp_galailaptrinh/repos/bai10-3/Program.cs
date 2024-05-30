using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                n++; //n=n+1
                Console.WriteLine("n= " +n);
                if (n==10)
                    break;
            }
            Console.ReadKey();
        }
    }
}
