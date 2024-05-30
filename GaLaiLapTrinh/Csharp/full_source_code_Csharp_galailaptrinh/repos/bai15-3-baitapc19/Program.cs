using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_3_baitapc19
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] lst = str1.Split(' ');
            string strSo = "";
            foreach (string x in lst)
            {
                //Console.WriteLine(x);
                foreach(char c in x)
                {
                    //Console.WriteLine(c);
                    if (char.IsDigit(c))
                    {
                        strSo += x + " ";
                        break;

                    }
                }
            }
            Console.WriteLine(strSo);
            strSo = strSo.Trim();
            // tach strSo theo space 
            string[] lst2 =strSo.Split(' ');
            int tong = 0;
            foreach (string y in lst2)
            {
                Console.WriteLine(y);
                tong+=int.Parse(y);

             }
            Console.WriteLine("Tổng các số cần tìm là: "+ tong);
            float tbc = (float)tong / (lst2.Length);
            Console.WriteLine(lst2.Length);
            Console.WriteLine("trung bình cộng là: " +tbc);
            Console.ReadKey();

        }
    }
}
