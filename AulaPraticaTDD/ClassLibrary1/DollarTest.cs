using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    [TestClass()]
    public class DollarTest
    {
        [TestMethod()]
        public void testMultiplication()
        {
            Money five = Money.dollar(5);
            Assert.AreEqual(Money.dollar(10), five.times(2));
            Assert.AreEqual(Money.dollar(15), five.times(5));
        }

        [TestMethod()]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5) == new Dollar(5));
            Assert.IsFalse(new Dollar(5) == new Dollar(6));
        }
    }
}
