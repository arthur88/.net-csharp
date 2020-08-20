using System;
using System.ComponentModel;

namespace UdemyCSharpIntermediate
{
    partial class Program
    {
        //classes
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, Name);

            }

            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;

                return person;
            }
        }



        static void Main(string[] args)
        {
            var person = Person.Parse("John");
            person.Introduce("Mosh");

            //Constructor
            var customer = new Customer(1, "John");
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

           // var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);

            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

            static void usePoints()
            {

                //Overloads
                try
                {
                    var point = new Point(10, 20);

                    point.Move(null);
                    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                    point.Move(100, 200);
                    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                }
                catch (Exception)
                {
                    Console.WriteLine("An exception handling error occured");
                }
            }

        }
    }
