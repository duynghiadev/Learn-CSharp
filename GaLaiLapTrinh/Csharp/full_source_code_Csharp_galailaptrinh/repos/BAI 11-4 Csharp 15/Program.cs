using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_11_4_Csharp_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài tập 11-4 Csharp 15:  
            //Viết chương trình :
            // Tìm những số chia hết cho 3 từ 10 đến 50
            for (int i=10; i<=50; i++)
            {
                if(i%3==0)
                    Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
