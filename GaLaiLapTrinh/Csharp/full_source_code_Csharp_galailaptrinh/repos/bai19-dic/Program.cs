using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19_dic
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.UTF8; 
            //1. khai báo dic
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //2 khỏi tạo và gán giá trị
            Dictionary<int, string> dic2 = new Dictionary<int, string>() { { 1,"obama"}, { 2,"jackma"} };
            // key: biển số xe (kiểu string)
            // value: chứng minh thư (int)
            Dictionary<string,int> dic3 = new Dictionary<string, int>() { { "20H11234", 0915472 }, { "30H19999",123456789} };
            //4.Add: thêm phần tử vào dic
            dic.Add(1, "lò văn mới");
            dic.Add(2, "vui thị sướng");
            dic.Add(3, "dương văn tính");

            //5.duyệt dic 
            foreach(KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp);
                //Console.WriteLine(kvp.Key);
                //Console.WriteLine(kvp.Value);
                Console.WriteLine("key = {0}, Value={1}" , kvp.Key,kvp.Value);
            }

            //6. dic.ContainsKey(2) Kiểm tra xem 1 key có tồn tại trong dic hay không 
            //True : nếu có tồn tại 
            //False : nếu o tồn tại 
            bool kq=dic.ContainsKey(5);
            Console.WriteLine("kq=" +kq);

            //7.dic.ContainsValue() Kiểm tra xem 1 value có tồn tại trong dic hay không 
            //True : nếu có tồn tại 
            //False : nếu o tồn tại
            bool kq2 = dic.ContainsValue("lò văn mới2");
            Console.WriteLine("kq2="+kq2);

            //8. dic[key] lấy value từ key 
            string name = dic[2];
            Console.WriteLine(name);

            //8.1 gán giá trị 
            dic[2] = "đổi văn mới";
            Console.WriteLine(dic[2]);

            //9. Xóa phần tử theo key
            dic.Remove(2);
            Console.WriteLine("dic sau xóa là: ");
            foreach (KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp);
            }
            //10. Xóa toàn bộ phần tử
            Console.WriteLine("số phần tử trước xóa của dic là: " + dic.Count());
            dic.Clear();
            Console.WriteLine("số phần tử sau xóa của dic là: "+ dic.Count());

            //11. Chuyển value dic sang list 
            Dictionary<string, int> dic4 = new Dictionary<string, int>()
            { { "20H11234", 0915472 }, { "30H19999", 123456789 } };
            List<int> ds = new List<int>();
            ds= dic4.Values.ToList();
            Console.WriteLine("danh sách value là: ");
            foreach (int i in ds)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            //12. Chuyển key dic sang list 
            List<string> dsKey = new List<string>();
            dsKey=dic4.Keys.ToList();
            Console.WriteLine("danh sách keys là: ");
            foreach (string key in dsKey)
            {
                Console.Write(key+" ");
            }    
            Console.ReadKey();
        }
    }
}
