using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class FileReader
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd();

                    Console.WriteLine("\n----- File Content -----");
                    Console.WriteLine(content);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: Directory not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Permission denied.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nProgram Finished.");
            }
        }
    }
}
