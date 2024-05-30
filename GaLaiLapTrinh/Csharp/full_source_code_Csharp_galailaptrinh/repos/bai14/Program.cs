using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1,khai báo
            char ch1 = '2'; // khai báo bắt buộc dùng nháy đơn 
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetType().ToString());


            // cách 2
            char ch2 = (char)65;
            Console.WriteLine(ch2);
            Console.WriteLine(ch2.GetType().ToString());


            // Ép kiểu char cho dữ liệu nhập vào 
            char ch3 = char.Parse("b");
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());

            //Chuyển đổi kiểu dữ liệu:
            char ch4 = Convert.ToChar("t");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());

            //So sánh 2 ký tự (Compare) 
            char ch7 = 'a'; //97
            char ch8 = 'b'; //98
            char ch9 = 'a'; //97
            char ch10 = 'm'; // 109
            Console.WriteLine(ch7.CompareTo(ch8));
            Console.WriteLine(ch8.CompareTo(ch7));
            Console.WriteLine(ch7.CompareTo(ch9));
            Console.WriteLine(ch7.CompareTo(ch10));

            //So sánh 2 ký tự (Equals) => trả về True, False :  
            Console.WriteLine(ch7.Equals(ch8));
            Console.WriteLine(ch7.Equals(ch9));

            //Các phương thức - Char method in C#
            Console.WriteLine(Char.IsDigit('e')); // chữ số 
            Console.WriteLine(Char.IsLetter('A')); // chữ cái
            Console.WriteLine(Char.IsWhiteSpace('4')); // space
            Console.WriteLine(Char.IsLower('A')); // ký tự viết thường
            Console.WriteLine(Char.IsUpper('A')); // ký tự viết hoa
            Console.WriteLine(Char.ToUpper('A')); // chuyển ký tự sang in hoa
            Console.WriteLine(Char.ToLower('G')); // chuyển ký tự sang in thường
            Console.ReadKey();

        }
    }
}
