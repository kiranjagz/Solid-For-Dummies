using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Closed.Customers
{
    public class BlueCustomer : IBonus
    {
        public double GiveBonus()
        {
            return 10;
        }
    }
}
