using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_6_btc22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Csharp 22 :
                  Cho chuỗi : 
	            a= “
	            tôi chăm học
	            tôi chịu khó
	            tôi đẹp zai
	            “
	            đếm từ tôi trong string a trên
             */
            Console.OutputEncoding = Encoding.UTF8;
            string a = @"tôi chăm học
                        tôi chịu khó
                        tôi đẹp zai";
            string[] lst = a.Split(' ');
            int dem = 0;
            foreach (string s in lst)
            {
                //Console.WriteLine(s);
                if ("tôi".Equals(s))
                    dem++;
            }
            Console.WriteLine("Có {0} từ tôi ở trong string a ",dem);
            Console.ReadKey();
        }
    }
}
