using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTestProject
{
    [TestClass]
    public class LemonadeStandTest

    {
        [TestMethod]
        public void Setprice()
        {
            UserInput userinput = new UserInput();
            //Arrange
            double price = 1.50;
            double result;
            //Act
            result = userinput.SetPrice();
            //Assert
            Assert.AreEqual(price, result);

        }
        [TestMethod]
        public void TestPrice()
        {
            UserInput userinput = new UserInput();
            //Arrange
            double price = 500;
            double result;
            //Act
            result = userinput.SetPrice();
            //Assert
            Assert.AreEqual(price, result);

        }
        [TestMethod]
        public void TestSetPrice()
        {
            UserInput userinput = new UserInput();
            //Arrange
            double price = 0.00;
            double result;
            //Act
            result = userinput.SetPrice();
            //Assert
            Assert.AreEqual(price, result);
        }
        [TestMethod]
        public void NewTest()
        {

        }
    }
}
