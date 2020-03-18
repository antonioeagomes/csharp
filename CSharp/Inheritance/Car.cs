using System;

namespace CSharp.Inheritance
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car initialized");
        }
        public Car(string registrationNumber) : base(registrationNumber)
        { /* Calls the parent constructor */
            Console.WriteLine($"Car's constructor [{registrationNumber}]");
        }
    }
}