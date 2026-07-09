using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(101, "Sumit");
            students.Add(102, "Rahul");
            students.Add(103, "Aman");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
            Console.WriteLine(students[101]);

            if (students.ContainsKey(101))
            {
                Console.WriteLine("Student Found");
            }
            if (students.ContainsValue("Sumit"))
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
