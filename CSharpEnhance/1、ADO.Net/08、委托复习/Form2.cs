using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_委托复习
{

    public delegate void ShowMsgAction(string msg);

    public partial class Form2 : Form
    {


        private ShowMsgAction action;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ShowMsgAction action):this()
        {            
            this.action = action;
        }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            action(textBox1.Text);
        }
    }
}
