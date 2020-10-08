using Interface.Segregation.HowNotTo;
using Interface.Segregation.HowTo;
using System;

namespace Interface.Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            IFarmer farmer = new Farmer();
            farmer.FeedAnimals();
            ILeader leader = new Leader();
            leader.Lead();

            try
            {
                IGodInterface warriorGod = new WarriorGod();
                // this will break 
                warriorGod.FeedAnimals();
                warriorGod.Lead();
                warriorGod.Swoosh();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
            }

            Console.Read();
        }
    }
}
