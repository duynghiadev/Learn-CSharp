using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_1_csharp_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhập vào 1 số nguyên, tính n! bằng vòng for! 
            //ví dụ : 3! = 3*2*1 =1*2*3
            
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            int gt = 1;
            Console.WriteLine("mời nhập vào số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            // tính n giai thừa 
            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("i= " +i);
                gt = gt * i; //gt*=i;
            }
            Console.WriteLine("gia thừa của {0} = {1}", n, gt);
            Console.ReadLine();

        }
    }
}
