using System;
using System.Collections.Generic;

namespace CSharp.Classes
{
    public class Order
    {
        /*  Readonly fields
         *  Make sure that the fild is initialized at the constructor or at declaration 
         */
         public int Id { get; set; }
         public DateTime OrderDate { get; set; }
        List<Product> Products;
        // readonly List<Product> Products = new List<Product>();

        public Order() {
            Products = new List<Product>();
        }
    }

    public class Product {

    }
}