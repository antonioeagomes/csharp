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

            var person = Person.Parse("Mark");
            person.Introduce("Maria");

            var otherPerson = new Person("Madeline"); /* Constructor that receives a 'name' parameter */

            /* Object initializer is a way to initialize objects without the need to call the constructor */
            var fourthPerson = new Person
            {
                Id = 1,
                Name = "Baltazar",
                LastName = "Bush",
                Birthdate = new DateTime(1974, 8, 19)
            };
        }
    }
}