using System.Collections.Generic;
using CSharp.Poly;

namespace CSharp.Exec
{
    public class PolymorphExec: IExecutable
    {
        public void Execute()
        {
            UseDrawShapes();
        }

        public void UseDrawShapes(){
            var canvas = new Canvas();
            var listOfShapes = new List<Shape>();

            listOfShapes.Add(new Circle());
            listOfShapes.Add(new Rectangle());
            listOfShapes.Add(new Triangle());
            canvas.DrawShapes(listOfShapes);
        }
    }
}