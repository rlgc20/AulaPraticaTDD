using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Money
    {
        protected int amount;
        
        public bool equals(Object object1)
        {
            Money money1 = (Money)object1;
            return amount == money1.amount && object1.GetType() == typeof(Money);
        }

        public static Dollar dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount);
        }
    }
}
