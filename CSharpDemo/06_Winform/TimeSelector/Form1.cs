using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int x = DateTime.Now.Year;x >= 1949;  x--)
            {
                cbx_Year.Items.Add(x + "年");
            }
            
        }

        private void Cbx_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_Month.Items.Clear();
            for(int x = 1;x<=12;x++)
            {
                cbx_Month.Items.Add(x + "月");
            }
        }

        private void Cbx_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_Day.Items.Clear();
            int days = 0;
            string yearItem = cbx_Year.SelectedItem.ToString();
            string monthItem = cbx_Month.SelectedItem.ToString();

            string year = yearItem.Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string month = monthItem.Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];

            int y = Convert.ToInt32(year);
            int m = Convert.ToInt32(month);
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 2:
                    if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
                    {
                        days = 28;
                    }
                    else
                    {
                        days = 29;
                    }
                    break;
                default:
                    days = 30;
                    break;
            }
            for(int x = 1; x <= days; x++)
            {
                cbx_Day.Items.Add(x + "天");
            }

            
        }
    }
}
