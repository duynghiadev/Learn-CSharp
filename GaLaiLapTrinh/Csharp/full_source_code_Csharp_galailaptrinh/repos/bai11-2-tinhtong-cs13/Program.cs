using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_2_tinhtong_cs13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Viết chương trình nhập nhập số a từ bàn phím, 
            Nếu a chẵn thì tính tổng các số chẵn từ 0 đến a 
            Nếu a lẻ thì in ra dòng chữ “tôi o tính tổng số lẻ, bye bye ” và thoát chương trình 
            */
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            int tong = 0;
            Console.WriteLine("mời nhập vào số nguyên a: ");
            a= int.Parse(Console.ReadLine());
            if (a % 2 != 0)
                Console.WriteLine("tôi o tính tổng số lẻ, bye bye");
            else
            {
                for (int i = 0; i<=a; i+=2)
                {
                    tong += i; //tong = tong +i
                }
                Console.WriteLine("Tổng các số chẵn từ 0 đến {0} là {1}", a, tong);
            }
            Console.ReadLine();

                



        }
    }
}
