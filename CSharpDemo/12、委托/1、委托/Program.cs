using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_委托
{
    delegate void SayHi(string name);
    /// <summary>
    /// 委托测试
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            //Test("yangjian", SayChinese);
            //Test("yangjian", SayEnglist);
            ProStr("nnii");
            //string item = item->{ return item.ToString()};
            Console.ReadKey();
        }

        public static void Test(string name,SayHi say)
        {
            say(name);
        }

        public static void SayChinese(string name)
        {
            Console.WriteLine(name);
        }

        public static void SayEnglist(string name)
        {
            Console.WriteLine("hh " + name);
        }

        public static void ProStr(string name)
        {
            SayHi hi = (string str) => { Console.WriteLine(str.ToUpper()); };
            hi(name);
            Console.ReadKey();
        }
    }
}
