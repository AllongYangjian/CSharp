using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class DictionaryUtils
    {
        public static void DictionaryMethodTest()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "sb");
            dict.Add(2, "bs");
            dict.Add(3, "sbb");

            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine("{0} --- {1}", kv.Key, kv.Value);
            }
            dict[1] = "sbbbb";
            Console.WriteLine();
            foreach (var key in dict.Keys)
            {
                Console.WriteLine("{0} --- {1}", key, dict[key]);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 字典案列一
        /// 统计字符串中字符的个数
        /// </summary>
        public static void DictionaryTestDemo1()
        {
            string str = "Hello World";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int x = 0;x<str.Length;x++)
            {
                if (dict.ContainsKey(str[x]))
                {
                    dict[str[x]] = dict[str[x]]+1;
                }
                else
                {
                    dict.Add(str[x], 1);
                }
            }
        
            foreach(KeyValuePair<char,int> pair in dict)
            {
                Console.WriteLine("{0} --{1}", pair.Key, pair.Value);
            }
            Console.ReadKey();
        }
    }
}
