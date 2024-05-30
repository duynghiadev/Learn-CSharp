using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20_ham
{
    internal class Program
    {
        /// <summary>
        /// Hàm này là để tính tổng nhé thím ơi
        /// </summary>
        /// <param name="x">nhập x nguyên nhé thím ơi</param>
        /// <param name="y">nhập y nguyên nhé thím ơi</param>
        /// <param name="z">nhập z nguyên nhé thím ơi</param>
        /// <returns>nó return về tổng 3 số nhé ba ơi</returns>
        static int Tong(int x, int y , int z)
        {
            return x + y + z;
        }
        //giai thừa 
        static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1;i<=n;i++)
                gt*=i;
            return gt;
        }

        //ví dụ static void
        static void Xinchao(string m)
        {
            if (m=="nam")
                Console.WriteLine("Xin chào mình là boy");
            if (m=="nu")
                Console.WriteLine("Xin chào mình là girl");
        }
        //Truyền tham trị : không thay đổi sau khi gọi hàm
        static void Thamtri(int a)
        {
            a = a + 1;
            Console.WriteLine("giá trị a trong hàm là: " +a);
        }
        //ref : Truyền tham chiếu (truyền tham biến) : Có thay đổi giá trị của biến sau khi gọi hàm
        static void ThamchieuRef (ref int b)
        {
            b++;
            Console.WriteLine("b trong hàm là: "+b);
        }

        //out : Truyền tham chiếu (truyền tham biến) : Có thay đổi biến sau khi gọi hàm
        static void ThamchieuOut(out int c)
        {
            c = 5;
            Console.WriteLine("c trong hàm là : "+c);
        }

        static void Main(string[] args)
        {   
            Console.OutputEncoding  = Encoding.UTF8;
            int kq =Tong(1,2,3);
            Console.WriteLine("kq= " +kq);

            //xuất giai thừa
            int k = 3;
            int kq2 = TinhGiaiThua(k);
            Console.WriteLine("kq2= "+kq2);

            Xinchao("nam");
            Xinchao("nu");
            int kq3 = Tong(7,8,9);

            //truyền tham trị 
            int a = 1;
            Console.WriteLine("a trước gọi hàm là: "+a);
            Thamtri(a);
            Console.WriteLine("a sau gọi hàm là: " + a);
            //truyền tham chiếu (truyền tham biến ) ref 
            //ref phải khởi tạo giá trị cho biến trước khi gọi hàm 
            //int b; // sẽ báo lỗi 
            int b=2;
            Console.WriteLine("b trước khi gọi hàm= "+b);
            ThamchieuRef(ref b);
            Console.WriteLine("b sau khi gọi hàm= " + b);

            //truyền tham chiếu (truyền tham biến ) out 
            //out  phải gán giá trị cho biến trước khi thoát khỏi hàm
            int c;
            ThamchieuOut(out c);
            Console.WriteLine("c sau khi gọi hàm là: " +c );

            Console.ReadKey();
        }

    }
}
