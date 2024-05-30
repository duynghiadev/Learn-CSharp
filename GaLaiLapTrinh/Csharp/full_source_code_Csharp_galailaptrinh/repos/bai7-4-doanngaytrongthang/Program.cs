using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_4_doanngaytrongthang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bài tập Csharp 07: Viết chương trình cho người dùng nhập vào 1 tháng bất kỳ từ 1 – 12 => Cho biết tháng đó có bao nhiêu ngày ?
            Gợi ý :
            _ Tháng 1,3,5,7,8,10,12 có 31 ngày 
            _ Tháng  4,6,9,11 có 30 ngày 
            _ Nếu tháng 2 thì yêu cầu nhập thêm năm: 
	            + nếu năm nhuận thì tháng 2 có 29 ngày
	            + năm không  nhuận thì tháng 2 có 28 ngày 

            */
            int thang, nam;
            Console.WriteLine("moi thim nhap vao thang bat ky: ");
            thang = int.Parse(Console.ReadLine());
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                Console.WriteLine("thang {0} co 31 ngay", thang);
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                Console.WriteLine("thang {0} co 30 ngay", thang);
            else if (thang == 2)
            {
                Console.WriteLine("moi thim nhap vao nam: ");
                nam = int.Parse(Console.ReadLine());
                if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                    Console.WriteLine("nam {0} ban vua nhap la nam nhuan, nen thang {1} co 29 ngay", nam, thang);
                else
                    Console.WriteLine(" thang {0} co 28 ngay", thang);
            }
            else
                Console.WriteLine("Thang ban nhap khong ton tai");
            Console.ReadKey();


                






        }
    }
}
