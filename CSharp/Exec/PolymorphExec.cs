using System.Collections.Generic;
using CSharp.Poly;

namespace CSharp.Exec
{
    public class PolymorphExec: IExecutable
    {
        public void Execute()
        {
            // UseDrawShapes();
            UseDbConnection();
        }

        public void UseDrawShapes(){
            var canvas = new Canvas();
            var listOfShapes = new List<Shape>();

            listOfShapes.Add(new Circle());
            listOfShapes.Add(new Rectangle());
            listOfShapes.Add(new Triangle());
            canvas.DrawShapes(listOfShapes);
        }
    
        public void UseDbConnection() {
            var sqlserver = new SQLServerConnection("database=bd;uid=root;pwd=pass");
            sqlserver.Open();
            sqlserver.Close();
            var orcale = new OracleConnection("a random connection string for oracle");
            orcale.Open();
            orcale.Close();
        }
    
    }
}