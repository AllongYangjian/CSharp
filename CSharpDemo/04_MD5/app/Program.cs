using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = MD5Utils.md5("yangjian");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
