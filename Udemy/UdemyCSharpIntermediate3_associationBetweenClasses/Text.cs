using System;

namespace UdemyCSharpIntermediate3_associationBetweenClasses
{
    public class Text: PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperlink( string url)
        {
            Console.WriteLine("we added a link to " + url);
        }
    }
}
