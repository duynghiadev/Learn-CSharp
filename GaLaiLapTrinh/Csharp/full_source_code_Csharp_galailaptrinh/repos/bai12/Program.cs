using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pi= " +Math.PI);
            Console.WriteLine("kieu du lieu cua math.pi = " +Math.PI.GetType().ToString());
            float pi= (float) Math.PI;
            Console.WriteLine("pi sau khi ep kieu float= " +pi);

            //can bac 2 
            int a = 4;
            int b = 10;
            Console.WriteLine("can bac 2 cua so a la : " +Math.Sqrt(a));
            Console.WriteLine("kieu du lieu cua sqrt = " + Math.Sqrt(a).GetType().ToString());

            //luy thua
            Console.WriteLine("2 luy thua 3 = " + Math.Pow(2,3));
            //max
            Console.WriteLine("min = " + Math.Min(a,b));

            //lam tron
            float c = 1.23456789f;
            Console.WriteLine("so c sau khi lam tron 2 chu so la: " +Math.Round(c,2));

            //sin 
            //Nhân số độ với π/180.
            //Vì thế, 1 độ bằng(π/ 180) radian.
            //Từ đó, những gì bạn cần làm là nhân số độ mà bạn muốn đổi với π/ 180 để chuyển đổi độ sang radian.
            Console.WriteLine("sin 180=" +Math.Sin(30*Math.PI/180));

 
            Console.ReadLine();
        }
    }
}
