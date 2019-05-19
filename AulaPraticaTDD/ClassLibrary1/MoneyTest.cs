using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    [TestClass()]
    public class MoneyTest
    {
        [TestMethod()]
        public void testEquality()
        {
            Assert.AreEqual(Money.dollar(5), Money.dollar(5));
            Assert.AreEqual(Money.franc(5), Money.dollar(5));
            Assert.AreNotEqual(Money.dollar(5), Money.dollar(6));
            Assert.AreNotEqual(Money.franc(5), Money.dollar(5));
        }

        [TestMethod()]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.dollar(1).Currency());
            Assert.AreEqual("CHF", Money.franc(1).Currency());
        }

    }
}
