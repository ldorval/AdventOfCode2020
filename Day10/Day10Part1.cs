using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day10
{
    public class Day10Part1
    {
        public static int Solve(List<int> input)
        {
            var adapters = input.OrderBy(x => x).ToList();
            adapters.Insert(0, 0);
            adapters.Add(adapters.Last() + 3);

            return CountDifferencesOf(1, adapters) * CountDifferencesOf(3, adapters);
        }

        private static int CountDifferencesOf(int difference, List<int> adapters)
        {
            var count = 0;
            
            for (var i = 1; i < adapters.Count; i++)
            {
                if (adapters[i] - adapters[i - 1] == difference)
                    count++;
            }

            return count;
        }
    }
}