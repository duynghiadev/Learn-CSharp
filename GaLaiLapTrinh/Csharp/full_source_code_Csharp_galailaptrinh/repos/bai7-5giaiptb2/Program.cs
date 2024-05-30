using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_5giaiptb2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8;
            float a, b, c, delta;
            Console.WriteLine("mời nhập vào giá trị của a: ");
            a=float.Parse(Console.ReadLine());
            Console.WriteLine("mời nhập vào giá trị của b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("mời nhập vào giá trị của c: ");
            c = float.Parse(Console.ReadLine());
            //tính toán
            delta = (b * b) - (4 * a * c);
            if (delta < 0)
                Console.WriteLine("Phương trình vô nghiệm");
            else if(delta==0)
            {
                float x = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép là {0}", x);

            }  
            else
            {
                double x1=(-b+Math.Sqrt(delta))/(2*a);
                double x2=(-b-Math.Sqrt(delta))/(2*a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt");
                Console.WriteLine("x1={0}", x1);
                Console.WriteLine("x2={0}", x2);
            }    
            
            
            Console.ReadKey();


        }
    }
}
