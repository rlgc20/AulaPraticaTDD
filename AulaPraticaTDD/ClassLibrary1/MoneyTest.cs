﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.IsTrue(Money.dollar(5) == Money.dollar(5));
            Assert.IsFalse(Money.dollar(5) == Money.dollar(6));
            Assert.IsTrue(Money.franc(5) == Money.franc(5));
            Assert.IsFalse(Money.franc(5) == Money.franc(5));
            Assert.AreNotEqual(Money.franc(5), Money.dollar(5));
        }

    }
}
