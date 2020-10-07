using Liskov.Segregation.Customer;
using System;
using System.Collections.Generic;

namespace Liskov.Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new List<BaseCustomer> { new BlueCustomer(), new GoldCustomer() };

            customer.ForEach(customer =>
            {
                Console.WriteLine($"{customer.Save()}");
            });

            Console.Read();
        }
    }
}
