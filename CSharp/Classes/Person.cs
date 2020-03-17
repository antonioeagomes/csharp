using System;

namespace CSharp.Classes
{
    /* Class is a building block code of a software application.
    *  It is a blueprint of an object.
    *  A class has data and behavior represented by its fields and methods/functions
    **/
    public class Person
    {
        public int Id { get; set; } // Properties do encapsulation with less code.
        public string Name { get; set; }
        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime Birthdate { get; private set; }

        private string _favouriteColor;

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        /*
        * Constructor is a method called when an instance is created
        * In order to put the object in an early state
        * It doesn't have a return value even a void
        */
        public Person()
        {
            
        }
        public Person(DateTime dob)
        {
            /* Default value for 
             * numbers = 0
             * objects and reference types (as string) = null
             * boolean types = false
             */
            Birthdate = dob != null ? dob : DateTime.Today;
        }
        public Person(string name)
        {
            // keyword 'this' references to this class member
            this.Name = name;
        }

        //Instance member: accessible from an object
        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        //Static member: Accessed from the class
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }

        /* Encapsulation */
        public void SetFavoriteColor(string color)
        {
            _favouriteColor = color;
        }

        public string GetFavoriteColor()
        {
            return this._favouriteColor;
        }
    }
}