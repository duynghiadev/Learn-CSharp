using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. khai báo chuỗi
            string chuoi = "Gà lại lập trình";
            Console.WriteLine("chuỗi bạn vừa nhập là: " +chuoi);

            //2 khai báo nguyên văn @ 
            string chuoi2 = "D:\\galailaptrinh";
            string chuoi3 = "có người nói rằng :\" abc \" ";
            string chuoi4 = "có người nói rằng : \t \" abc \" ";
            Console.WriteLine(chuoi2);
            Console.WriteLine(chuoi3);
            Console.WriteLine(chuoi4);

            //3 chuyển đổi sang chuỗi 
            int i = 12223;
            string chuoi5 = i.ToString(); // cách 1
            string chuoi6 = i +""; // cách 2
            string chuoi7 = Convert.ToString(i); //cách 3
            Console.WriteLine(chuoi5);
            Console.WriteLine(chuoi6);
            Console.WriteLine(chuoi7);

            //4. Tách chuỗi ra thành các ký tự lẻ, cho vào 1 mảng.
            string chuoi8 = "Xinchao";
            char[] lst = chuoi8.ToCharArray();
            Console.WriteLine(lst);
            Console.WriteLine(lst.GetType().ToString());

            //5. Length: Trả về độ dài của chuỗi( số ký tự chuỗi, bao gồm cả space)
            string chuoi9 = "Test  haha";
            int j = chuoi9.Length;
            Console.WriteLine(j);
            Console.WriteLine("ký tự thứ 2 của chuỗi là: " +chuoi9[j-2]);


            //7.so sánh chuỗi 
            string chuoi10 = "123456o";
            string chuoi11 = "123456o";
            int sosanh = chuoi11.CompareTo(chuoi10);
            Console.WriteLine(sosanh);

            //8.  Kiểm tra chuỗi con
            string chuoi12 = "abc";
            string chuoi13 = "lkàlaksjfalksfa bc1243";
            bool l=chuoi13.Contains(chuoi12);
            Console.WriteLine(l);
            //9. Hàm Copyto
            string chuoi14 = "123456";
            char[] lst2 = new char[6]; // tạo ra 1 mảng có độ dài = 6
            lst2[0] = 'a';
            lst2[1] = 'b';
            Console.WriteLine(lst2); //a2345 
            chuoi14.CopyTo(1, lst2, 1, 4);
            Console.WriteLine(lst2);

            //10.Hàm bool EndsWith(string value)
            string chuoi15 = "ditimtinhyeu.mp3 ";
            bool kt=chuoi15.EndsWith("3");
            Console.WriteLine(kt);

            //11.gán chuỗi theo string.Format 
            int n = 14;
            string chuoi16 = string.Format("n={0} và căn bậc 2 của n là {1}", n, Math.Sqrt(n));
            Console.WriteLine(chuoi16);
            Console.WriteLine("n={0} và căn bậc 2 của n là {1}", n, Math.Sqrt(n)); //xuất cho người dùng xem

            //12. bool Equals
            string chuoi17 = "ha5ha";
            string chuoi18 = "haha";
            bool kt2 = chuoi17.Equals(chuoi18);
            Console.WriteLine(kt2);

            //13.string.Insert(<vị trí start_index chuỗi ban đầu>,<chuỗi cần chèn>);
            string chuoi19 = "123";
            string chuoi20 = "Obama";
            chuoi19 = chuoi19.Insert(2,chuoi20);
            Console.WriteLine(chuoi19);
            Console.ReadKey();
        }
    }
}
