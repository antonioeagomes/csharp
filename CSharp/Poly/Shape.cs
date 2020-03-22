using System;
using System.Collections.Generic;

namespace CSharp.Poly
{
    public abstract class Shape
    {/*Abstract classes cannot be instanced */
        public int Width { get; set; }
        public int Height { get; set; }
        public float Area { get; set; }

        /* ShapeType will not be necessary when apply polymorphism */
        // public ShapeType Type { get; set; }

        /* A class to be overriden */
        /* As we don't know how to draw a shape per se
         * this method should be an abstract method.
         * So the class must be declared as abstract class as well
        */
        public abstract void Draw(); // Missing implementation that must be provided in the derived classes
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }

    public enum ShapeType
    {
        Circle,
        Rectangle,
        Triangle
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var item in shapes)
            {
                /* Not using polymorphism. 
                 * If I have another shape, I must to add one more switch case 
                 * as well another enum shapeType  */

                /* Block code commented in order to use polymorph
                 *switch (item.Type)
                 *{
                 *    case ShapeType.Circle:
                 *        Console.WriteLine("Draw a Circle");
                 *        break;
                 *    case ShapeType.Rectangle:
                 *        Console.WriteLine("Draw a Rectangle");
                 *        break;
                 *    case ShapeType.Triangle:
                 *        Console.WriteLine("Draw a Triangle");
                 *        break;
                 *    default:
                 *        break;
                 *}
                */

                item.Draw();
            }
        }
    }
}