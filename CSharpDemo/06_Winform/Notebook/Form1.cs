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

namespace Notebook
{
    public partial class MainContainer : Form
    {

        private List<string> listPath;
        public MainContainer()
        {
            InitializeComponent();
        }

        private void MainContainer_Load(object sender, EventArgs e)
        {
            listPath = new List<string>();
            panel_Container.Visible = false;
            txt_Content.WordWrap = false;
        }

        private void MenuItem_ShowRecord_Click(object sender, EventArgs e)
        {
            panel_Container.Visible = true;
        }

        private void MenuItem_HideRecord_Click(object sender, EventArgs e)
        {
            panel_Container.Visible = false;
        }

        private void Btn_ShowRecord_Click(object sender, EventArgs e)
        {
            panel_Container.Visible = !panel_Container.Visible;
        }

        private void MenuItem_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "请选择要打开的文件";
            dlg.InitialDirectory = @"C:\Users\YJ\Desktop\图片资源\bmp";
            dlg.Filter = "文本文件|*.txt|所有文件|*.txt";
            dlg.Multiselect = true;
            dlg.ShowDialog();

            string path = dlg.FileName;
            if(path == "")
            {
                return;
            }
            listPath.Add(path);
            list_Record.Items.Add(Path.GetFileName(path));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024];
                int length = fs.Read(buffer, 0, buffer.Length);
                txt_Content.Text = Encoding.Default.GetString(buffer, 0,length);
            }
        }

        private void MenuItem_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "请保存文件";
            dlg.InitialDirectory = @"C:\Users\YJ\Desktop\图片资源\bmp";
            dlg.Filter = "文本文件|*.txt|所有文件|*.txt";
            dlg.ShowDialog();

            string path = dlg.FileName;
            if(path == "")
            {
                return;
            }
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(txt_Content.Text);
                fs.Write(buffer, 0, buffer.Length);
            }
            txt_Content.Clear();
        }

        private void MenuItem_AutoEnter_Click(object sender, EventArgs e)
        {
            if(txt_Content.WordWrap)
            {
                MenuItem_AutoEnter.Text = "☆自动换行";
            }
            else
            {
                MenuItem_AutoEnter.Text = "☆取消自动换行";
            }
            txt_Content.WordWrap = !txt_Content.WordWrap;
        }

        private void List_Record_DoubleClick(object sender, EventArgs e)
        {
            string path = listPath[list_Record.SelectedIndex];
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024];
                int length = fs.Read(buffer, 0, buffer.Length);
                txt_Content.Text = Encoding.Default.GetString(buffer, 0, length);
            }
        }

        private void MenuItem_Font_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowDialog();
            txt_Content.Font = dlg.Font;
        }

        private void MenuItem_Color_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            txt_Content.ForeColor = dlg.Color;
        }
    }
}
