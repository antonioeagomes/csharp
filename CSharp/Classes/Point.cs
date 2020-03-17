using System;

namespace CSharp.Classes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /* Overloading methods 
         * Signature of a method is the name and number and type of parameters 
         */
        public void Move(int x, int y)
        {
            this.X += x;
            this.Y += y;
        }
        public void Move(Point newLocation)
        {
            // this.X += newLocation.X;
            // this.Y += newLocation.Y;

            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
        public void Move(Point newLocation, int speed) { }

        /* Method with a varying number of parameters */
        public void Add(int[] numbers) { }

        public void GetLocation()
        {
            System.Console.WriteLine($"Point is at {this.X} x {this.Y}");
        }
    }

    public static class OutRefModifiers
    {
        public static void DoAWeirdThing(ref int a)
        {
            a += 5;
        }

        public static void DoAWeirdThingWithOut(out int b)
        {
            /* It can be used when it is needed to return more then one value*/
            b = 99;
        }
    }
}