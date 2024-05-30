using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18_3_giaibtapc26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Csharp 26 :
            //Viết chương trình trả lời kết quả các phép tính
            //quest = {"2 + 5 + 7 =","5 * 10 =","sqrt(16) =","12%2 =","5//2="}
            List<string> quest = new List<string>() { "2 + 5 + 7 =", "5 * 10 =", "sqrt(16) =", "12%2 =", "5//2=" };
            List<int> traloi = new List<int>() { 14, 50, 4, 0, 4 };
            for (int i = 0; i < quest.Count; i++)
            {
                Console.WriteLine(quest[i]);
                Console.WriteLine();
                int ans=int.Parse(Console.ReadLine());
                if (ans ==traloi[i])
                    Console.WriteLine("Corect");
                else
                    Console.WriteLine("Wrong, the answer is " +traloi[i]);
            }
            Console.ReadKey();
                
        }
    }
}
