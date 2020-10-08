using Liskov.Substitution.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov.Segregation.Customer
{
    public class GoldCustomer : BaseCustomer, IBonus
    {
        public double GiveBonus()
        {
            return 5;
        }

        public override string Save()
        {
            return "Save gold";
        }
    }
}
