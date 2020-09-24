using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestOccupation();
            //TestScreenInput();
            //TestCharacter();
            //TestConvertFunction();
            TestTryCatch();
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }

        static void TestTryCatch()
        {
            Console.WriteLine("输入 exit 结束程序");
            string str = null;
            while(!(str = Console.ReadLine()).Equals("exit"))
            {
                try
                {
                    int num = Convert.ToInt32(str);
                    Console.WriteLine("你输入的数字为:" + num);
                }
                catch
                {
                    Console.WriteLine("不是数字");
                    break;
                }
                
            }
            Console.WriteLine("程序结束");

        }

        /// <summary>
        /// Convert函数族
        /// </summary>
        static void TestConvertFunction()
        {
            string str = "123";
            double d = Convert.ToDouble(str);
            int i = Convert.ToInt16(str);
            Console.WriteLine("d = {0:0.00},i = {1}", d, i);
        }

        /// <summary>
        /// @符号字段作用
        /// 1、去除\在字符串中的转义作用
        /// 2、保留原格式输出
        /// </summary>
        static void TestCharacter()
        {
            string str = @"E:\sb";
            Console.WriteLine(str);
            string str2 = @"ads
                fafd ";
            Console.WriteLine(str2);
        }

        static void TestScreenInput()
        {
            Console.WriteLine("请输入你的名字");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }


        /// <summary>
        /// 测试占位符
        /// </summary>
        static void TestOccupation()
        {
            string name = "yangjian";
            int age = 18;
            char gender = '男';
            Console.WriteLine("{0} age is {1},sex is {2}", name, age, gender);
            Console.WriteLine("age is {0},sex is {1},he name is {2}", age, gender, name);
        }
    }
}
