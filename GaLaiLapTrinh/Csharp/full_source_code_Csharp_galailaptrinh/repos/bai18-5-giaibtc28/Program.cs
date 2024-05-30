using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18_5_giaibtc28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Csharp 28 :
               Viết chương trình in số lớn thứ 2 và số nhỏ thứ 2 trong list
            # 2: in ra vị trí index số đó

            ví dụ list 
            lst={1,2,3,4,5}
            # số lớn thứ 2: 4 , vị trí index trong list là 3
            # số nhỏ thứ 2 trong list là 2, vị trí index trong list là 1 
            */
            Console.OutputEncoding = Encoding.UTF8; 
            List<int> ds = new List<int>() { 1,15,3,4,8,6};
            List<int> ds2 = new List<int>();
            ds2.AddRange(ds);
            // xuất danh sách 2 
            Console.WriteLine("danh sách 2 sau khi copy là: ");
            ds2.Remove(ds2.Max());
            ds2.Remove(ds2.Min());
            foreach (int i in ds2)
            {
                Console.Write(i+" ");
            }  
            Console.WriteLine();
            Console.WriteLine("Phần tử lớn thứ 2 trong danh sách là : "+ds2.Max());
            Console.WriteLine("Phần tử nhỏ thứ 2 trong danh sách là : "+ds2.Min());
            //Console.WriteLine("giá trị max là: " + ds.Max());
            // in ra vị trí index dùng
            for (int i = 0;i<ds.Count; i++)
            {
                if(ds[i]==ds2.Min())
                    Console.WriteLine("vị trí index của số nhỏ thứ 2 trong dãy là: "+i);
            }

            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == ds2.Max())
                    Console.WriteLine("vị trí index của số lớn thứ 2 trong dãy là: " + i);
            }
            Console.ReadLine();

        }
    }
}
