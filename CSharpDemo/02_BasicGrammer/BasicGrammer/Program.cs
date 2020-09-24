using BasicGrammer.Bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGrammar
{
    class Program
    {
        static void Main(string[] args)
        {

            //TestEnumType();
            //StringToEnum();
            //TestStruct();
            //PrintArray(GetIntArray());
            //TestArray1();
            //TestArray2();
            //ReverseArray();
            //BubbleSort();
            //TestOutParam();
            //TestRefVariale();
            //TestParams("yj", 1, 2, 3, 34, 5, 67);
            TestRecursion();
        }
        /// <summary>
        /// 测试阶乘算法
        /// </summary>
        static void TestRecursion()
        {
            int ret = Recursion(5);
            Console.WriteLine(ret);
            Console.ReadKey();
        }
        /// <summary>
        /// 阶乘方法，递归调用
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int Recursion(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            else
            {
                return num * Recursion(--num);
            }
        }
        /// <summary>
        /// 测试可变参数的方法
        /// 可变参数表示方法：params type[] variable
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="score">可变参数数组</param>
        static void TestParams(string name,params int[] score)
        {
            int sum = 0;
            for(int x = 0;x<score.Length;x++)
            {
                sum += score[x];
            }
            Console.WriteLine("{0}·s Total Score = {1}", name,sum);
            Console.ReadKey();
        }

        static void TestRefVariale()
        {
            int n1 = 10;
            int n2 = 20;
            Console.WriteLine("a = {0}\tb = {1}", n1, n2);
            TestRef(ref n1, ref n2);
            Console.WriteLine("a = {0}\tb = {1}", n1, n2);
            Console.ReadKey();
        }

        static void TestRef(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        /// <summary>
        /// 使用out作为出参
        /// out参数侧重与在一个方法中可以返回多个不同类型的值
        /// </summary>
        static void TestOutParam()
        {
            //bool ret = int.TryParse("abc", out num);
            bool ret = MyTryParse("123", out int num);
            Console.WriteLine(ret + "," + num);
            Console.ReadKey();
        }

        static bool MyTryParse(string param,out int result)
        {
            try
            {
                result = Convert.ToInt32(param);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }

        static void BubbleSort()
        {
            int[] arr = GetRandomIntArray(10, 100);
            Console.WriteLine("原数组为：");
            PrintArray(arr);
            for (int x = 0;x<arr.Length -1;x++)
            {
                for(int j = 0; j < arr.Length - 1 - x; j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("现数组为：");
            PrintArray(arr);
            Console.ReadKey();
        }

        static void ReverseArray()
        {
            int[] arr = GetRandomIntArray(10, 10);
            Console.WriteLine("原数组：");
            PrintArray(arr);
            int index = arr.Length / 2;
            for(int x = 0;x<index;x++)
            {
                int temp = arr[x];
                arr[x] = arr[arr.Length - 1 - x];
                arr[arr.Length - 1 - x] = temp;
            }         
            Console.WriteLine("转换后数组");
            PrintArray(arr);
            Console.ReadKey();
        }

        /// <summary>
        /// 将随机数组的元素用|拼接成字符串
        /// </summary>
        static void TestArray2()
        {
            int[] arr = GetRandomIntArray(10, 100);
            string str = "";
            for(int x = 0;x<arr.Length;x++)
            {
                str += arr[x];
                if(x!=arr.Length-1)
                {
                    str += "|";
                }
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
        /// <summary>
        /// 获取长度指定的随机数组
        /// </summary>
        /// <param name="len">长度</param>
        /// <param name="bound">最大值</param>
        /// <returns>int[]</returns>
        static int[] GetRandomIntArray(int len,int bound)
        {
            int[] arr = new int[len];
            Random random = new Random();
            for (int x = 0;x<len;x++)
            {
                arr[x] = random.Next(bound);
            }
            return arr;
        }

        /// <summary>
        /// 测试随机数组的打印
        /// </summary>
        static void TestArray1()
        {
            int[] arr = new int[10];
            Random random = new Random();
            for(int x = 0;x<arr.Length;x++)
            {
                arr[x] = random.Next(100);
            }
            PrintArray(arr);
        }
        /// <summary>
        /// 打印int数组，用制表符隔开
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(int[] arr)
        {
         
            for(int x = 0;x<arr.Length;x++)
            {
                Console.Write(arr[x]);
                Console.Write("\t");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 从控制台获取一个长度为10的int数组
        /// </summary>
        /// <returns>int[]</returns>
        static int[] GetIntArray()
        {
            int[] arr = new int[10];

            for(int x = 0; x < 10; x++)
            {
                string str = Console.ReadLine();
                arr[x] = Convert.ToInt32(str);
            }
            return arr;
        }

        /// <summary>
        /// 结构测试
        /// </summary>
        static void TestStruct()
        {
            Person mPerson = new Person
            {
                _age = 19,
                _name = "yangjian",
                _gender = Gender.Male
            };
            Console.WriteLine(mPerson.ToString());
            Console.ReadKey();
        }

        /// <summary>
        /// 测试枚举类型
        /// </summary>
        static void TestEnumType()
        {
            Gender gender = Gender.Male;
            Console.WriteLine(gender);
            Console.WriteLine(gender.ToString());
            Console.ReadKey();
        }

        /// <summary>
        /// string ==> Enum
        /// 1、转换的是数字：如过枚举中不存在，则输出数字
        /// 2、转换的是非数字，报异常
        /// </summary>
        static void StringToEnum()
        {
            string s = "3";
            Gender gender = (Gender)Enum.Parse(typeof(Gender), s);
            Console.WriteLine(gender);
            Console.ReadKey();
        }
    }
}
