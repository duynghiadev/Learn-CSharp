using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9_1_csharp_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            switch (biểu_thức)
            {
            case <giá trị 1>: <câu lệnh 1>;
                break;
            case <giá trị 1>: <câu lệnh 1>;
                break;
            .....
            default: <câu lệnh mặc định nếu o thỏa tất cả các case phía trên>
                break;
            }
            */
            // viết ctrinh khung tìm kiếm. cho người dùng nhập vào lựa chọn 
            //1. tìm theo tên
            //2. tìm theo tác giả
            //3. tìm theo nhà xuất bản
            //4. tìm theo tiêu đề

            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            Console.WriteLine("CHƯƠNG TRÌNH TÌM KIẾM");
            Console.WriteLine("1. tìm theo tên");
            Console.WriteLine("2. tìm theo tác giả");
            Console.WriteLine("3. tìm theo nhà xuất bản");
            Console.WriteLine("4. tìm theo tiêu đề");
            Console.WriteLine("Mời bấm phím để lựa chọn ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. tìm theo tên");
                    break;                      
                case 2:
                    Console.WriteLine("2. tìm theo tác giả");
                    break;
                case 3:
                    Console.WriteLine("3. tìm theo nhà xuất bản");
                    break;
                case 4:
                    Console.WriteLine("4. tìm theo tiêu đề");
                    break;
                default:
                    Console.WriteLine("Phím bấm không hợp lệ");
                    break;

            }    


            Console.ReadKey();
        }
    }
}
