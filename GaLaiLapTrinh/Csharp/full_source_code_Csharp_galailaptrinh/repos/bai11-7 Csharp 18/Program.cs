using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_7_Csharp_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Viết chương trình nhập nhập số a từ bàn phím nhập vào 1 số từ bàn phím
             Cho biết đó có phải số ng tố  
                ( số ng tố là số >0, và chỉ chia hết cho 1 và chính nó ) 
            Kết thúc chương trình hỏi người dùng: Bạn có muốn tiếp tục sử dụng phần mềm không? Nếu chọn không thì thoát ctrinh 
            1 số số nguyên tố để test code : 2 3 5 7 11 13 17 19 23 29 
             */
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("mời nhập vào số nguyên a>0: ");
            a=int.Parse(Console.ReadLine());
            // check điều kiện để đảm bảo a> 0
            while (a<=0)
            {
                Console.WriteLine("nhập lại a, a phải lớn hơn 0: ");
                a = int.Parse(Console.ReadLine());
            }
            //kiểm tra số nguyên tố
            int demUoc = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a%i==0)
                {
                    demUoc++;
                    Console.WriteLine(demUoc);
                }    


            }    
            if (demUoc==2)
                Console.WriteLine("{0} là số nguyên tố" , a);
            else
                Console.WriteLine("{0} không phải là số nguyên tố", a);
            Console.ReadKey();


        }
    }
}
