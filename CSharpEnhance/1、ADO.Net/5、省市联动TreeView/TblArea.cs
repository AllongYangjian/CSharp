using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_省市联动TreeView
{
    class TblArea
    {
        public int ID
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public int Pid
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
