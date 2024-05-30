using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace bai18_3file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. StreamWriter : Ghi file văn bản  
            FileStream fs = new FileStream("data1.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter swrite = new StreamWriter(fs);
            swrite.Write("Heloo obama");
            swrite.Flush();
            fs.Close();

            //2 StreamReader : Đọc file văn bản
            fs = new FileStream("data1.txt",FileMode.Open, FileAccess.Read);
            StreamReader sread = new StreamReader(fs);
            string str = sread.ReadToEnd();
            Console.WriteLine(str);
            fs.Close();


            //3. BinaryWriter / BinaryReader 
            FileStream fs2 = new FileStream("data2.txt", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs2);
            bw.Write(123);
            fs2.Close();

            fs2 = new FileStream("data2.txt",FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs2);
            var i = br.ReadInt32();
            Console.WriteLine(i);


            //4. Using
            using (FileStream fs4 = new FileStream("data3.txt",FileMode.Create, FileAccess.ReadWrite))
            {
                BinaryWriter br4 = new BinaryWriter(fs4);
                br4.Write(6666);
                StreamWriter sw4 = new StreamWriter(fs4);
                sw4.Write("ghi cai gi tuy y ");
                sw4.Flush();
            }

            using (var fs4= new FileStream("data3.txt",FileMode.Open,FileAccess.Read))
            {
                BinaryReader br4 = new BinaryReader(fs4);
                var xx = br4.ReadInt32();
                StreamReader rd4 = new StreamReader(fs4);
                var str4 = rd4.ReadToEnd();
                Console.WriteLine(xx);
                Console.WriteLine(str4);
            }

            //7.File.WriteAllText
            string duongdan = "filemoi.txt";
            string noidung = @"chào các bạn đến với http://tuhoc.cc
                kênh tự học của những ng chăm học
                Hội chăm  học nhất VN";
            File.WriteAllText(duongdan, noidung);

            //8.File.WriteAllLines
            string[] noidung2 = { "dong 1", "day la pt2 ", "day la anh 3" };
            File.WriteAllLines(duongdan, noidung2);

            //9 . File.AppendAllLines 
            string[] nodiung3 = { "haha3", "hah4", "tuhoc.cc" };
            File.AppendAllLines(duongdan, nodiung3);


            //10.File.ReadAllText:
            //Sẽ đọc tất cả các dòng trong file và trả về 1 string.
            Console.WriteLine("--------------");
            string noidungdoc = File.ReadAllText("filemoi.txt");
            Console.WriteLine(noidungdoc);


            //11.File.ReadAllLines
            string[] arrND = File.ReadAllLines(duongdan);
            foreach (string dong in arrND)
            {
                Console.WriteLine(dong);
            }

            Console.WriteLine("-------------");
            Console.WriteLine(arrND[0]);
            Console.WriteLine(arrND[1]);


            //12.File.Move
            string path1 = "filemoi.txt";
            string path2 = @"thumucmoi\doitenroi.txt";
            //File.Move(path1,path2);

            //13.File.Copy()
            string path3 = @"thumucmoi\doitenroi.txt";
            string path4 = @"thumucmoi\doitenroi_copy.txt";
            //File.Copy(path3, path4);


            //14.File.Delete()
            File.Delete(path4);

            Console.ReadLine();
        }
    }
}
