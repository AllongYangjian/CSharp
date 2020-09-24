using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class AbstractClass
    {
        public abstract void Bark();
    }

    public class Dog : AbstractClass
    {
        public override void Bark()
        {
            Console.WriteLine("Dog 汪汪叫");
        }
    }

    public class Cat : AbstractClass
    {
        public override void Bark()
        {
            Console.WriteLine("Cat 汪汪叫");
        }
    }
}
