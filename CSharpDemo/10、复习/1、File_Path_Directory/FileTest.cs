using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_File_Path_Directory
{
    class FileTest
    {


        public static void TestFileReadMethod(string path)
        {
            string[] txts = File.ReadAllLines(path);
            for (int x = 0; x < txts.Length; x++)
            {
                string[] item = txts[x].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                int salary = Convert.ToInt32(item[1]) * 2;

                txts[x] = item[0] + "|" + salary.ToString();
            }

            File.WriteAllLines(path,txts);
            Console.ReadKey();
        }


    }
}
