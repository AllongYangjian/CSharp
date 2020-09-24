using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxView
{

    public partial class Form1 : Form
    {

        private string[] path = Directory.GetFiles(@"C:\Users\YJ\Desktop\图片资源\bmp", "*.bmp");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int x = 0;x<path.Length;x++)
            {
                string fileName = Path.GetFileName(path[x]);
                listBox1.Items.Add(fileName);
            }
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            pictureBox1.Image = Image.FromFile(path[listBox1.SelectedIndex]);
        }
    }
}
