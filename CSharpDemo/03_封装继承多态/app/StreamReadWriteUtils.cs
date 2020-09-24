using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class StreamReadWriteUtils
    {
        public static void TestRead()
        {
            using (StreamReader read = new StreamReader(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\Program.cs", Encoding.UTF8))
            {
                while (!read.EndOfStream)
                {
                    Console.WriteLine(read.ReadLine());
                }
            }
            Console.ReadKey();
        }

        public static void TestWrite()
        {
            using(StreamWriter writer = new StreamWriter(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\Test.txt", true,Encoding.UTF8))
            {
                writer.Write("这是一个sb");
            }
            Console.ReadKey();
        }
    }
}
