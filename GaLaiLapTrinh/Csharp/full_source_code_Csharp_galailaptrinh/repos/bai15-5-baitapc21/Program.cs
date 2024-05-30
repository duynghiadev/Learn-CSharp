using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_5_baitapc21
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop";
            Console.WriteLine("mời nhập vào chuỗi cần mã hóa");
            string chuoiInput = Console.ReadLine(); //abc
            string chuoiOutput = "";
            foreach (char c in chuoiInput)
            {
                int indexkytu = a.IndexOf(c);
                chuoiOutput += b[indexkytu];

            }
            Console.WriteLine("Chuỗi trước mã hóa là: "+chuoiInput);
            Console.WriteLine("Chuỗi sau mã hóa là: "+chuoiOutput);

 
            Console.ReadKey();

        }
    }
}
