using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmmettNolan_S00188098;

namespace PhoneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Phone phone1 = new Phone();
            double price = 550;

            //Act
            phone1.IncreasePrice(500);

            //Assert
            Assert.AreEqual(price, phone1.Price);
        }
    }
}
