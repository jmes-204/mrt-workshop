using System;
using System.Collections.Generic;

namespace Definition
{
    public class Terminal
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
    }

    public static class TerminalManager
    {
        public static List<Terminal> InitTerminals()
        {
            List<Terminal> terminals = new List<Terminal>();
            terminals.Add(new Terminal
            {
                ID = "B9",
                Name = "พระรามเก้า",
                Position = 9
            });
            terminals.Add(new Terminal
            {
                ID = "B10",
                Name = "ศูนย์วัฒนธรรม",
                Position = 10
            });
            terminals.Add(new Terminal
            {
                ID = "B1",
                Name = "หัวลำโพง",
                Position = 1
            });
            terminals.Add(new Terminal
            {
                ID = "B3",
                Name = "สีลม",
                Position = 3
            });
            terminals.Add(new Terminal
            {
                ID = "B4",
                Name = "สีลม",
                Position = 4
            });

            return terminals;
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
            fareRates.Add(new FareRate
            {
                Distance = 2,
                Price = 19
            });
            fareRates.Add(new FareRate
            {
                Distance = 3,
                Price = 21
            });

            return fareRates;
        }
    }
}
