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
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.AreEqual(new Dollar(10), five.times(2));
            Assert.AreEqual(new Dollar(15), five.times(5));
        }

        [TestMethod()]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5) == new Dollar(5));
            Assert.IsFalse(new Dollar(5) == new Dollar(6));

        }
    }
}
