using CSharp.Inheritance;

namespace CSharp.Exec
{
    public class InheritanceExec : IExecutable
    {
        public void Execute()
        {
            UseCarVehicle();
            // UsePresentation();
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
    }
}