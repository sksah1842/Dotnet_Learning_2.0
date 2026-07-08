using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Collections
    {
        class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public double Marks { get; set; }

            public string GetGrade()
            {
                if (Marks >= 90)
                    return "A+";
                else if (Marks >= 80)
                    return "A";
                else if (Marks >= 70)
                    return "B";
                else if (Marks >= 60)
                    return "C";
                else if (Marks >= 50)
                    return "D";
                else
                    return "F";
            }
        }

        public static void Main(string[] args)
        {
            //int[] numbers = new int[3];

            //int[] arr = { 10, 20, 30 };

            //foreach (int num in arr)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine(arr.Length);

            //Array.Clear(arr, 0, 2);
            //foreach (int num in arr)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine(arr.Length);

            //List<int> numbers = new List<int>();

            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);



            ////Console.WriteLine(numbers[1]);
            //numbers.Remove(20);
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            List<Student> students = new List<Student>();

            students.Add(new Student { RollNo = 101, Name = "Sumit", Marks = 92 });
            students.Add(new Student { RollNo = 102, Name = "Rahul", Marks = 76 });
            students.Add(new Student { RollNo = 103, Name = "Aman", Marks = 58 });

            Console.WriteLine("Student Grade Report");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Roll\tName\tMarks\tGrade");

            foreach (Student s in students)
            {
                Console.WriteLine($"{s.RollNo}\t{s.Name}\t{s.Marks}\t{s.GetGrade()}");
            }
        }
    }
}
