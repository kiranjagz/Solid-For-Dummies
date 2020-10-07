using Open.Closed.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Closed.Incorrect
{
    public class CalculationForAll
    {
        public double CalculateBonus(object[] players)
        {
            var bonus = 0;

            // you need to keep extending here for a new player
            foreach(var player in players)
            {
                if (player is GoldCustomer)
                {
                    bonus = 20;
                }
                else if (player is BlueCustomer)
                {
                    bonus = 10;
                }
                else
                {
                    bonus = 1;
                }
            }

            return bonus;
        }
    }
}
