using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Segregation.HowTo
{
    public class Farmer : IFarmer
    {
        public void FeedAnimals()
        {
            Console.WriteLine("Feed dog, cow, and bear!");
        }

        public void PlantSeeds()
        {
            Console.WriteLine("Plant some trees!");
        }
    }
}
