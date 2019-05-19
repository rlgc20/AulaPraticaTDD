using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc times(int multiplier)
        {
            amount = amount * multiplier;
            return new Franc(amount);
        }

    }
}
