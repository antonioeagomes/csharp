using System;

namespace CSharp.Inheritance
{
    public class PresentationObject
    {
        public PresentationObject()
        {
            Console.WriteLine("Constructor of  PresentationObject");
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public void Copy(){
            Console.WriteLine("Object copied to clipboard.");
        }
        public void Duplicate() {
            Console.WriteLine("Duplicated");
        }

    }
}