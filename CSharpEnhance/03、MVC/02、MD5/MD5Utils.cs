using System.Security.Cryptography;
using System;
using System.Text;
using System.IO;

namespace _02_MD5
{
    class MD5Utils
    {
        /// <summary>
        /// 获取md5加密后的字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string getMd5String(string str)
        {
            StringBuilder sb = new StringBuilder();
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = Encoding.Default.GetBytes(str);
                byte[] buffer = md5.ComputeHash(bytes);
                for (int x = 0; x < buffer.Length; x++)
                {
                    sb.Append(buffer[x].ToString("x2"));
                }
            }
            return sb.ToString();
        }
       
        /// <summary>
        /// 获取md5加密后的文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static String GetMd5File(string path)
        {
            StringBuilder sb = new StringBuilder();
            using (MD5 md5 = MD5.Create())
            {
                byte[] buffer = File.ReadAllBytes(path);
                for (int x = 0; x < buffer.Length; x++)
                {
                    sb.Append(x.ToString("x2"));
                }
            }
            return sb.ToString();
        }

    }
}