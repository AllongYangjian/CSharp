using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_窗体传值
{
    public delegate void DelMsg(string msg);
    public partial class Form2 : Form
    {
        private DelMsg _msg;

        public Form2(DelMsg msg)
        {
            this._msg = msg;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _msg(textBox1.Text);
        }
    }
}
