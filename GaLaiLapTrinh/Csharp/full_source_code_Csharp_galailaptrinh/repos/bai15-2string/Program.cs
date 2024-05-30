using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_2string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.IndexOf
            string chuoi20 = "1aau";
            int kq4 = chuoi20.IndexOf('a');
            Console.WriteLine(kq4);


            //15.LastIndexOf
            string chuoi21 = "1aau";
            int kq5 = chuoi21.LastIndexOf('a');
            Console.WriteLine(kq5);

            //16.Remove
            string chuoi22 = "123456";
            Console.WriteLine(chuoi22);
            chuoi22 = chuoi22.Remove(2, 3);
            Console.WriteLine(chuoi22);

            //17.Replace
            string chuoi23 = "123445674489";
            chuoi23 = chuoi23.Replace("44", "AAA");
            Console.WriteLine(chuoi23);

            //18. StartsWith
            string chuoi24 = "ditimtinhyeu.mp3";
            bool kt6 = chuoi24.StartsWith("ditim");
            Console.WriteLine(kt6);

            //19.Substring (trích lọc chuỗi con từ chuỗi ban đầu)
            string chuoi25 = "123456";
            string chuoi26 = chuoi25.Substring(2,3);
            Console.WriteLine(chuoi26);

            //20.ToLower(); trả về chữ thường, ToUpper(); chữ hoa 
            string chuoi27 = "Con di hoc ve muon HAHAHA";
            Console.WriteLine(chuoi27);
            chuoi27 = chuoi27.ToLower(); // ép sang thường 
            Console.WriteLine(chuoi27); 
            chuoi27=chuoi27.ToUpper(); // chuyển sang chữ in hoa
            Console.WriteLine(chuoi27);

            //21 Trim() xóa toàn bộ khoảng trắng ở đầu và cuối
            string chuoi28 = "           4545            45         ";
            chuoi28=chuoi28.Trim();
            Console.WriteLine(chuoi28);

            //22 TrimEnd() xóa toàn bộ khoảng trắng ở cuối chuỗi
            string chuoi29 = "            234242424   232323             ";
            chuoi29=chuoi29.TrimStart();
            Console.WriteLine(chuoi29);

            //24 split tách chuỗi=> trả về mảng 
            string chuoi30 = @"D:\galailaptrinh\Maria\video.mp4";
            string[] lst = chuoi30.Split('\\');
            Console.WriteLine(lst[0]);
            Console.WriteLine(lst[1]);
            Console.WriteLine(lst[2]);
            Console.WriteLine(lst[3]);

            //25. joint string nối các phần tử của 1 list thàng 1 chuỗi 
            string chuoi31 = string.Join("++", lst);
            Console.WriteLine(chuoi31);

            Console.ReadKey();

        }
    }
}
