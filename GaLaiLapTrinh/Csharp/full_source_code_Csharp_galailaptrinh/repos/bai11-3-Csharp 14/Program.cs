using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_3_Csharp_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Viết chương trình tính tổng các số lẻ từ 1 đến n, n nhập từ bàn phím
                1.Nhập n = 7, Bỏ qua cộng tổng với số 3 => in ra kết quả 
                    (gợi ý đáp án : 1+5+7 =13)
                2.Thử break khi vòng lặp chạy đến giá trị n=3 
             */
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            int tong = 0;
            Console.WriteLine("mời nhập vào số nguyên n: ");
            n=int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i+=2)
            {
                if (i == 3)
                    break;
                else
                    tong += i;
            }
            Console.WriteLine("Tổng các số lẻ từ 1 đến {0} là {1}", n, tong);
            Console.ReadKey();


 


        }
    }
}
