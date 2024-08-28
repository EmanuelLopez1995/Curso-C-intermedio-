using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var costumer = new Customer(1);
            costumer.Orders.Add(new Order());
            costumer.Orders.Add(new Order());
            Console.WriteLine(costumer.Orders.Count);
        }
    }
}
