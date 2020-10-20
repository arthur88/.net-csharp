using System;

namespace helloworld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("It's me, Mario");
            System.Console.WriteLine("Hello World");

            /* ##### NO 1 #####  */
            System.Console.WriteLine("Enter your name");
            string uName = Console.ReadLine();
            Console.WriteLine("Your name is: " + uName);

            /* #### NO 2 ##### */
            Console.WriteLine("\n");
            System.Console.WriteLine("Plese enter text");
            var txt = Console.ReadLine();
            Console.WriteLine("Result: " + txt);

            /* ##### NO 3 ##### */
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter text in green line");
            Console.WriteLine("Result of input: " + Console.ReadLine());
        }
    }
}
             