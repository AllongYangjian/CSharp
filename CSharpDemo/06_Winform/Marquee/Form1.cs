using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marquee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 定时器周期方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string txt = label1.Text;
            string first = txt.Substring(0, 1);
            string temp = txt.Substring(1);
            label1.Text = temp + first;
        }

        private void timer_of_time_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString();
            if(DateTime.Now.Hour == 22 && DateTime.Now.Minute == 44
                && DateTime.Now.Second == 5)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"E:\VSProject\CSharpDemo\06_Winform\Marquee\1.wav";
                sp.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString();
        }
    }
}
