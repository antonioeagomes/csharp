using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CSharp.Inheritance;

namespace CSharp.Exec
{
    public class InheritanceExec : IExecutable
    {
        public void Execute()
        {
            // UseCarVehicle();
            // UsePresentation();
            // UseUpcastingDowncasting();
            UseStack();
        }

        private void UseStack()
        {
            var stack = new Inheritance.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }

        public void UseCarVehicle()
        {
            var car = new Car();
            var car2 = new Car("180320201050");
        }

        public void UsePresentation()
        {
            var text = new Text();
            /* Member of the class */
            text.AddHyperlink("Member from text");
            text.FontSize = 12;

            /* Members from parent class PresentationObject */
            text.Width = 100;
            text.Copy();
        }

        public void UseUpcastingDowncasting()
        {
            Circle circle = new Circle();
            Shape shape = circle; // Upcasting - implicit
            /* Circle cir = (Circle)shape; */ // Downcasting - explicit
            circle.Width = 200;
            shape.Width = 400;
            Console.WriteLine(circle.Width); /* What is gonna be shown? 400*/
            StreamReader reader = new StreamReader(new MemoryStream()); /*Stream - FileStram, MemoryStream */

            Shape sh = new Circle();

        }

        public void UseBoxingUnboxing() {
            /* Boxing converts a value type into an object reference */
            int number = 10; /* Stack*/
            object obj = number; /* Heap */
            object obj2 = 10;

            /* Unboxing is converting reference into value type */
            int num = (int)obj;

            var list = new ArrayList();
            list.Add(1); /* Boxing happens int to object */
            list.Add("One");
            list.Add(DateTime.Today.Day); /* Boxing happens struct to object */

            // var n = (int)list[1]; // Exception

            var anotherList = new List<int>();
            anotherList.Add(5); /* No boxing */
        }
    }
}