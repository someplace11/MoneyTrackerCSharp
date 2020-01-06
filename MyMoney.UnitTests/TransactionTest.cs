using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyTracker;

namespace MyMoney.UnitTests
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void ConvertCard_TrueTryCard_ReturnTrue()
        {
            // Arrange
            int expected = 4849;
            string input = "4849";

            // Act
            int actual = Transaction.ConvertCard(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
