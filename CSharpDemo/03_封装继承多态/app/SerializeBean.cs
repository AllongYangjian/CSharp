using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    [Serializable]
    class SerializeBean
    {
        private string _name;

        private int _age;

        private char _gender;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public char Gender { get => _gender; set => _gender = value; }
    }
}
