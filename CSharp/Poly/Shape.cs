using System;
using System.Collections.Generic;

namespace CSharp.Poly
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public float Area { get; set; }
        public ShapeType Type { get; set; }
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
                switch (item.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a Circle");
                        break;
                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a Rectangle");
                        break;
                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a Triangle");
                        break;
                    default:
                        break;
                }

            }
        }
    }
}