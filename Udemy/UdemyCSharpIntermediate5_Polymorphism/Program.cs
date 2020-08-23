using System;

namespace UdemyCSharpIntermediate5_Polymorphism
{
    partial class Program
    {

        static void Main()
        {
            Console.WriteLine("Hello World!");

            //Abstract classes and members
           // var shape = new Shape(); //abstract classes do not have instances so not possible to initiate

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
