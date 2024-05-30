using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_6_quytrongnam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bài tập Csharp 09: Viết chương trình nhập vào tháng trong năm, cho biết tháng đó thuộc quý mấy
            Gợi ý :
            1 năm có 4 quý, mỗi quý 3 tháng :
	            + Quý 1 : tháng 1,2,3
	            + Quý 2 : tháng 4,5,6
	            + Quý 3 : tháng 7,8,9
	            + Quý 4 : tháng 10,11,12
            */
            Console.OutputEncoding=Encoding.UTF8;
            int thang;
            Console.WriteLine("mời thím nhập vào 1 tháng bất kỳ: ");
            thang=int.Parse(Console.ReadLine());
            if (thang==1 || thang ==2 || thang==3)
                Console.WriteLine("tháng {0} thuộc quý 1", thang);
            else if (thang == 4 || thang == 5 || thang == 6)
                Console.WriteLine("tháng {0} thuộc quý 2", thang);
            else if (thang == 7 || thang == 8 || thang == 9)
                Console.WriteLine("tháng {0} thuộc quý 3", thang);
            else if (thang == 10 || thang == 11 || thang == 12)
                Console.WriteLine("tháng {0} thuộc quý 4", thang);
            else
                Console.WriteLine("Tháng nhập o hợp lệ");
            Console.ReadLine();



        }
    }
}
