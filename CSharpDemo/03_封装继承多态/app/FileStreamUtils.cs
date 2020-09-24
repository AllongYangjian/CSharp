using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    /// <summary>
    /// 文件流工具类
    /// </summary>
    class FileStreamUtils
    {
        //FileStream 操作字节的
        public static void TestFileStreamReadMethod()
        {
            FileStream fStream = new FileStream(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\test3.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];
            //当文件读取不到时返回0
            int r = fStream.Read(buffer, 0, buffer.Length);

            string srt = Encoding.UTF8.GetString(buffer, 0, r);
            fStream.Close();
            fStream.Dispose();
            Console.WriteLine(srt);
            Console.ReadKey();
        }


        public static void TestFileStreamWriteMethod()
        {
            using (FileStream fis = new FileStream(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\test3.txt",
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "StreamReader StringWriter 操作字符的";
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                fis.Write(buffer, 0, buffer.Length);
            }
        }

        public static void ReadAndWriteFile(string source, string target)
        {
            FileStream read = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream writer = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buffer = new byte[1024];
            int n;
            while ((n = read.Read(buffer, 0, buffer.Length)) != 0)
            {
                writer.Write(buffer, 0, n);
            }

            writer.Close();
            writer.Dispose();

            read.Close();
            read.Dispose();
            Console.WriteLine("写入成功");
            Console.ReadKey();
        }
        //StreamReader StringWriter 操作字符的
    }
}
