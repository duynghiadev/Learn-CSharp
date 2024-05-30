using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18_list
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            //2.khởi tạo 1 list
            List<string> ds1 = new List<string>(); //danh sach cac phan tu la string
            List<int> ds2 = new List<int>(); //danh sach cac phan tu la so nguyen
            //3.Khởi tạo danh sách có sẵn một số phần tử, thì các phần tử liệt kê sau {}
            List<int> ds3 = new List<int>() { 1,2,5,8,9 };
            foreach (int i in ds3)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //4.Phướng thức add(Thêm phần từ vào cuối list)
            List<int> ds4 = new List<int>() { 1, 2, 5 };
            ds4.Add(100);
            ds4.Add(200);
            Console.WriteLine("Danh sách 4 : ");
            foreach (int i in ds4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //5. Remove (object) ( xóa phần tử đầu tiên nếu tìm thấy trong list) 
            List<int> ds5 = new List<int>() { 8,1, 2, 1,1,5 };
            ds5.Remove(1);
            Console.WriteLine("Danh sách 5 : ");
            foreach (int i in ds5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //6. Count : Đếm số phần tử trong danh sách
            List<int> ds6 = new List<int>() { 8, 1, 2, 1, 1, 5 };
            Console.WriteLine(ds6.Count);

            //7. Clear(); Xóa toàn bộ phần tử
            List<int> ds7 = new List<int>() { 8, 1, 2, 1, 1, 5 };
            ds7.Clear();

            //8. ds8.AddRange(ds9) : Thêm toàn bộ danh sách 9 vào cuối danh sách 8
            List<int> ds8 = new List<int>() { 8, 1, 2 };
            List<int> ds9 = new List<int>() { 100,200 };
            ds8.AddRange(ds9);
            Console.WriteLine("Danh sách 8: ");
            foreach (int i in ds8)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //9. bool <ds>.Contains(<value>)
            //: kiểm tra có tồn tại value trong list không
            //Có trả về true, không trả về False 
            List<int> ds10 = new List<int>() { 100, 200 };
            bool kq=ds10.Contains(100);
            Console.WriteLine(kq);

            //10. GetRange(int index, int ount)
            // Trả về 1 list con, lấy từ index, và count ký tự của list nguồn
            List<int> ds11 = new List<int>() { 100, 200 ,1,5,8,9,7};
            List<int> ds12 = ds11.GetRange(0, 4);
            Console.WriteLine("Danh sách 12: ");
            foreach (int i in ds12)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //11. int IndexOf(<value>) : trả về vị trí index giá trị tìm thấy
            // Nếu o thấy trả  về -1 
            List<int> ds13 = new List<int>() { 100, 200, 1, 5, 200, 9, 7 };
            int checkIndex = ds13.IndexOf(2000);
            Console.WriteLine(checkIndex);

            //12. Insert(int index, value); Chèn thêm value vào vị trí index chỉ định 
            List<int> ds14 = new List<int>() { 100, 200, 1, 5, 200, 9, 7 };
            ds14.Insert(3, 1000);
            Console.WriteLine("Danh sách 14: ");
            foreach (int i in ds14)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //13 InsertRange(index, <danh sách chèn thêm>)
            //chèn <danh sách chèn thêm> vào vị trí index của list gốc
            List<int> ds15 = new List<int>() { 100, 200, 1, 5, 200, 9, 7 };
            List<int> ds16 = new List<int>() { 1,2 };
            ds15.InsertRange(2,ds16);
            Console.WriteLine("Danh sách 15: ");
            foreach (int i in ds15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //14. RemoveAt(int index); Xóa ptu tại vị trí index chỉ định 
            List<int> ds17 = new List<int>() { 100, 200, 1, 5, 200, 9, 7 };
            ds17.RemoveAt(1);
            Console.WriteLine("Danh sách 17: ");
            foreach (int i in ds17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //15. RemoveRange(int index, int count) :
            //xoa từ index và xóa count phần tử 
            List<int> ds18 = new List<int>() { 100, 200, 1, 5, 200, 9, 7 };
            ds18.RemoveRange(1, 3);
            Console.WriteLine("Danh sách 18: ");
            foreach (int i in ds18)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //16 <ds>.Reverse(); Đảo ngược
            List<int> ds19 = new List<int>() { 100, 200, 1, 5, 200, 9, 7 };
            ds19.Reverse();
            Console.WriteLine("Danh sách 19: ");
            foreach (int i in ds19)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //17. <ds>.Sort(); Sắp xếp tăng dần
            List<int> ds20 = new List<int>() { 100, 200, 1, 5, 200, 9, 7 };
            ds20.Sort();
            Console.WriteLine("Danh sách 20: ");
            foreach (int i in ds20)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //18. BinarySearch 
            int kq2 = ds20.BinarySearch(2);
            Console.WriteLine(kq2);


            //19. Max, min 
            int kq3 = ds20.Max();
            Console.WriteLine("giá trị max là : "+ kq3);
            Console.WriteLine("giá trị min là : "+ ds20.Min());
            Console.ReadKey();
        }
    }
}
