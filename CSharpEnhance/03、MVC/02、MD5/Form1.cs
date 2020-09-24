using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_MD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BntConvert_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            using (MD5 mdt = MD5.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(txtSrc.Text.Trim().ToString());

                byte[] md5Byte = mdt.ComputeHash(bytes);
                
                for(int x = 0;x<md5Byte.Length;x++)
                {
                    sb.Append(md5Byte[x].ToString("x2"));
                }
            }
            txtDest.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
