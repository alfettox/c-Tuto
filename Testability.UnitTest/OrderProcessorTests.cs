using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testability;

namespace Testability.UnitTest
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsException()
        {
            // Arrange
            var orderProcessor = new OrderProcessor(new MockShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            // Act
            orderProcessor.Process(order);

            // Assert
            // Exception is expected, so no specific assertion needed here
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetShipmentProperties()
        {
            // Arrange
            var orderProcessor = new OrderProcessor(new MockShippingCalculator());
            var order = new Order();

            // Act
            orderProcessor.Process(order);

            // Assert
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1f, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class MockShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1f;
        }
    }
}
