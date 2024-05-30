using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18_2_giaibaptapc25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Csharp 25 :
            //Viết chương trình nhập vào 1 danh sách list sau đó:
            //#1. tạo ra 1 list mới bình phương các phần từ 
            //#2.Xác định bao nhiêu phần tử lớn hơn 50
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập vào số phần tử của danh sách: ");
            int n= int.Parse(Console.ReadLine()); 
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("mời nhập vào phần tử thứ {0} của danh sách", i+1);
                ds.Add(int.Parse(Console.ReadLine()));
            }
            //0. xuất list sau khi nhập
            Console.WriteLine("list bạn vừa nhập là: ");
            foreach (int i in ds)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //1. tạo ra 1 list mới bình phương các phần từ
            List<double> ds2 = new List<double>();
            foreach (int i in ds)
            {
                ds2.Add(Math.Pow(i, 2));
            }
            //xuất ds2 
            Console.WriteLine("list 2 là: ");
            foreach (int i in ds2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // 2.Xác định bao nhiêu phần tử lớn hơn 50
            int dem = 0;
            foreach (int i in ds2)
            {
                if (i>50)
                    dem++;
            }
            Console.WriteLine("có {0} phần tử lớn hơn 50 trong danh sách 2 " , dem);

            Console.ReadLine();
        }
    }
}
