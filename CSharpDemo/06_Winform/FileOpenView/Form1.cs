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

namespace FileOpenView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filename = openFileDialog1.FileName;
            //MessageBox.Show(filename);
            using(FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024];

                int length = fs.Read(buffer, 0, buffer.Length);
                string text = Encoding.UTF8.GetString(buffer);
                textBox1.Text = text;
            }
        }
    }
}
