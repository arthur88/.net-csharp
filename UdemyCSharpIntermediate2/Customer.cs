using System.Collections.Generic;

namespace UdemyCSharpIntermediate2
{
    public class Customer
    {
        public int Id;
        public string name;
        public readonly List<Order> Orders = new List<Order>();

        /* public Customer() //alternative way
        {
            Orders = new List<Order>();
        } */

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.name = name;
        }

        public void Promote()
        {
            // .... 
        }
    }
}
