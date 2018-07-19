using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcceptanceTest
{
    [TestClass]
    public class TestCalculateFare
    {
        [TestMethod]
        public void CalculateFare_B9_To_B10_Should_Return_16()
        {
            string source = "B9", destination = "B10";

            int expectedFare = 16;

            Service.FareService fareService = new Service.FareService();
            int actualFare = fareService.CalculateFare(source, destination);

            Assert.AreEqual(expectedFare, actualFare);
        }

        [TestMethod]
        public void CalculateFare_B1_To_B3_Should_Return_19()
        {
            string source = "B1", destination = "B3";

            int expectedFare = 19;

            Service.FareService fareService = new Service.FareService();
            int actualFare = fareService.CalculateFare(source, destination);

            Assert.AreEqual(expectedFare, actualFare);
        }

        [TestMethod]
        public void CalculateFare_B1_To_B4_Should_Return_21()
        {
            string source = "B1", destination = "B4";

            int expectedFare = 21;

            Service.FareService fareService = new Service.FareService();
            int actualFare = fareService.CalculateFare(source, destination);

            Assert.AreEqual(expectedFare, actualFare);
        }

        [TestMethod]
        public void CalculateFare_BB_To_B10_Should_Return_0()
        {
            string source = "BB", destination = "B10";

            int expectedFare = 0;

            Service.FareService fareService = new Service.FareService();
            int actualFare = fareService.CalculateFare(source, destination);

            Assert.AreEqual(expectedFare, actualFare);
        }
    }
}
