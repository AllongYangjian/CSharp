using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        string[] pictures;
        int index = 0;

        public Form1()
        {
            InitializeComponent();

            pictures = Directory.GetFiles(@"C:\Users\YJ\Desktop\图片资源\bmp");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = pictures.Length - 1;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= pictures.Length)
            {
                index = 0;
            }
            LoadFile();
        }

        private void LoadFile()
        {
            pictureBox1.Image = Image.FromFile(pictures[index]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            LoadFile();
        }
    }
}
