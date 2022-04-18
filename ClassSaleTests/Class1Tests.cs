using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassSale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSale.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void DiscountTest1()
        {
            int count = 3, totalCoast = 450, expected = 423;
            int actual = Class1.Discount(count, totalCoast);
            Assert.AreEqual(expected, actual);
        }
        public void DiscountTest2()
        {
            int count = 5, totalCoast = 895, expected = 805;
            int actual = Class1.Discount(count, totalCoast);
            Assert.AreEqual(expected, actual);
        }
        public void DiscountTest3()
        {
            int count = 10, totalCoast = 2000, expected = 1700;
            int actual = Class1.Discount(count, totalCoast);
            Assert.AreEqual(expected, actual);
        }
    }
}