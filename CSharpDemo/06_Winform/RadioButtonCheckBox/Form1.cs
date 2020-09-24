using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 登录判断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(rb_female.Checked || rb_male.Checked)
            {
                if (rb_female.Checked)
                {
                    if(txt_username.Text.Equals("admin") && txt_password.Text.Equals("123"))
                    {
                        MessageBox.Show("登录成功");
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                    }
                }
                else
                {
                    if (txt_username.Text.Equals("admin") && txt_password.Text.Equals("456"))
                    {
                        MessageBox.Show("登录成功");
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择角色");
            }
        }
    }
}
