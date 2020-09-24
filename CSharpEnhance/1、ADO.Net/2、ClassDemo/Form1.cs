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

namespace _2_ClassDemo
{
    public partial class ClassForm : Form
    {
        private string constr = "Data Source=DESKTOP-VBO5GUV;Initial Catalog = adoTest1;Integrated Security = true";

        public ClassForm()
        {
            InitializeComponent();
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<TblClass> list = new List<TblClass>();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = "select * from TblClass order by tClassId asc";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TblClass tblClass = new TblClass();
                                tblClass.TClassId = reader.GetInt32(0);
                                tblClass.TClassName = reader.GetString(1);
                                tblClass.TClassDesc = reader.GetString(2);
                                list.Add(tblClass);
                            }
                        }
                    }
                }
            }
            this.dgvClass.DataSource = list;

        }

        private void BtnClassAdd_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
            string classDesc = txtClassDesc.Text;

            //string sql = string.Format("insert into TblClass values('{0}','{1}')", className, classDesc);
            string sql = string.Format("insert into TblClass output inserted.tClassId values('{0}','{1}')", className, classDesc);

            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    //int r = command.ExecuteNonQuery();
                    //if (r > 0)
                    //{
                    //    MessageBox.Show("插入成功");
                    //    ClearData();
                    //    LoadData();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("插入失败");
                    //}
                    object obj = command.ExecuteScalar();
                    this.Text = "刚刚插入的自动编号是：" + obj.ToString();
                    LoadData();
                }
            }
        }

        private void ClearData()
        {
            txtClassName.Clear();
            txtClassDesc.Clear();
        }

        private void DgvClass_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //获取当前选中的行对象
            DataGridViewRow item = dgvClass.Rows[e.RowIndex];
            //获取当前行中绑定的TblClass数据对象
            TblClass tblClass = item.DataBoundItem as TblClass;
            if (tblClass != null)
            {
                txtClassNameEdit.Text = tblClass.TClassName;
                txtClassNameDesc.Text = tblClass.TClassDesc;
                txtId.Text = tblClass.TClassId.ToString();
            }
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClassEdit_Click(object sender, EventArgs e)
        {
            TblClass cls = new TblClass();
            cls.TClassId = Convert.ToInt32(txtId.Text);
            cls.TClassName = txtClassNameEdit.Text;
            cls.TClassDesc = txtClassNameDesc.Text;

            using (SqlConnection connection = new SqlConnection(constr))
            {
                string sql = string.Format("update TblClass set tClassName = '{0}',tClassDesc = '{1}' where " +
                    "tClassId  ='{2}'", cls.TClassName, cls.TClassDesc, cls.TClassId);
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    int r = command.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("更新成功");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("更新失败");
                    }
                }
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClassDelete_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from TblClass where tClassId = '{0}'",
                Convert.ToInt32(txtId.Text));
            DialogResult result = MessageBox.Show("确定删除数据吗?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        int ret = command.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            MessageBox.Show("删除成功");
                            txtClassNameEdit.Clear();
                            txtClassNameDesc.Clear();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("删除失败");
                        }
                    }
                }
            }
        }
    }
}
