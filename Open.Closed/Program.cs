using Open.Closed.Customers;
using System;
using System.Collections.Generic;

namespace Open.Closed
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new List<IBonus> { new GoldCustomer(), new BlueCustomer() };

            players.ForEach(player =>
            {
                Console.WriteLine($"Customer discount for customer type: {player.GetType().Name} is {player.GiveBonus()}");
            });

            Console.Read();
        }
    }
}
