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

namespace _5_省市联动TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData(0, this.tvData.Nodes);
        }

        private void LoadData(int v, TreeNodeCollection nodes)
        {
           
            List<TblArea> list = GetData(v);
            
            foreach(TblArea item in list)
            {
                //该方法会返回当前节点
                TreeNode node = nodes.Add(item.Name);
                LoadData(item.ID, node.Nodes);
            }
        }

        private List<TblArea> GetData(int v)
        {
            List<TblArea> list = new List<TblArea>();
            string sql = "select * from TblArea where pid = @pid";
            SqlParameter[] parameter = new SqlParameter[] {
                new SqlParameter("@pid",SqlDbType.Int){ Value = v}
            };

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, parameter))
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        TblArea area = new TblArea
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Pid = reader.GetInt32(2)
                        };
                        list.Add(area);
                    }
                }
            }
            return list;
        }
    }
}
