using System;
using System.Collections.Generic;

namespace Definition
{
    public class Destination
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
    }

    public static class DestinationManager
    {
        public static List<Destination> InitDestinations()
        {
            List<Destination> destinations = new List<Destination>();
            destinations.Add(new Destination
            {
                ID = "B9",
                Name = "พระรามเก้า",
                Position = 9
            });
            destinations.Add(new Destination
            {
                ID = "B10",
                Name = "ศูนย์วัฒนธรรม",
                Position = 10
            });

            return destinations;
        }
    }

    public class FareRate
    {
        public int Distance { get; set; }
        public int Price { get; set; }
    }

    public static class FareRateManager
    {
        public static List<FareRate> InitFareRates()
        {
            List<FareRate> fareRates = new List<FareRate>();
            fareRates.Add(new FareRate
            {
                Distance = 1,
                Price = 16
            });

            return fareRates;
        }
    }
}
