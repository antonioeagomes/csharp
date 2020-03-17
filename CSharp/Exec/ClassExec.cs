using System;
using CSharp.Classes;

namespace CSharp.Exec
{
    public static class ClassExec
    {
        public static void Run()
        {
            Person p = new Person(); /* Parameterless constructor */
            p.Name = "John";
            p.Introduce("James");
            p.SetFavoriteColor("Blue"); // Favorite color encapsulated

            Console.WriteLine($"{p.GetFavoriteColor()} is {p.Name}'s favourite color");

            var person = Person.Parse("Mark");
            person.Introduce("Maria");

            var otherPerson = new Person("Madeline"); /* Constructor that receives a 'name' parameter */

            /* Object initializer is a way to initialize objects without the need to call the constructor */
            var fourthPerson = new Person
            {
                Id = 1,
                Name = "Baltazer",
                LastName = "Bush",
            };

            var oldPerson = new Person(new DateTime(1789, 3, 18));
            Console.WriteLine($"{oldPerson.Age} years old!");
        }
    }
}