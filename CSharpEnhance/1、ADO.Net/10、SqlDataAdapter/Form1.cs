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

namespace _10_SqlDataAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=DESKTOP-VBO5GUV;Initial Catalog= adotest1;Integrated Security = true";
            string sql = "select * from TblClass";
            DataTable dataSet = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                adapter.Fill(dataSet);
            }
            this.dataGridView1.DataSource = dataSet;
        }
    }
}
