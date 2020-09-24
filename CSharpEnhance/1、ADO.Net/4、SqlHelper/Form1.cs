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

namespace _4_SqlHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from users where userId = @userId and password = @password";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@userId",SqlDbType.VarChar,50){
                Value = txtUserId.Text.Trim()},
                new SqlParameter("@password",SqlDbType.VarChar,50){
                Value = txtPwd.Text.Trim()}
             };
            object ret = SqlHelper.ExecuteScalar(sql, parameters);
            if (Convert.ToInt32(ret) > 0)
            {
                this.Text = "登录成功";
            }
            else
            {
                this.Text = "登录失败";
            }

        }
    }
}
