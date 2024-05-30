using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai21_xulyngoaile
{
    internal class Program
    {   
        static void Ngoaile1()
        {   
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("mời nhập vào ngày tháng năm sinh: ");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("ngày sinh của bạn là: " + birthday.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cảm ơn bạn đã sử dụng phần mềm ");
            }
        }

        static void Ngoaile2()
        {
            Console.WriteLine("mời nhập vào tử số: ");
            int tu =int.Parse(Console.ReadLine());
            Console.WriteLine("mời nhập vào mẫu số: ");
            int mau = int.Parse(Console.ReadLine());
            if (mau == 0)
                throw new ArithmeticException("Lỗi mẫu bằng 0 rồi thím ơi ");
        }
        static void Main(string[] args)
        {   
            Console.OutputEncoding=Encoding.UTF8;
            //Ngoaile1();
            try
            {
                Ngoaile2();
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
