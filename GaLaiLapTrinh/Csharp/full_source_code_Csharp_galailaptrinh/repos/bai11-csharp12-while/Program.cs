using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_csharp12_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhập vào 1 số nguyên n, tính n! bằng while ! 
            //ví dụ : 3! = 3*2*1
            Console.OutputEncoding = Encoding.UTF8;
            int n, i=1;
            int gt = 1;
            Console.WriteLine("mời nhập vào số nguyên n: ");
            n = int.Parse(Console.ReadLine());
            // tính n giai thừa 
            while (i<=n)
            {
                gt *= i; 
                i++;
            }
            Console.WriteLine("Kết quả {0}! = {1}", n,gt);
            Console.ReadKey();
        }
    }
}
