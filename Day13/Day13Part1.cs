using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day13
{
    public class Day13Part1
    {
        public static int Solve(int earliestDeparture, List<int> input)
        {
            return input
                .Select(x => GetBestBusDeparture(x, earliestDeparture))
                .OrderBy(x => x.Value)
                .Select(x => (x.Value - earliestDeparture) * x.Key)
                .First();
        }

        private static KeyValuePair<int, int> GetBestBusDeparture(int busId, int earliestDeparture)
        {
            var departure = 0;
            
            while (departure < earliestDeparture)
            {
                departure += busId;
            }

            return new KeyValuePair<int, int>(busId, departure);
        }
    }
}