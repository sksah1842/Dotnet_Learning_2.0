using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //class Stud
    //{
    //    private int age;

    //    public void SetAge(int value)
    //    {
    //        if (value > 0)
    //            age = value;
    //        else
    //            Console.WriteLine("Invalid Age");
    //    }

    //    public int GetAge()
    //    {
    //        return age;
    //    }
    //}

    abstract class Speaker
    {
        public abstract void Sound();
    }

    class JBL : Speaker
    {
        public override void Sound()
        {
            Console.WriteLine("JBL speaker");
        }
    }
    internal class Encapsulation
    {
        public static void Main(string[] args)
        {
            //Stud s = new Stud();
            //s.SetAge(21);

            //Console.WriteLine(s.GetAge());

            JBL j = new JBL();
            j.Sound();

        }
    }
}
