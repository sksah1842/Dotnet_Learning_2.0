using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    interface A
    {
        void Add();
    }

    interface B
    {
        void Sub();
    }
    internal class Inheritance:A,B
    {
        public void Add() {
            int a = 10, b = 20;
            Console.WriteLine(a + b);
        }

        public void Sub()
        {
            int a = 10, b = 20;
            Console.WriteLine(a - b);
        }

    public static void Main(string[] args)
        {
            Inheritance i = new Inheritance();
            i.Add();
            i.Sub();
        }
}
}

