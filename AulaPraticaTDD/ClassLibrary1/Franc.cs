using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            return new Money(amount, currency);
        }

        public Money times(int multiplier)
        {
            return Money.franc(amount * multiplier);
        }

    }
}
