using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Bean
{
    /// <summary>
    /// 字段和属性的封装
    /// </summary>
    class User
    {
        private string _name;

        private int _age;

        private string _address;

        public User(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Address { get => _address; set => _address = value; }

        public void Test()
        {
            Console.WriteLine("Parent Test");
        }
    }

    /// <summary>
    /// 继承：
    /// 继承的特性：
    /// 1、单根性
    /// 2、传递性
    /// </summary>
    class Student : User
    {
        public Student(string name, int age, string address) : base(name, age, address)
        {
        }

        /// <summary>
        /// 使用new关键字隐藏父类的方法
        /// </summary>
        public new void Test()
        {
            Console.WriteLine("Student Test");
        }
    }
}
