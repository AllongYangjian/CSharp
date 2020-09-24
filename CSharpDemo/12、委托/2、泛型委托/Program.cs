using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_泛型委托
{
    public delegate int DelDelegate<T>(T o1, T o2);
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 34 };
            int ret = GetMax<int>(arr, (int a1, int a2) =>
            {
                return a1 - a2;
            });

        }

        public static T GetMax<T>(T[] nums, DelDelegate<T> del)
        {
            T max = nums[0];
            for (int x = 0; x < nums.Length; x++)
            {
                if (del(max, nums[x]) < 0)
                {
                    max = nums[x];
                }
            }
            return max;

        }

    }
}
