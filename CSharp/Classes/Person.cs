using System;

namespace CSharp.Classes
{
    /* Class is a building block code of a software application.
    *  It is a blueprint of an object.
    *  A class has data and behavior represented by its fields and methods/functions
    **/
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        
        /*
        * Constructor is a method called when an instance is created
        * In order to put the object in an early state
        * It doesn't have a return value even a void
        */
        public Person(){
            /* Default value for 
             * numbers = 0
             * objects and reference types (as string) = null
             * boolean types = false
             */
         }
        public Person(string name)
        {
            // keyword 'this' references to this class member
            this.Name = name;
        }        

        //Instance member: accessible from an object
        public void Introduce(string to){
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        //Static member: Accessed from the class
        public static Person Parse(string str){
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
}