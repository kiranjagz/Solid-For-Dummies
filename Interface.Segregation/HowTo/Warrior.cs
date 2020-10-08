using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Segregation.HowTo
{
    public class Warrior : IWarrior
    {
        public void Defend()
        {
            Console.WriteLine("Use a shield to defend");
        }
        public void Swoosh()
        {
            Console.WriteLine("Use a sword to attack");
        }
    }
}
