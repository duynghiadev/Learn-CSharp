using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "haha", "hello", "school" }; //khoi tao 1 list 
            foreach (string i in lst)
            {
                Console.WriteLine("i=" +i);
            }
            Console.ReadLine();

        }
    }
}
