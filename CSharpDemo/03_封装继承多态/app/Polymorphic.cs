using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    /// <summary>
    /// 多态的实现：
    /// 1、虚方法
    /// 2、抽象类
    /// 3、接口
    /// </summary>
   public  class Polymorphic
    {

        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Polymorphic(string name)
        {
            Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("{0} say hello",Name);
        }
    }

    public class Chinese : Polymorphic
    {
        public Chinese(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("{0} say hello", Name);
        }
    }

    public class Japan : Polymorphic
    {
        public Japan(string name) : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("{0} say hello", Name);
        }
    }
}
