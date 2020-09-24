using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ProcessClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //ShowProcess();
            //OpenProcess(@"C:\Users\YJ\Desktop\图片资源\bmp\1.txt");
            OpenProcess(@"C:\Users\YJ\Desktop\图片资源\bmp\1.bmp");
        }

        static void OpenProcess(string path)
        {
            ProcessStartInfo psi = new ProcessStartInfo(path);
            Process process = new Process();
            process.StartInfo = psi;
            //process.StartInfo.LoadUserProfile = true;
            process.Start();
           
            Console.ReadKey();
        }

        static void ShowProcess()
        {
            Process[] ps = Process.GetProcesses();
            foreach (var item in ps)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void TestThread()
        {
            Thread thread = new Thread(Test);
            thread.Start();
        }

        static void Test()
        {
            
        }
    }
}
