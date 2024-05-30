using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13_datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            DateTime birthday = new DateTime(1987, 11, 21);
            Console.WriteLine("ngày tháng năm sinh của bạn là : " +birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("ngày  sinh của bạn là : " +birthday.ToString("dd"));
            Console.WriteLine("tháng  sinh của bạn là : " +birthday.ToString("MM"));
            Console.WriteLine("năm  sinh của bạn là : " +birthday.ToString("yyyy"));

            DateTime birthday2 = DateTime.Parse("11/24/1992");
            Console.WriteLine("ngày tháng năm sinh 2 của bạn là : " + birthday2.ToString("dd/MM/yyyy"));

            // viết chương trình cho người dùng nhập vào ngày tháng năm sinh 
            Console.WriteLine("Mời bạn nhập vào ngày tháng năm sinh ( tháng/ngày/năm): ");
            string s = Console.ReadLine();
            DateTime birthday3 = DateTime.Parse(s);
            Console.WriteLine("ngày sinh của bạn vừa nhập là: " + birthday3.ToString("dd"));
            Console.WriteLine("tháng sinh của bạn vừa nhập là: " + birthday3.ToString("MM"));
            Console.WriteLine("năm sinh của bạn vừa nhập là: " + birthday3.ToString("yyyy"));



            Console.ReadLine();
        }
    }
}
