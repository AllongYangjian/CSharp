using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DrawLine();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawLine();
        }

        private void DrawLine()
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Point p1 = new Point(30, 50);
            Point p2 = new Point(250, 250);

            graphics.DrawLine(pen, p1, p2);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            graphics.DrawRectangle(pen,50, 50, 100, 200);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            Rectangle rect = new Rectangle(10,10,50,50);
            graphics.DrawPie(pen, rect, 90, 120);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            //Pen pen = new Pen(Brushes.Black);
            graphics.DrawString("hello world", new Font("宋体", 20, FontStyle.Underline), 
                Brushes.Black, new Point(20, 50));
              
        }
    }
}
