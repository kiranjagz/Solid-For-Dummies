using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Segregation.HowTo
{
    public class Leader : ILeader
    {
        public void Lead()
        {
            Console.WriteLine("Lead with love!");
        }
    }
}
