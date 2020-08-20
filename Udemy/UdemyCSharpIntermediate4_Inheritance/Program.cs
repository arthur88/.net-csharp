using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Amazon;

namespace UdemyCSharpIntermediate4_Inheritance
{

    class Program
    {

        static void Main()
        {
            Console.WriteLine("Hello World!");

            //access modifiers
            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();

            //constructors and inheritance
            var car = new Car("XYZ1234");

           //upcasting and downcasting `AS` and `IS`
           // Text text = new Text();
           // Shape shape = text;
           // text.Width = 200;
           // shape.Width = 100;
           // Console.WriteLine(text.Width);

            StreamReader reader = new StreamReader(new MemoryStream());

            //upcasting
            /* var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());
            var anotherList = new List<Shape>(); */

            //downcasting
            Shape shape = new Text();
            Text text = (Text)shape;

            //Boxing / Unboxing
            var list = new ArrayList();
            list.Add(1);
            list.Add("Art");
            list.Add(DateTime.Today);

            var number = (int)list[1];
            var anotherList = new List<int>();
            var names = new List<string>();

            names.Add("Art");
            anotherList.Add(0);



        }
    }
}
