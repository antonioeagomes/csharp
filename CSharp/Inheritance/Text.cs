using System;

namespace CSharp.Inheritance
{
    /* Text inherits from PresentationObject */
    /* Relationship: Is-A: Text is a PresentationObject */
    public class Text : PresentationObject
    {
        public Text()
        {
            Console.WriteLine("Constructor of  Text class");
        }

        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url){
            Console.WriteLine($"A hyperlink was added to {url}");
        }
    }
}