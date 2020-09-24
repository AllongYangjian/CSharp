using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _2_序列化
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        public static void Serialize(string path)
        {
            Person person = new Person();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, person);
            }
        }

        public static void DeSerialize(String path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(fs);
                Person person = obj as Person;
            }
        }

        class Person
        {

        }
    }
}
