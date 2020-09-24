using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class InterfaceTest : IFlyable
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            Console.WriteLine("can fly");
        }

        public void Test5()
        {
        }
        private void Test4()
        {
        }
        protected void Test3()
        {
        }
        internal void Test2()
        {
        }
        protected internal void Test1()
        {

        }
    }

    public interface IFlyable
    {
        void Fly();

        string Name
        {
            get;
            set;
        }
    }
}
