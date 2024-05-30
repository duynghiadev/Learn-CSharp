using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18_4_baitapc27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Csharp 27
            //Viết chương trình nhập vào 1 list 
            //1 in ra có bao nhiêu số nhỏ hơn 5, 
            //2 và in ra vị trí index các số đó
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("mời nhập vào số phần tử n: ");
            int n = int.Parse(Console.ReadLine());  
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhập vào phần tử thứ {0} của dãy ", i+1);
                ds.Add(int.Parse(Console.ReadLine()));
            }
            //xuất danh sách 
            Console.WriteLine("danh sách bạn vừa nhập là: ");
            foreach (int i in ds)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            //1 in ra có bao nhiêu số nhỏ hơn 5,
            int dem = 0;
            foreach (int i in ds)
            {
                if (i<5)
                    dem++;
            }
            Console.WriteLine("Có {0} phần tử <5 trong danh sách", dem);

            //2 và in ra vị trí index các số đó
            Console.WriteLine("vị trí index của các số <5 trong dãy là: ");
            for (int i = 0;i<ds.Count;i++)
            {
                //Console.WriteLine(i);
                if (ds[i]<5)
                    Console.Write(i+" ");
            }    

            Console.ReadKey();  
        }
    }
}
