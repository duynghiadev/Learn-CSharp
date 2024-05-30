using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bai18_2_path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Path.Combine Kết hợp các chuỗi thành dường dẫn
            string path = Path.Combine(@"C:\", "Tuhoc3.cc", "teptinxx.txt");
            Console.WriteLine(path);

            //2.Path.ChangeExtension() Thay đổi phần mở rộng của đường dẫn
            string path2 = Path.ChangeExtension(path, "pdf");
            Console.WriteLine(path2);


            //3. Path.GetDirectoryName trả về thư mục chứa file theo đường dẫn path : 
            string Thumuc = Path.GetDirectoryName(path);
            Console.WriteLine(Thumuc);

            //4. Path.GetExtension : Lấy phần mở rộng 
            string morong = Path.GetExtension(path2);
            Console.WriteLine(morong);

            //5. Path.GetFileName trả về tên file
            string path5 = Path.GetFileName(path);
            Console.WriteLine(path5);

            //6. Path.GetFullPath Lấy đường dẫn đầy đủ
            string path6 = Path.GetFullPath(@"thumuc\abc.txt");
            Console.WriteLine(path6);

            //TH2
            string path7 = Path.GetFullPath(@"C:\thumuc\abc.txt");
            Console.WriteLine(path7);

            //7. Path.GetPathRoot Lấy gốc của đường dẫn
            string path8 = Path.GetPathRoot(@"C:\thumuc\abc.txt");
            Console.WriteLine(path8);

            //8. Để lấy đường dẫn đến một số thư mục đặc biệt của hệ thống,
            //có thể dùng phương thức Environment.GetFolderPath.
            // Ví dụ, lấy thư mục MyMusic, MyDocument, Mypicture
            string path_db = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            Console.WriteLine(path_db);
            Console.ReadKey();
        }
    }
}
