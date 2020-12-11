using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day10
{
    public class Day10Part2
    {
        public static long Solve(List<int> input)
        {
            var adapters = input.OrderBy(x => x).ToList();
            adapters.Insert(0, 0);
            adapters.Add(adapters.Last() + 3);

            var paths = new List<long> {1};

            for (var i = 1; i < adapters.Count; i++)
            {
                var pathCount = 0L;
                for (var j = i - 1; j >= 0; j--)
                {
                    if (adapters[i] - adapters[j] <= 3)
                        pathCount += paths[j];
                    else
                        break;
                }
                
                paths.Add(pathCount);
            }

            return paths.Last();
        }
    }
}