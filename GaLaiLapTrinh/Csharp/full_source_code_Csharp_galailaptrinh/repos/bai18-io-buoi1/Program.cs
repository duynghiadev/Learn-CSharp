using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bai18_io_buoi1
{
    internal class Program
    {   
        static void DSThuMucFile(string path)
        {
            string[] Thumucs = Directory.GetDirectories(path);
            string[] Files = Directory.GetFiles(path);
            // xuat danh sach 
            foreach (string File in Files)
            {
                Console.WriteLine(File);
            }
            //xuat thu muc 
            foreach(string tm in Thumucs)
            {
                Console.WriteLine(tm);
                DSThuMucFile(tm);
            }
        }
        static void Main(string[] args)
        {
            //get ten thu muc 
            DirectoryInfo currDir = new DirectoryInfo(".");
            Console.WriteLine(currDir.FullName);
            Console.WriteLine(currDir.Name);

            DirectoryInfo duongdan = new DirectoryInfo(@"C:\123\test1");
            //day ra ful duong dan
            Console.WriteLine(duongdan.FullName);
            // lay ten thu muc 
            Console.WriteLine(duongdan.Name);
            //get thu m uc cha 
            Console.WriteLine(duongdan.Parent);
            //get thuoc tinh 
            Console.WriteLine(duongdan.Attributes);
            //get thoi gian tao thu muc
            Console.WriteLine(duongdan.CreationTime);
            Console.WriteLine(duongdan.Root);


            //3.tao thu muc
            //cach 1
            DirectoryInfo tm1 = new DirectoryInfo(@"C:\Tuhoc.cc");
            tm1.Create();

            //cach 2 
            string tm2 = @"C:\tuhoc2.cc";
            Directory.CreateDirectory(tm2);


            //4.Exists(path) Kiểm tra xem thư mục có tồn tại(true) hay không(false) 
            string path1  = @"C:\tuhoc3.cc";
            if (Directory.Exists(path1))
            {
                Console.WriteLine("thu muc nay da ton tai");
            }
            else
            {
                Console.WriteLine("thu muc chua co");
            }

            //5. Delete a directory
            string path2 = @"C:\tuhoc2.cc";
            Directory.Delete(path2);

            //6.Directory.GetFiles(path) Trả về danh sách file nằm trong path
            string path3 = @"C:\Tuhoc.cc";
            string[] danhsach = Directory.GetFiles(path3);
            Console.WriteLine($"Danh sach file nam trong thu muc {path3}");
            foreach(string file in danhsach)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("-------------------------");
            //6.Directory.GetDirectories(path) Trả về danh sách tm nằm trong path
            string path4 = @"C:\";
            string[] dsthumuc = Directory.GetDirectories(path4);
            Console.WriteLine($"Danh sach thu muc nam trong thu muc {path4}");
            foreach (string tm in dsthumuc)
            {
                Console.WriteLine(tm);
            }


            // 7.
            string path5 = @"C:\Tuhoc.cc";
            Console.WriteLine($"danh sach file va thu muc trong {path5}");
            DSThuMucFile(path5);



            //8. Tìm kiếm file 
            DirectoryInfo mydata = new DirectoryInfo(@"C:\Tuhoc.cc");
            FileInfo[] txtFiles = mydata.GetFiles("*.txt",SearchOption.AllDirectories);

            //so file thoa man dieu kien tim kiem
            Console.WriteLine($"Tim thay : {txtFiles.Length} file txt thoa man ");
            foreach (FileInfo file in txtFiles)
            {
                //day theo ten 
                Console.WriteLine(file.Name);
            }


            Console.ReadKey();
        }
    }
}
