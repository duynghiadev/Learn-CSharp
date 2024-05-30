using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_6_Csharp_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tìm tất cả những số hoàn thiện trong phạm vi từ 1-1000
            //6 = 1+2+3
            //nhap vao 1 so, ktra xem so do co phai la so hoan hao hay o
            /*
            int n;
            int tong = 0;
            Console.WriteLine("moi nhap vao so nguyen n: ");
            n=int.Parse(Console.ReadLine());
            for (int i = 1; i < n;i++)
            {
                if (n % i == 0)
                    tong += i;   
            }
            if (tong == n)
                Console.WriteLine("{0} la so hoan hao", n);
            else
                Console.WriteLine("{0} khong phai so hoan hao", n);
            Console.ReadLine();
            */
            Console.WriteLine("So hoan hao can tim trong day la: ");
            for (int n=1;n<=1000;n++)
            {
                int tong = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        tong += i;
                }
                if (tong == n)
                    Console.Write(n + " ");
                    
            }

            Console.ReadKey();
        }
    }
}
