using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_3_namnhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *   Bài tập Csharp 06: Viết chương trình nhập vào 1 năm dương lịch, kiểm tra năm đó có phải năm nhuận hay không .
            Gợi ý : Năm nhuận là năm
             (chia hết cho 4, và không chia hết cho 100) hoặc ( chia hết cho 400)
            ((nam %4 ==0) && (nam %100 !=0)) || ( nam %400 ==0))

            Case test : 
               Năm nhuận : 2004, 2008, 2012, 2016, 2020, 2024
               Năm không nhuận : 1900, 2005

            */
            int nam;
            Console.WriteLine("moi thim nhap vao 1 nam bat ky: ");
            nam = int.Parse(Console.ReadLine());
            if ((nam%4==0 && nam%100 !=0) || nam%400==0)
                Console.WriteLine("{0} la nam nhuan" ,nam);
            else
                Console.WriteLine("{0} khong phai la nam nhuan", nam);

            Console.ReadKey();

                

        }
    }
}
