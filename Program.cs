using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /, %): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool isOperationValid = true;

            if (op == '+')
            {
                result = num1 + num2;
            }
            if (op == '-')
            {
                result = num1 - num2;
            }
            if (op == '*')
            {
                result = num1 * num2;
            }

            if (op == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                if (num2 == 0) 
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    isOperationValid = false;
                }
            } 

            if (op == '%')
            {
                result = num1 % num2;
            }

            if (op != '+' && op != '-' && op != '*' && op != '/' && op != '%')
            {
                Console.WriteLine("Error: Invalid operator entered.");
                isOperationValid = false;
            }

            if (isOperationValid == true)
            {
                Console.WriteLine("Result: " + num1 + " " + op + " " + num2 + " = " + result);
            }

            Console.ReadLine(); 
        }
    }
}