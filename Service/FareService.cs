using System;
using System.Collections.Generic;
using Definition;

namespace Service
{
    public class FareService
    {
        public int CalculateFare(string source, string destination)
        {
            int destinationPosition = 0;
            int sourcePosition = 0;
            int distance = 0;

            List<Destination> destinations = DestinationManager.InitDestinations();
            foreach (var item in destinations)
            {
                if (item.ID == source)
                {
                    sourcePosition = item.Position;
                }
                if (item.ID == destination)
                {
                    destinationPosition = item.Position;
                }
            }
            distance = (destinationPosition - sourcePosition);
            if (distance < 0)
            {
                distance = distance * -1;
            }
            List<FareRate> fareRate = FareRateManager.InitFareRates();
            foreach (var item in fareRate)
            {
                if (item.Distance == distance)
                {
                    return item.Price;
                }
            }

            return 0;
        }
    }
}
