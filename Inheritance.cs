using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    //interface A
    //{
    //    void Add();
    //}

    //interface B
    //{
    //    void Sub();
    //}
    //internal class Inheritance:A,B
    //{
    //    public void Add() {
    //        int a = 10, b = 20;
    //        Console.WriteLine(a + b);
    //    }

    //    public void Sub()
    //    {
    //        int a = 10, b = 20;
    //        Console.WriteLine(a - b);
    //    }
    class Animal
    {
        public Animal(string name)
        {
            Console.WriteLine(name);
        }
        public void Eat()
        {
            Console.WriteLine("Animal Eating");
        }
    }

    class Dog : Animal
    {
        public Dog() : base("Animal Constructor")
        {

        }
        public void Show()
        {
            base.Eat();
        }
        }

        public class Inheritance
    {
        public static void Main(string[] args)
        {
            //Inheritance i = new Inheritance();
            //i.Add();
            //i.Sub();

            Dog d = new Dog();
            d.Eat();

        }
}
}

