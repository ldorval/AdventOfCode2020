using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day07
{
    public class Day07Part2
    {
        private readonly IList<Rule> rules;
        private long count = 0;

        public Day07Part2(IEnumerable<string> input)
        {
            rules = input.Select(Rule.FromInput).ToList();
        }

        public long Solve()
        {
            CountBags("shiny gold", 1);
            
            return count;
        }

        private void CountBags(string color, int colorCount)
        {
            rules
                .Where(x => x.Color == color)
                .ToList()
                .ForEach(rule =>
                {
                    count += rule.Bags.Sum(x => x.Count * colorCount);
                    foreach (var bag in rule.Bags)
                    {
                        CountBags(bag.Color, bag.Count * colorCount);
                    }
                });
        }
    }
}