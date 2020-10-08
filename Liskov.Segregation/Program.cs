using Liskov.Segregation.Customer;
using Liskov.Substitution.Customer;
using System;
using System.Collections.Generic;

namespace Liskov.Substitution
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
