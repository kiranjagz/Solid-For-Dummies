using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov.Substitution.Customer
{
    public class BlueCustomer : BaseCustomer
    {
        public override string Save()
        {
            return "Save blue";
        }
    }
}
