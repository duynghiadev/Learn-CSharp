using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18_1_giaibaitapc24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Csharp 24
            //Viết chương trình tạo ra 1 list có n phần tử, n nhập từ bàn phím 
            //Các phần tử là số ngẫu nhiên từ(1,100)
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập vào số phần tử n: ");
            int n=int.Parse(Console.ReadLine());
            Random r = new Random();
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine(i);
                ds.Add(r.Next(1,101));
            }
            Console.WriteLine("danh sách ngẫu nhiên vừa tạo ra là: ");
            foreach (int i in ds)
            {
                Console.Write(i+" ");
            }    
            Console.ReadKey();  
        }
    }
}
