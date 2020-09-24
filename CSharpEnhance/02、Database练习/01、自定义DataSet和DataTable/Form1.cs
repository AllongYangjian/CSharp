using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_自定义DataSet和DataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from TblClass";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            this.dataGridView1.DataSource = dt;
        }
    }
}
