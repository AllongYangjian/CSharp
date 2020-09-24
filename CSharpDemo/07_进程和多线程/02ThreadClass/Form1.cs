using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02ThreadClass
{
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //允许跨进程访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(Test);
            thread.IsBackground = true;//将线程设置为后台线程
            thread.Start();
        }

        public void Test()
        {
            for (int x = 0; x < 10000; x++)
            {
                Thread.Sleep(1);
                textBox1.Text = x + "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread!=null)
            {
                thread.Abort();
            }
        }
    }
}
