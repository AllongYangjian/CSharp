using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DrawBitmap();
        }

        private void DrawBitmap()
        {
            Bitmap bitmap = new Bitmap(120, 40);
            Graphics graphics = Graphics.FromImage(bitmap);
            string txt = GeneratorRandomString();
            string[] fonts = { "微软雅黑", "宋体", "黑体", "隶书", "仿宋" };
            Color[] colors = { Color.Yellow, Color.Blue, Color.Black, Color.Red, Color.Red };
            Random r = new Random();
            //int x  = 0,y = 0;
            for (int i= 0;i<txt.Length;i++)
            {
                Point p = new Point((i + 1) * 15, 5);
                string font = fonts[r.Next(0, 5)];
                Color color = colors[r.Next(0, 5)];
                graphics.DrawString(txt[i].ToString(), new Font(font, 16, FontStyle.Bold),
                    new SolidBrush(color), p);
               
            }

            ///划线
            for(int j = 0; j < 20; j++)
            {
                Point p1 = new Point(r.Next(0, bitmap.Width), r.Next(0, bitmap.Height));
                Point p2 = new Point(r.Next(0, bitmap.Width), r.Next(0, bitmap.Height));
                Color color = colors[r.Next(0, 5)];
                graphics.DrawLine(new Pen(color), p1, p2);
            }

            for(int j = 0;j<500;j++)
            {
                Point p1 = new Point(r.Next(0, bitmap.Width), r.Next(0, bitmap.Height));
                bitmap.SetPixel(p1.X, p1.Y, Color.Black);
            }
            pictureBox1.Image = bitmap;
        }

        /// <summary>
        /// 产生随机字符串
        /// </summary>
        /// <returns></returns>
        private string GeneratorRandomString()
        {
            Random random = new Random();
            string s = "";
            for (int x = 0;x<5;x++)
            {
                s += random.Next(0, 10);
            }
            return s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawBitmap();
        }
    }
}
