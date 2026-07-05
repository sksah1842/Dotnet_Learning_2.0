using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    //public class A
    //{
    //    int x, y, z;

    //    public void Add(int x, int y)
    //    {
    //        Console.WriteLine(x + y);
    //    }

    //    public void Add(int x, int y, int z)
    //    {
    //        Console.WriteLine(x + y + z);
    //    }
    //}
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Parent class show");
        }
    }

    class B : A
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("child class show");
        }
    }

    internal class Polymorphism
    {
        public static void Main(string[] args)
        {
            //A a = new A();
            //a.Add(3, 4);
            //a.Add(3, 4, 5);

            B b = new B();
            b.show();
        }
    }
}