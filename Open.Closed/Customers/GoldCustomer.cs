using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Closed.Customers
{
    public class GoldCustomer : IBonus
    {
        public double GiveBonus()
        {
            return 20;
        }
    }
}
