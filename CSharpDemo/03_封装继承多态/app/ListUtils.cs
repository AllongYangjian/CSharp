using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class ListUtils
    {
    
        public static void ListMethod()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            foreach(int x in list)
            {
                Console.Write("{0}\t",x);
            }
            Console.WriteLine();

            int[] arr = list.ToArray();
            foreach(int x in arr)
            {
                Console.Write("{0}\t", x);
            }
            Console.WriteLine();

            List<int> list2 = arr.ToList<int>();
            foreach (int x in list2)
            {
                Console.Write("{0}\t", x);
            }
            Console.ReadKey();
        }
    }
}
