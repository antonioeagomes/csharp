using System;

namespace CSharp.Inheritance
{
    public class Vehicle
    {
        private string _registrationNumber;

        public Vehicle()
        {
            Console.WriteLine("Vehicle initialized.");
        }
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine($"Base class constructor executes first. [{_registrationNumber}]");
        }
    }
}