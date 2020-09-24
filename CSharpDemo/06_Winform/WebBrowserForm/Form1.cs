using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("请输入地址");
                return;
            }

            try
            {
                string path;
                if(!textBox1.Text.StartsWith("http://") &&
                    !textBox1.Text.StartsWith("https://"))
                {
                    path = "https://" + textBox1.Text;
                }
                else
                {
                    path = textBox1.Text;
                }
                Uri uri = new Uri(path);
                webBrowser1.Url = uri;
            }
            catch(Exception)
            {
                MessageBox.Show("地址不合法");
            }
            

        }
    }
}
