using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RDA.AutoRepair.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Customer c = new Customer();

            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void FirstNameTest()
        {
            Customer c = new Customer();
            c.FirstName = "Ryan";
            Assert.AreEqual(c.FirstName, "Ryan");            
        }
    }
}
