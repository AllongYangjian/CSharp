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

namespace _02_插入空值练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString().Trim();
            int age = Convert.ToInt32(txtAge.Text.ToString().Trim());
            string h = txtHeight.Text.ToString().Trim();
            string g = txtGender.Text.ToString().Trim();
            int? height = h.Length == 0 ? null :(int?) Convert.ToInt32(h);
            bool? gender = g.Length == 0 ? null : (bool?)Convert.ToBoolean(g);
            string sql = "insert into Person values(@name,@age,@height,@gender)";
            SqlParameter[] pms = new SqlParameter[] {
                new SqlParameter("@name",SqlDbType.VarChar,50){Value = name},
                new SqlParameter("@age",SqlDbType.Int){Value = age},
                new SqlParameter("@height",SqlDbType.Int){Value=height ==null?
                DBNull.Value:(object)height},
                new SqlParameter("@gender",SqlDbType.Bit){ Value = gender ==null?
                DBNull.Value:(object)gender}
            };

            int ret = SqlHelper.ExecuteNonQuery(sql, pms);
            if (ret > 0)
            {
                MessageBox.Show("插入成功");
            }
            else
            {
                MessageBox.Show("插入失败");
            }
           
        }
    }
}
