using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Segregation.HowNotTo
{
    // The class is implemented logic it does not need
    public class WarriorGod : IGodInterface
    {
        public void Defend()
        {
            Console.WriteLine("Use a shield to defend");
        }

        public void FeedAnimals()
        {
            throw new NotImplementedException();
        }

        public void Lead()
        {
            throw new NotImplementedException();
        }

        public void PlantSeeds()
        {
            throw new NotImplementedException();
        }

        public void Swoosh()
        {
            Console.WriteLine("Use a sword to attack");
        }
    }
}
