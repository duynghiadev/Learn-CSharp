using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16_viduvandung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  1. Viết chương trình tạo 1 mảng 1 chiều gồm các phần tử là số nguyên, có n phần tử ngẫu nhiên, n do người dùng nhập từ bàn phím 
                2. Xuất các giá trị trong mảng
                3. Đảo ngược mảng, và xuất mảng sau khi đảo ngược
                4. Sắp xếp mảng tăng dần
                5. Tính tổng các phần tử trong mảng
                6. Cho người dùng nhập 1 số bất kỳ, 
                kiểm tra số đó có tồn tại trong mảng hay không, 
                nếu có xuất ra vị trí index của số đó trong mảng

             */
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập vào số phần tử của mảng : ");
            int n=int.Parse(Console.ReadLine());
            //khai báo mảng 
            int[] Mang =new int[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mang[i]+" ");
            }  
            Console.WriteLine();

            //1. nhập giá trị ngẫu nhiên 
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Mang[i] = r.Next(101);
            }
            //xuất mảng 
            Console.WriteLine("Mảng ngẫu nhiên là: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mang[i] + " ");
            }
            Console.WriteLine();

            //3. Đảo ngược mảng 
            Array.Reverse(Mang);
            Console.WriteLine("Mảng sau khi đảo là: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mang[i] + " ");
            }
            Console.WriteLine();

            //4.Sort mảng
            Array.Sort(Mang);
            Console.WriteLine("Mảng sau sx là: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mang[i] + " ");
            }
            Console.WriteLine();
            //5.tính tổng các phần từ
            int tong = 0;
            foreach (int i in Mang)
                tong += i;
            Console.WriteLine("Tổng các phần tử của mảng là: "+tong);

            //6. Tìm kiếm mảng (tìm BinarySearch chỉ áp dụng khi mảng đã sắp xếp)
            Console.WriteLine("mời thím nhập vào số cần tìm: ");
            int so=int.Parse(Console.ReadLine());
            int kq =Array.BinarySearch(Mang, so);
            if (kq == -1)
                Console.WriteLine("Không tìm thấy rồi sếp ơi");
            else
                Console.WriteLine("Tìm thấy số {0} ở vị trí index {1}", so,kq);


            //7 tìm thông thường, o dùng BinarySearch
            int demkq = 0;
            for (int i = 0;i < n;i++)
            {
                if(Mang[i] ==so)
                {
                    Console.WriteLine("Tìm thấy {0} tại vị trí {1}", so,i);
                    demkq++;
                }
                
            }  
            if (demkq== 0)
                Console.WriteLine("Không tìm thấy giá trị đó sếp ơi");
            Console.ReadKey();
        }
    }
}
