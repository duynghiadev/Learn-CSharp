﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("moi nhap vao so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("ban vua nhap vao so {0}", n);
            if (n % 2 != 0)
                Console.WriteLine("so {0} la so le", n);
            else
                Console.WriteLine("so {0} la so chan", n);

            Console.ReadKey();
        }
    }
}
