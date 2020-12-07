using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day07
{
    public class Day07Part1
    {
        private readonly IList<string> validColors = new List<string>();
        private readonly IList<Rule> rules;

        public Day07Part1(IEnumerable<string> input)
        {
            rules = input.Select(Rule.FromInput).ToList();
        }

        public int Solve()
        {
            ContainingColor("shiny gold");

            return validColors.Distinct().Count();
        }

        private void ContainingColor(string color)
        {
            rules
                .Where(x => x.Bags.Any(y => y.Color == color))
                .ToList()
                .ForEach(rule =>
                {
                    validColors.Add(rule.Color);
                    ContainingColor(rule.Color);
                });
        }
    }
}