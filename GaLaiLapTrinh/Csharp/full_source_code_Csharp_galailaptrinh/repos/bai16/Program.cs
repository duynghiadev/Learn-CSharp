using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            //1. khai báo mảng 
            int[] stt;
            char[] ch;
            string[] ten;

            //2. khởi tạo mảng
            //tenMang = new Kieudulieu[soPhanTu]
            stt = new int[5]; // mặc định các phần từ là 0
            foreach (int i in stt)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("mảng stt2 là: ");
            int[] stt2= new int[7];
            foreach (int i in stt2)
            {
                Console.Write(i + " ");
            }

            //3.khởi tạo và gán luôn giá trị cho mảnh
            //Kiểu dữ liệu[] tên_mảng = new Kieudulieu[Số_phần_tử]{pt1,pt2,pt3...};
            int[] mang2 = {1,2,3,4,6,5,8,9};
            Console.WriteLine();
            Console.WriteLine("mảng 2 là: ");
               foreach (int i in mang2)
            {
                Console.Write(i + " ");
            }

            //4. Khởi tạo 1 mảng ngẫu nhiên
            Random r = new Random();
            int[] mang3={r.Next(51),r.Next(61)};
            Console.WriteLine();
            Console.WriteLine("mảng 3 là: ");
            foreach (int i in mang3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //7. Length kiểm tra độ dài
            int dai = mang3.Length;
            Console.WriteLine("chiều dài mảng 3 là: "+ dai);

            //8. Truy xuất phần tử qua index 
            int[] mang4 = { 1, 3, 5 };
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[1]);
            Console.WriteLine(mang4[mang4.Length-1]);
            //9.Thay đổi giá trị phần tử của mảng bằng cách gọi index 
            int[] mang5 = { 1, 3, 5 ,9,8};
            mang5[1] = 100;
            Console.WriteLine("mảng 5 sau khi thay đổi giá trị là: ");
            foreach (int i in mang5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //10. duyệt mảng for ( duyệt theo index )
            int[] mang6 = { 1, 35, 5, 9, 8 };
            for (int i = 0; i < mang6.Length; i++)
            {
                Console.Write(mang6[i]+" ");
            }
            Console.WriteLine();

            //12.Phép gán mảng : gán mảng mới = mảng đã tồn tại (tham chiếu cùng vùng nhớ)
            int[] mang8 = { 1, 2, 3, 4, 5, 6 };
            int[] mang9 = mang8;
            mang8[0] = 100;
            Console.WriteLine("mảng 8 sau đổi tại vị trí index 0 là : " +mang8[0]);
            Console.WriteLine("mảng 9 sau đổi tại vị trí index 0 là : " +mang9[0]);

            //13.CopyTo (copy đè giá trị vào mảng đã có)  
            int[] mang10 = { 100, 200, 300, 400};
            int[] mang11 = { 1, 2, 3, 4, 5, 6 ,7};
            mang10.CopyTo(mang11, 2);
            Console.WriteLine("mảng 11 sau khi thay đổi giá trị là: ");
            foreach (int i in mang11)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //14. Copy(Array_nguồn, Array_đích, Int32) (int32 số phần tử muốn copy) 
            int[] mang12 = { 100, 200, 300, 400 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 3);
            Console.WriteLine("mảng 13  là: ");
            foreach (int i in mang13)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //15. Clone  (tạo ra mảng mới trên vùng nhớ mới) COPY TẤT CẢ CÁC PHẦN TỬ CỦA MẠNG CŨ SANG MẢNG MỚI
            int[] mang14 = {1,2,3,4,5,6,7};
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine("mảng 15  là: ");
            foreach (int i in mang15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //16 Reverse : Đảo ngược mảng
            int[] mang16 = {1,2,3,4,5,6,7,8};
            Array.Reverse(mang16);
            Console.WriteLine("mảng 16  là: ");
            foreach (int i in mang16)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //17.Array.Sort (Sắp xếp mảng tăng dần ) 
            int[] mang17 = { 10, 2, 35, 4, 5, 6, 7, 8 };
            Array.Sort(mang17);
            Console.WriteLine("mảng 17  là: ");
            foreach (int i in mang17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
