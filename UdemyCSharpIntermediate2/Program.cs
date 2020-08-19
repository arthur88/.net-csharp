using System;

namespace UdemyCSharpIntermediate2
{

    class Program
    {

        public class PersonProperties
        {
            public DateTime Birthgdate { get; set;  }
        }

        static void Main()
        {
            Console.WriteLine("Hello World!");

            //readonly
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote(); //reset field

            Console.WriteLine(customer.Orders.Count);

            var person = new Person(new DateTime(1988,2,1));
        
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetBirthdate());


        }
    }
}
