using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class SMS
    {
        static void Main(string[] args)
        {
            List<Student> database = new List<Student>();
            database.Add(new Student(101, "Sumit", 92.5));
            database.Add(new Student(102, "Ayush", 78.2));
            database.Add(new Student(103, "Prince", 58.0));

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("=== STUDENT MANAGEMENT SYSTEM ===");
                Console.WriteLine("1. View All Students");
                Console.WriteLine("2. Add New Student");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. View System Class Statistics");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");

                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                if (choice == 1)
                {
                    Console.WriteLine("ID\t| Name\t\t| Grade\t| Status");
                    

                    foreach (Student s in database)
                    {
                        Console.WriteLine(s.Id + "\t| " + s.Name + "\t\t| " + s.Grade + "%\t| " + s.GetStatus());
                    }
                }

                if (choice == 2)
                {
                    Console.Write("Enter unique Student ID: ");
                    int newId = Convert.ToInt32(Console.ReadLine());

                    bool idExists = false;
                    foreach (Student s in database)
                    {
                        if (s.Id == newId) 
                        {
                            idExists = true;
                        }
                    }

                    if (idExists)
                    {
                        Console.WriteLine("Error: A student with ID " + newId + " already exists!");
                    }
                    else
                    {
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Final Grade (0-100): ");
                        double grade = Convert.ToDouble(Console.ReadLine());

                        if (grade >= 0 && grade <= 100)
                        {
                            database.Add(new Student(newId, name, grade));
                            Console.WriteLine("Student added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid grade. Must be between 0 and 100.");
                        }
                    }
                }

                if (choice == 3)
                {
                    Console.Write("Enter Student ID to search: ");
                    int searchId = Convert.ToInt32(Console.ReadLine());
                    bool found = false;

                    foreach (Student s in database)
                    {
                        if (s.Id == searchId)
                        {
                            Console.WriteLine("--- Student Found ---");
                            Console.WriteLine("ID: " + s.Id);
                            Console.WriteLine("Name: " + s.Name);
                            Console.WriteLine("Grade: " + s.Grade + "%");
                            Console.WriteLine("Status: " + s.GetStatus());
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("No student found with ID: " + searchId);
                    }
                }

                if (choice == 4)
                {
                    if (database.Count == 0)
                    {
                        Console.WriteLine("No students in the system.");
                    }
                    else
                    {
                        double totalSum = 0;
                        int passCount = 0;

                        foreach (Student s in database)
                        {
                            totalSum += s.Grade; 
                            if (s.Grade >= 60)
                            {
                                passCount++; // Increment operator
                            }
                        }

                        double classAverage = totalSum / database.Count;

                        Console.WriteLine("--- Class Statistics ---");
                        Console.WriteLine("Total Registered Students: " + database.Count);
                        Console.WriteLine("Class Average Score: " + classAverage.ToString("F2") + "%");
                        Console.WriteLine("Total Students Passing: " + passCount);
                    }
                }

                if (choice == 5)
                {
                    keepRunning = false;
                    Console.WriteLine("Exiting system. Goodbye!");
                }

                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid selection. Choose an option between 1 and 5.");
                }

                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }


        }
    }
}
