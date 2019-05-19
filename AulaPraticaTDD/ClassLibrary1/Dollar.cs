using System;

namespace ClassLibrary1
{
    public class Dollar : Money
    {
       
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar times(int multiplier)
        {
            amount = amount * multiplier;
            return new Dollar(amount);
        }
    }
}
