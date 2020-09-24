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

namespace _4_省市联动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from TblArea where pid = @pid";
            SqlParameter[] parameter = new SqlParameter[] {
               new SqlParameter("@pid",SqlDbType.Int){Value = 0}
           };
            //List<TblArea> list = new List<TblArea>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TblArea area = new TblArea
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Pid = reader.GetInt32(2)
                        };
                        //list.Add(area);
                        cbxProvince.Items.Add(area);
                    }
                }
            }


        }

        private void CbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblArea area = cbxProvince.SelectedItem as TblArea;

            string sql = "select * from TblArea where pid = @pid";
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@pid",SqlDbType.Int){ Value = area.ID} };
            List<TblArea> list = new List<TblArea>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TblArea data = new TblArea
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Pid = reader.GetInt32(2)
                        };
                        list.Add(data);
                    }
                }
            }
            cbxCity.ValueMember = "ID";
            cbxCity.DisplayMember = "Name";
            cbxCity.DataSource = list;

        }
    }
}
