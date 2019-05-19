using System;

namespace ClassLibrary1
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            return new Money(amount, currency);
        }

        public Money times(int multiplier)
        {
            return Money.dollar(amount * multiplier);
        }
        
    }
}
