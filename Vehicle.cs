using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
       

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            Speed = 0;
        }

        public virtual void Accelerate()
        {
            Speed += 10; 
            Console.WriteLine($"{Make} {Model} accelerates. Current speed: {Speed} km/h");
        }

        public void Brake()
        {
            Speed -= 15; 
            if (Speed < 0) 
            {
                Speed = 0;
            }
            Console.WriteLine($"{Make} {Model} brakes. Current speed: {Speed} km/h");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Year} {Make} {Model}");
        }
    }
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model} ({NumberOfDoors} Doors)");
        }
    }

    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, bool hasSidecar)
            : base(make, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public override void Accelerate()
        {
            Speed += 25; 
            Console.WriteLine($"{Make} {Model} twists the throttle! Current speed: {Speed} km/h");
        }

        public override void DisplayInfo()
        {
            string sidecarStatus = HasSidecar ? "with Sidecar" : "no Sidecar"; 
            Console.WriteLine($"Motorcycle: {Year} {Make} {Model} ({sidecarStatus})");
        }
    }
}
