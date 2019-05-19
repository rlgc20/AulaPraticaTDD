using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Money
    {
        protected int amount;
        protected string currency;
        
        public bool equals(Object object1)
        {
            Money money1 = (Money)object1;
            return amount == money1.amount && object1.GetType() == typeof(Money);
        }

        public static Dollar dollar(int amount, string currency)
        {
            return new Dollar(amount, currency);
        }

        public static Franc franc(int amount, string currency)
        {
            return new Franc(amount, currency);
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
    }
}
