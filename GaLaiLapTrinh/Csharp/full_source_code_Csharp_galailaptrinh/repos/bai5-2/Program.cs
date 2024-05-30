using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r, dt, cv;
            const float PI = 3.14f;
            Console.WriteLine("moi nhap vao ban kinh cua duong tron: ");
            r = float.Parse(Console.ReadLine());

            cv = 2 * PI * r;
            dt = PI * r * r;

            Console.WriteLine("dien tich hinh tron la:" +dt);
            Console.WriteLine("chu vi hinh tron la: {0}", cv);
            Console.ReadLine();
        }
    }
}
