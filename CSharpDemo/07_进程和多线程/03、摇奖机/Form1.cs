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

namespace _03_摇奖机
{
    public partial class Form1 : Form
    {
        private bool isStart;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                isStart = true;
                button1.Text = "停止";

                Thread thread = new Thread(PlayGame);
                thread.Start();
            }
            else
            {
                isStart = false;
                button1.Text = "开始";
            }
        }

        private void PlayGame()
        {
            Random r = new Random();
            while(isStart)
            {
                label1.Text = r.Next(0, 10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();
            }
        }
    }
}
