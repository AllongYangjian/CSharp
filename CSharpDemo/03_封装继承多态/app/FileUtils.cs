using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class FileUtils
    {

        public static void ReadFile(string path)
        {
            string[] contents = File.ReadAllLines(path, Encoding.Default);
            foreach(string item in contents)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static void WriteFile(string path,string[] content)
        {
            File.WriteAllLines(path, content);
            Console.ReadKey();
        }

        public static void WriteFile(string path,string content)
        {
            File.WriteAllText(path, content);
            Console.ReadKey();
        }

        public static void AppendText(string path,string[] content)
        {
            File.AppendAllLines(path, content);
            Console.ReadKey();
        }

        public static void AppendText(string path,string content)
        {
            File.AppendAllText(path, content);
            Console.ReadKey();
        }

    }
}
