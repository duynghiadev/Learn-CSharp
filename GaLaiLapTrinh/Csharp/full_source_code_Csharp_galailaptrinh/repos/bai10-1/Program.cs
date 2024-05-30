using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //viết chương trình nhập vào số n từ bàn phím
            // n phải nằm trong khoảng từ 1-99
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("mời nhập vào số nguyên n từ 1 - 99: ");
            n = int.Parse(Console.ReadLine());
            // chek điều kiện
            while (n<1 || n>99)
            {
                Console.WriteLine("Nhập  lại n, n chỉ được phép từ 1-99: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Bạn đã nhập xong giá trị n, n=" + n);
            Console.ReadLine();

        }
    }
}
