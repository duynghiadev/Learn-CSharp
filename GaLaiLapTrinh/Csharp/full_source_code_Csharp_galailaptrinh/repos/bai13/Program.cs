using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8; 
            Random rd = new Random(); // cú pháp để tạo ra 1 đối tượng có thể sinh ra 1 số ngẫu nhiên 
            //random số ngẫu nhiên 
            // (begin, sát end) begin không nhập, thì mặc định begin =0
            int soNgauNhien = rd.Next(1,1001); // 50-100 
            Console.WriteLine("Số ngẫu nhiên máy sinh ra là : " +soNgauNhien);

            ////muốn lấy số ngẫu nhiên trong đoạn [0,1) 0 đến sát 1
            double k2 = rd.NextDouble();
            Console.WriteLine("số ngẫu nhiên 2 là: " +k2);


            //1.254444644655
            double k3 = k2 + soNgauNhien;
            Console.WriteLine("giá trị ngẫu nhiên mong muốn là: " + k3);

            //cách 2 :
            double k4 = k2 * 10;
            Console.WriteLine("giá trị ngẫu nhiên 2 mong muốn là: " + k4);

            Console.ReadKey();

        }
    }
}
