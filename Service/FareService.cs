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

            sourcePosition = getPostionByTerminalId(source);
            destinationPosition = getPostionByTerminalId(destination);
            if (sourcePosition == -1 || destinationPosition == -1)
            {
                return 0;
            }
            
            distance = Math.Abs(destinationPosition - sourcePosition);

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

        private int getPostionByTerminalId(string terminalId)
        {
            List<Terminal> destinations = TerminalManager.InitTerminals();
            foreach (var item in destinations)
            {
                if (item.ID == terminalId)
                {
                    return item.Position;
                }
            }

            return -1;
        }
    }
}
