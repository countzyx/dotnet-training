using System;
using System.Web.Mvc;

using NUnit.Framework;
using MVCUnitTesting.Controllers;

namespace MVCUnitTesting.Tests {
    [TestFixture]
    public class CustomerUnitTests {
        [Test]
        public void Customer_Index_Returns_ActionResult() {
            // Arrange
            CustomerController oController = new CustomerController();

            // Act
            var oActual = oController.Index();

            // Assert
            Assert.IsInstanceOf<ActionResult>(oActual);
        }
    }
}
