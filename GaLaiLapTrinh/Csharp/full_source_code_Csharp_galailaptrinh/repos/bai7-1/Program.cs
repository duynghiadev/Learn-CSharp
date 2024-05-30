using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            nhập vào điểm trung bình, và kết quả xếp loại của học sinh theo tiêu chuẩn sau:
            - Giỏi: Nếu Điểm kết quả >= 8
            - Khá: Nếu 8 > Điểm >= 6.5
            - Trung bình: Nếu 6.5 > Điểm >= 5
            - Yếu: Nếu Điểm < 5
            */
            float dtb;
            Console.WriteLine("moi nhap vao dtb: ");
            dtb =float.Parse(Console.ReadLine());

            //check dieu kien
            if (dtb >= 8)
                Console.WriteLine("xep loai gioi");
            else if (dtb >= 6.5 && dtb < 8)
                Console.WriteLine("xep loai kha");
            else if (dtb >= 5 && dtb < 6.5)
                Console.WriteLine("xep loai kha");
            else
                Console.WriteLine("xep loai yeu");

            Console.ReadKey();

        }
    }
}
