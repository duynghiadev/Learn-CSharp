using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_4_giaibaitapc20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Viết chương trình kiểm tra tính hợp lệ của mật khẩu: aaaaaAAAAAA1
              *  mật khẩu hợp lệ khi có ít nhất 6 ký tự chứa ít nhất 1 chữ cái ( chữ cái thường hoặc hoa đều được) 
              *chứa ít nhất 1 chữ số  => không hợp lệ bắt nhập lại 
             2. cho người dùng nhập vào mật khẩu để login / so sánh, nếu đúng mở của, sai quá 5 lần khóa đăng nhập, thoát chương trình
            */
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("mời nhập vào mk( ít nhất 6 ký tự, ít nhất 1 chữ cái, ít nhất 1 chữ số): ");
            string mk=Console.ReadLine(); //123456a
            bool check = true;
            int demSo=0, demKytu =0;
            while(check)  //while(check==tre) 
            {
                foreach (char c in mk)
                {
                    if (char.IsDigit(c))
                        demSo++;
                    else if (char.IsLetter(c))
                        demKytu++;
                }
                Console.WriteLine(demSo);
                Console.WriteLine(demKytu);
                if (demKytu*demSo !=0 && mk.Length >=6)
                    check = false;
                else
                {
                    Console.WriteLine("Nhập lại mk,(ít nhất 6 ký tự, ít nhất 1 chữ cái, ít nhất 1 chữ số) :");
                    mk=Console.ReadLine();
                    check=true;
                } 
                
            }
            Console.WriteLine("Bạn đã thiết lập mật khẩu thành công, mk của bạn là: " +mk);
            //2. cho người dùng nhập vào mật khẩu để login
            // so sánh, nếu đúng mở của, sai quá 5 lần khóa đăng nhập, thoát chương trình
            string login;
            Console.WriteLine("mời nhập vào mật khẩu đăng nhập: ");
            login = Console.ReadLine();
            int demLogin = 0;
            while (true)
            {
                bool kq = mk.Equals(login);
                if (kq)
                {
                    Console.WriteLine("Đăng nhập thành công");
                    break;
                } 
                else
                {
                    demLogin++;
                    if (demLogin<5)
                    {
                        Console.WriteLine("Nhập lại mật khẩu, nhập sai {0}/5 lần ", demLogin);
                        login = Console.ReadLine();
                    } 
                    else
                    {
                        Console.WriteLine("bạn đã nhập mk sai 5 lần, khóa đăng nhập ");
                        break ;
                    }    
                }    
            }    

            Console.ReadKey();
            



        }
    }
}
