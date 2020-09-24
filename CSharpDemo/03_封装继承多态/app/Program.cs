using app.Bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
using System.IO;
using System.Collections;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestStringSplitMethod();
            //TestString();
            //TestStringJoin();
            //TestLisiConvert();
            //TestArrayList();
            //TestHashTable();
            #region File类的使用
            //TestPathClass();
            //TestFileClass();
            //FileUtils.ReadFile(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\Program.cs");
            //FileUtils.WriteFile(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\test1.txt",new string[] { "sb","bs"});
            //FileUtils.AppendText(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\test1.txt", new string[] { "sb", "bs" });
            //FileUtils.WriteFile(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\test2.txt", "hh");
            //FileUtils.AppendText(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\test2.txt", "呵呵");
            #endregion

            #region 集合类的使用
            //ListUtils.ListMethod();
            //DictionaryUtils.DictionaryMethodTest();
            //DictionaryUtils.DictionaryTestDemo1();
            #endregion

            #region FileStream类的使用
            //FileStreamUtils.TestFileStreamReadMethod();
            //FileStreamUtils.TestFileStreamWriteMethod();
            #endregion

            #region 测试文件的读写
            //string source = @"E:\BaiduNetdiskDownload\亲情奉献-全套精品.Net基础班视频教程-video\亲情奉献全套精品.Net基础视频教程之10-面向对象多态\（第十二天）\video\7、使用FileStream来读写文件.avi";
            //string target = @"E:\BaiduNetdiskDownload\亲情奉献-全套精品.Net基础班视频教程-video\亲情奉献全套精品.Net基础视频教程之10-面向对象多态\（第十二天）\video\test.avi";
            //FileStreamUtils.ReadAndWriteFile(source, target);
            #endregion

            #region StreamRead StringWriter
            //StreamReadWriteUtils.TestRead();
            //StreamReadWriteUtils.TestWrite();
            #endregion

            #region 多态的练习
            //Polymorphic pm1 = new Chinese("中国人");
            //Polymorphic pm2 = new Polymorphic("日本人");

            //pm1.SayHello();
            //pm2.SayHello();
            //Console.ReadKey();

            //抽象类
            //AbstractClass ac = new Dog();
            //ac.Bark();


            //AbstractClass ac2 = new Cat();
            //ac2.Bark();

            //Console.ReadKey();
            #endregion

            #region 序列化

            //SerializeUtils.SerialBean(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\2.txt");
            //SerializeUtils.UnSerializeBean(@"E:\VSProject\CSharpDemo\03_封装继承多态\app\2.txt");

            #endregion
        }


        /// <summary>
        /// File类
        /// 用来操作文件
        /// </summary>
        static void TestFileClass()
        {
            string content = "hh";
            string path = @"C:\Users\YJ\Desktop\1.txt";

            //File.WriteAllBytes(path, Encoding.Default.GetBytes(content));

            byte[] bt = File.ReadAllBytes(path);

            string str = Encoding.Default.GetString(bt);
            Console.WriteLine(str);
            Console.ReadKey();
        }

        /// <summary>
        /// 测试Path类
        /// 用来操作路径
        /// </summary>
        static void TestPathClass()
        {
            string fileStr = @"E:\BaiduNetdiskDownload\亲情奉献-全套精品.Net基础班视频教程-video\亲情奉献全套精品.Net基础视频教程之9-面向对象继承\（第十一天）\video\yj.avi";
            string fileName = Path.GetFileName(fileStr);
            Console.WriteLine(fileName);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileStr);
            Console.WriteLine(fileNameWithoutExtension);
            Console.ReadKey();
        }

        static void TestHashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("a", "1");
            hashtable.Add("b", 2);
            hashtable["c"] = "sg";

            Console.WriteLine(hashtable.Count);
            Console.WriteLine(hashtable["a"]);
            hashtable["a"] = "dfa";
            //遍历集合
            foreach (var item in hashtable.Keys)
            {
                //Console.WriteLine(item.ToString());
                Console.WriteLine(hashtable[item]);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// ArrayList集合
        /// </summary>
        static void TestArrayList()
        {
            ArrayList list = new ArrayList();
            //list.Add(1);
            list.Add("str");
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();
            //List<User> users = new List<User>();
            //User user = new User("yj", 18, "123");
            //users.Add(user);
        }

        /// <summary>
        /// 里氏转换
        /// 1、子类可以强转成父类
        /// 2、可用父类变量接收子类变量的赋值
        /// </summary>
        static void TestLisiConvert()
        {
            User user = new Student("yj", 18, "123");
            if (user is Student)
            {
                Student stu = (Student)user;
                stu.Test();
            }
            Student stu2 = user as Student;
            stu2.Test();
            Console.ReadKey();
        }

        /// <summary>
        /// 测试 String Join方法
        /// </summary>
        static void TestStringJoin()
        {
            string[] str = { "abc", "dbc", "edc" };
            string ret = string.Join("|", str);
            string[] result = ret.Split(new char[] { '|' });
            Console.WriteLine(ret);
            Console.ReadKey();
        }

        static void TestString()
        {
            string path = @"E:\VSProject\CSharpDemo\03_封装继承多态\app\Test.txt";

            string[] str = File.ReadAllLines(path, Encoding.UTF8);

            for (int x = 0; x < str.Length; x++)
            {
                string[] items = str[x].Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string ret = "";
                if (items[0].Length > 8)
                {
                    ret = items[0].Substring(0, 8) + "...";
                }
                else
                {
                    ret = items[0];
                }
                ret += "|" + items[1];
                Console.WriteLine(ret);
            }
            Console.ReadKey();

        }

        static void TestBasic()
        {
            User user = new User("yaj", 18, "sb");

            List<int> list = new List<int>();

            string str = "123";

            Console.ReadKey();
        }

        static void TestStringSplitMethod()
        {
            string str = " afdadf -adfa mdff m,af;adfa/fda;jfa";
            //str.Split(new char[] { '-'});
            char[] chs = { ' ', '-', ',', '/', ';' };
            string[] result = str.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();

            for (int x = 0; x < result.Length; x++)
            {
                sb.Append(result[x]);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();

        }

        /// <summary>
        /// 测试引用其他项目的类
        /// </summary>
        static void TestOtherProjectClass()
        {
            Animal animal = new Animal();
        }
    }
}
