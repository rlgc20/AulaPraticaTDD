using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Money
    {
        protected int amount;
        protected string currency;
        
        public bool equals(Object object1)
        {
            Money money1 = (Money)object1;
            return amount == money1.amount && money1.currency == currency;
        }

        public static Money dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public string Currency()
        {
            return currency;
        }
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }
    }
}
