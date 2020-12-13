using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day13
{
    public class Day13Part2
    {
        public static long Solve(List<int> input)
        {
            var multiple = 1L;
            var multiplier = 1L;

            input
                .Select((id, index) => new KeyValuePair<int, int>(id, index))
                .Where(bus => bus.Key != 0)
                .ToList()
                .ForEach(bus =>
                {
                    multiple = FindMultiple(multiple, multiplier, bus);
                    multiplier *= bus.Key;
                });

            return multiple;
        }

        private static long FindMultiple(long multiple, long multiplier, KeyValuePair<int, int> bus)
        {
            while ((multiple + bus.Value) % bus.Key != 0)
            {
                multiple += multiplier;
            }

            return multiple;
        }
    }
}