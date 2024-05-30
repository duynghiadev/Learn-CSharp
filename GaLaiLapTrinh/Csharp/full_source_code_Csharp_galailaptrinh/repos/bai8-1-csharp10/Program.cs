using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8_1_csharp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bài tập Csharp 10: 
            Viết chương trình nhập vào điểm trung bình, và kết quả xếp loại của học sinh theo tiêu chuẩn sau: ( dùng toán tử 3 ngôi ) 
             Giỏi: Nếu Điểm >= 8 
             Khá: Nếu 8 > Điểm >= 6.5
             Trung bình: Nếu 6.5 > Điểm >= 5 
             Yếu: Nếu Điểm < 5 

            */
            Console.OutputEncoding = Encoding.UTF8;
            float dtb;
            Console.WriteLine("mời thím nhập vào điểm trung bình: ");
            dtb = float.Parse(Console.ReadLine());
            //biến = biểu thức 1 ? biểu thức 2: biểu thức 3
            string kq = (dtb >= 8) ? "Giỏi" : ((dtb < 8 && dtb >= 6.5) ? "Khá" : (dtb < 6.5 && dtb >= 5) ? "Trung bình" : "Yếu");
            Console.WriteLine("Điểm trung bình của bạn là {0}, bạn xếp loại {1} ",dtb, kq);
            Console.ReadLine();

        }
    }
}
