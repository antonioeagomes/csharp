using System.Collections.Generic;

namespace CSharp.Classes
{
    /* 
    * Constructor overloading - Same name for different signatures
    * Good pratice is not to use so many constructors
    */
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Customer()
        {   
            this.Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            /* When this() keyword is called, the Constructor with no parameter is called first */
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            /* *
             * Same for this one and its constructor calling
             * */
            this.Name = name;
        }
    }

    public class Order {

    }

}