using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGrammer.Bean
{
    public struct Person
    {
        public string _name
        {
            get;
            set;
        }

        public int _age
        {
            get;
            set;
        }

        public Gender _gender
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "name:" + _name
                + ",age:" + _age
                + ",gender:" + _gender.ToString();
        }


    }
}
