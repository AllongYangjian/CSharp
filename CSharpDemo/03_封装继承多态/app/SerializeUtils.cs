using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    /// <summary>
    /// 序列化和反序列化
    /// 序列化：将对象装换成二进制
    /// 反序列化：将二进制转换成对象
    /// 作用：传输数据
    /// </summary>
    class SerializeUtils
    {
        public static void SerialBean(string path)
        {
            SerializeBean bean = new SerializeBean();
            bean.Age = 18;
            bean.Name = "yj";
            bean.Gender = '男';
            using(FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, bean);
            }
            Console.ReadKey();
        }

        public static void UnSerializeBean(string path)
        {
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                SerializeBean bean = (SerializeBean)bf.Deserialize(fsRead);
                Console.WriteLine("{0},{1},{2}", bean.Name, bean.Age, bean.Gender);
                Console.ReadKey();
            }
        }
    }
}
