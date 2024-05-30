using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_7_btc_23
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập vào 1 chuỗi ");
            string s= Console.ReadLine();
            string chuoi = "";
            string so = "";
            foreach (char c in s)
            {
                //Console.WriteLine(c);
                if (char.IsDigit(c))
                    so += c;
                else if (char.IsLetter(c))
                    chuoi+=c;

            }  
            Console.WriteLine("Chuỗi chỉ gồm số là : "+ so);
            Console.WriteLine("Chuỗi chỉ gồm chữ cái là : "+chuoi);
            Console.ReadKey();
        }
    }
}
