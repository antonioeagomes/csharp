using System;
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
            UseUpcastingDowncasting();
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
    }
}