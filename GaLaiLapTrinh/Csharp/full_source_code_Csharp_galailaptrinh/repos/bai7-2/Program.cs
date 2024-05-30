using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bài tập Csharp 05: Viết chương trình nhập vào chiều cao, cân nặng, tính BMI và xuất ra thông báo
            BMI<15: Thân hình quá gầy
            BMI>=15 and BMI<16: Thân hình gầy
            BMI>=16 and BMI<18.5: Thân hình hơi gầy
            BMI>=18.5 and BMI<25:Thân hình bình thường
            BMI>=25 and BMI < 30:Thân hình hơi béo
            BMI >=30 and BMI<35:Thân hình béo
            BMI >=35:Thân hình quá béo
            Gợi ý cách tính : BMI=canNang/(chieuCao ^2) 
            	hàm mũ 
           	    int x = 2;
            	Math.Pow(x,2); x mũ 2 

            */
            Console.OutputEncoding = Encoding.UTF8;
            float chieuCao, canNang;
            Console.WriteLine("moi nhap vao chieu cao (m): ");
            chieuCao =float.Parse(Console.ReadLine());

            Console.WriteLine("moi nhap can nang (kg): ");
            canNang = float.Parse(Console.ReadLine());

            // tính BMI
            double BMI = canNang / (Math.Pow(chieuCao, 2));
            //Console.WriteLine("BMI cua ban la: " + BMI);
            Console.WriteLine("BMI cua ban la: {0}", Math.Round(BMI,2));

            //xét đkiện
            if (BMI<15)
                Console.WriteLine("Thân hình quá gầy");
            else if (BMI >=15 && BMI<16)
                Console.WriteLine("Thân hình gầy");
            else if (BMI >= 16 && BMI < 18.5)
                Console.WriteLine("Thân hình hơi gầy");
            else if (BMI >= 18.5 && BMI < 25)
                Console.WriteLine("Thân hình bình thường");
            else if (BMI >= 25 && BMI < 30)
                Console.WriteLine("Thân hình hơi béo");
            else
                Console.WriteLine("Thân hình quá béo");





            Console.ReadKey();
        }
    }
}
