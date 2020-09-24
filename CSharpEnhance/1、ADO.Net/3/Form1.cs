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

namespace _3
{
    public partial class Form1 : Form
    {
        private string constr = "Data Source=DESKTOP-VBO5GUV;Initial Catalog = adoTest1;Integrated Security = true";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPwd.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入用户名或密码");
                return;
            }
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = string.Format("select * from users where userId = '{0}'", username);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string pwd = reader.GetString(2);
                            if (password.Equals(pwd))
                            {
                                MessageBox.Show("登录成功");
                            }
                            else
                            {
                                MessageBox.Show("用户名或密码错误");
                            }
                        }
                    }
                }

            }
        }

        private void BtnLogin2_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPwd.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入用户名或密码");
                return;
            }
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = "select count(*) from users where userId = @userId and password = @password";

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    SqlParameter paramId = new SqlParameter("@userId", SqlDbType.VarChar)
                    {
                        Value = username
                    };

                    SqlParameter paramPwd = new SqlParameter("@password", SqlDbType.VarChar, 50)
                    {
                        Value = password
                    };

                    command.Parameters.Add(paramId);
                    command.Parameters.Add(paramPwd);

                    conn.Open();

                    int ret = (int)command.ExecuteScalar();

                    if(ret>0)
                    {
                        MessageBox.Show("登录成功");
                    }
                    else
                    {
                        MessageBox.Show("登陆失败");
                    }
                }

            }
        }
    }
}
