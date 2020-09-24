using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_File_Path_Directory
{
    class FileStreamTest
    {
        
        public static void TestFileStreamMethod(string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {

                int length = 0;
                byte[] buffer = new byte[1024];
                List<byte> list = new List<byte>();
                while ((length = fs.Read(buffer,0,buffer.Length))!=0)
                {
                   
                    list.AddRange(buffer.ToList());
                }
            }
        }
    }
}
