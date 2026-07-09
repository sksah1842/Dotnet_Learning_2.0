using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ContactManagementSystem
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("\n===== Contact Management System =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Phone Number: ");
                        string phone = Console.ReadLine();

                        if (!contacts.ContainsKey(name))
                        {
                            contacts.Add(name, phone);
                            Console.WriteLine("Contact added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Contact already exists.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- Contact List ---");

                        if (contacts.Count == 0)
                        {
                            Console.WriteLine("No contacts available.");
                        }
                        else
                        {
                            foreach (var contact in contacts)
                            {
                                Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Enter Name to Search: ");
                        string searchName = Console.ReadLine();

                        if (contacts.ContainsKey(searchName))
                        {
                            Console.WriteLine("Phone Number: " + contacts[searchName]);
                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Name to Delete: ");
                        string deleteName = Console.ReadLine();

                        if (contacts.Remove(deleteName))
                        {
                            Console.WriteLine("Contact deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
