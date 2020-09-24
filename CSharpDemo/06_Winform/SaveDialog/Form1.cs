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

namespace SaveDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Title = "请选择要保存的路径";
            dlg.InitialDirectory = @"C:\Users\YJ\Desktop\图片资源\bmp";
            dlg.Filter = "文本文件|*.txt|所有文件|*.*";
          
            dlg.ShowDialog();

            string path = dlg.FileName;
            if(path =="")
            {
                return;
            }
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(txt_Content.Text);
                fs.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
