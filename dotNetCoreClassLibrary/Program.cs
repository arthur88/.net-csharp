using System;

using MCMathLib;

namespace dotNetCoreClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter Number 1:");
            var var1 = Console.ReadLine();
            int num1 = Convert.ToInt32(var1);

            Console.Write("Enter Number 2:");
            var var2 = Console.ReadLine();
            var num2 = Convert.ToInt32(var2);

            Console.Write("Enter one Operator(Add/Sub/Mul/Div): ");
            var op = Console.ReadLine();


            MathClass math = new MathClass();
            double result = math.Calculate(num1, num2, op);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("Press any key to exit....");
            Console.ReadKey(true);

        }
    }
}
