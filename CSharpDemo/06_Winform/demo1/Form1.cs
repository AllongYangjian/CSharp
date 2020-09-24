using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_love_Click(object sender, EventArgs e)
        {
            MessageBox.Show("么么哒");
            this.Close();
        }

        private void btn_not_love_MouseEnter(object sender, EventArgs e)
        {
            int y = this.ClientSize.Height - btn_not_love.Height;
            int x = this.ClientSize.Width - btn_not_love.Width;

            Random random = new Random();

            btn_not_love.Location = new Point(random.Next(0,x+1),random.Next(0,y+1));
        }

        private void btn_not_love_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被点到了");
            this.Close();
        }
    }
}
