using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    [TestClass()]
    public class FrancTest
    {
        [TestMethod()]
        public void testFrancMultiplication()
        {
            Money five = Money.franc(5);
            Assert.AreEqual(Money.franc(10), five.times(2));
            Assert.AreEqual(Money.franc(15), five.times(5));
        }
    }
}
