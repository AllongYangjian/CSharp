using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_委托复习
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate my = new MyDelegate(() => { Console.WriteLine("sb"); });
            my();
            //Test(MyPrint);
            Test(() => { Console.WriteLine("ff"); });
            ChangeString();
            Console.ReadKey();
        }

        public static void MyPrint()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }

        public delegate void PrintDelegate();

        public static void Test(Action myPrint)
        {
            Console.WriteLine("************************");
            Console.WriteLine("************************");
            myPrint();
            Console.WriteLine("************************");
            Console.WriteLine("************************");
        }


        public static void ChangeString()
        {
            string[] str = new string[] { "abc", "dfadf", "adfadfafadf", "dfad" };
            for(int x = 0;x<str.Length;x++)
            {
                str[x] = ChangeString(str[x], UpperCase);
                Console.WriteLine(str[x]);
            }
        }

        public static string UpperCase(string name)
        {
            return name.ToUpper();
        }

        public static string ChangeString(string name,MyDelegate2 delegate2)
        {
            return delegate2(name);
        }
    }


    public delegate string MyDelegate2(string name);




    public delegate void MyDelegate();

  


}
