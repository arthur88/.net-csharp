using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace AggregateFunctions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            var numbers = new[] { 19, 7, 3, 21 };
            var sum = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine("Sum");
            Console.WriteLine( sum);

            var words = new[] { "this", "is", "demo " };
            var csv = words.Aggregate((a, b) => a + '-' + b);
            Console.WriteLine("contact");
            Console.WriteLine(csv);

            var numbers2 = new[] { 2, 3, 4 };
            var result = numbers2.Aggregate(5, (a, b) => a * b);
            Console.WriteLine("Multiply (5, (a, b) => a * b");
            Console.WriteLine(result);

            string[] strings = "t r a m s".Split(' ');
            string reversed = strings.Aggregate((workingSentense, next) => next + " " + workingSentense);

            Console.WriteLine("reversed");
            Console.WriteLine(reversed);






        }
    }
}
