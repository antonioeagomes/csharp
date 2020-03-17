using System;
using CSharp.Classes;

namespace CSharp.Exec
{
    public class ConstructorExec: IExecutable
    {
        public void Execute(){
            var costumer = new Customer();
            Console.WriteLine($"{costumer.Id} - {costumer.Name}");

            var c = new Customer(1, "Anakin");
            Console.WriteLine($"{c.Id} - {c.Name}");

            var order = new Order();
            c.Orders.Add(order);
        }
    }
}