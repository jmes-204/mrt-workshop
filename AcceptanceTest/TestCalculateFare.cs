using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcceptanceTest
{
    [TestClass]
    public class TestCalculateFare
    {
        [TestMethod]
        public void CalculateFare_B9_To_B10_Should_16()
        {
            string source = "B9", destination = "B10";

            int expectedFare = 16;

            Service.FareService fareService = new Service.FareService();
            int actualFare = fareService.CalculateFare(source, destination);

            Assert.AreEqual(expectedFare, actualFare);
        }
    }
}
