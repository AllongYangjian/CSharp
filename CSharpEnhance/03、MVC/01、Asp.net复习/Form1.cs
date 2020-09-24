using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Asp.net复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from users where userId = @name and password = @pwd";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@name",SqlDbType.VarChar){Value = txtUserName.Text.Trim().ToString()},
                new SqlParameter("@pwd",SqlDbType.VarChar){Value = txtPwd.Text.Trim().ToString()},
            };

            int count = (int)SqlHelper.ExecutorScalar(sql, CommandType.Text, parameters);
            if(count<=0)
            {
                MessageBox.Show("登录失败");
            }else
            {
                MessageBox.Show("登录成功");
            }

        }
    }
}
