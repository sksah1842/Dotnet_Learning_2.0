using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message)
            : base(message)
        {
        }
    }
    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            //int age = -5;

            //try
            //{
            //    if (age < 0)
            //    {
            //        throw new Exception("Age cannot be negative.");
            //    }

            //    Console.WriteLine(age);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            try
            {
                int age = -1;

                if (age < 0)
                    throw new InvalidAgeException("Invalid Age");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
