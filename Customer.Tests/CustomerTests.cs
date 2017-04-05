using System;
using NUnit.Framework;
using SolidPrinciples;
namespace CustomerTests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test(Description="Test Regular Customer TotalSales")]
        public void TC1_RegularCustomer()
        {
            var c1 = new Customer(new EventLogger());
            Assert.AreEqual(5000, c1.getDiscount(5000));
        }
        [Test(Description = "Test Gold Customer TotalSales")]
        public void TC2_GoldCustomer()
        {
            var c1 = new GoldCustomer(new FileLogger());
            Assert.AreEqual(4900, c1.getDiscount(5000));
        }
        [Test(Description = "Test Silver Customer TotalSales")]
        public void TC3_SilverCustomer()
        {
            var c1 = new SilverCustomer(new FileLogger());
            Assert.AreEqual(4950, c1.getDiscount(5000));
        }
    }
}
