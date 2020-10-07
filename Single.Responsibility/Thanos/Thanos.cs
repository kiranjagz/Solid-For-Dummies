using System;
using System.Collections.Generic;
using System.Text;

namespace Single.Responsibility.Thanos
{
    public class Thanos : IThanos
    {
        public bool Snap()
        {
            Console.WriteLine($"Dread it. Run it. Destiny arrives all the same!");

            return true;
        }
    }
}
