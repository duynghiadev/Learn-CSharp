using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19_1_giaibaitapc29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình sử dụng dict chứa 5 user name và password. 
            //0. Chương trình yêu cầu nhập vào username và pass, 
            //1. nếu user name o có trong dict, chương trình báo user name o tồn tại
            //2. nếu user name đúng mà password sai thì báo: PASSWORD SAI
            //3. nếu user, pass đúng thì báo bạn đã login thành công
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("user1", "123456");
            dic.Add("user2", "123456");
            dic.Add("user3", "123456");
            dic.Add("user4", "123456");
            dic.Add("user5", "123456");
            //duyet dic 
            foreach (KeyValuePair<string, string> pair in dic)
            {
                Console.WriteLine(pair);
            }

            //0.Chương trình yêu cầu nhập vào username và pass,
            Console.WriteLine("mời nhập vào username: ");
            string user= Console.ReadLine();
            Console.WriteLine("mời nhập vào mật khẩu: ");
            string mk= Console.ReadLine();

            //check user có tồn tại 
            if (dic.ContainsKey(user)== false)
                Console.WriteLine("user không tồn tại ");
            else
            {   
                if (dic[user] ==mk)
                    Console.WriteLine("đăng nhập thành công ");
                else
                    Console.WriteLine("SAi mật khẩu");
            }    
            Console.ReadKey();
        }
    }
}
