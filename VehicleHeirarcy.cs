using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class VehicleHeirarcy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Vehicle Hierarchy Demo ===\n");

            List<Vehicle> garage = new List<Vehicle>();

            garage.Add(new Car("Toyota", "Fortuner", 2022, 4));
            garage.Add(new Motorcycle("Harley-Davidson", "X 400", 2021, false));

            foreach (Vehicle v in garage)
            {
                v.DisplayInfo();
                v.Accelerate();
                v.Accelerate();
                v.Brake();
                Console.WriteLine("-----------------------------------");
            }

            Console.ReadLine();
        }
    }
}
