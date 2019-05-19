using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Money
    {
        protected int amount;
        
        public bool equals(Money money1, Money money2)
        {
            return money1.amount == money2.amount;
        }
    }
}
