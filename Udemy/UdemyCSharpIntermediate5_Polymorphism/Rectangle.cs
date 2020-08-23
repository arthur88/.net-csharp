using System;

namespace UdemyCSharpIntermediate5_Polymorphism
{
    partial class Program
    {
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a rectangle");
            }
        }
    }
}
