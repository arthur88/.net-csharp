using System;

namespace UdemyCSharpIntermediate4_Inheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        /* public Vehicle()
        {
            Console.WriteLine("Vehicle has been initiated");
        } */

        public Vehicle(string registrationNumber)
        {
           _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle has been inisitalized. {0}", registrationNumber);
        }
    }
}
