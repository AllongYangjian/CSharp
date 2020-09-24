using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace app
{
    class MD5Utils
    {
        public static string md5(string pwd)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.GetEncoding("GBK").GetBytes(pwd);

            byte[] mdfBuffer = md5.ComputeHash(buffer);


            string str = "";
            for (int x= 0; x < mdfBuffer.Length; x++){
                str += mdfBuffer[x].ToString("x2");
            }
            return str;
        }
    }
}
