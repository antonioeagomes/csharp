using CSharp.Inheritance;

namespace CSharp.Exec
{
    public class InheritanceExec : IExecutable
    {
        public void Execute()
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