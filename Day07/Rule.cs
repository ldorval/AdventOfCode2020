using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day07
{
    public class Rule
    {
        public string Color { get; set; }
        public IList<ContainingBag> Bags { get; set; }

        public static Rule FromInput(string input)
        {
            var parts = input.Trim('.').Split(" bags contain ");
            var color = parts[0];
            var containingColors = parts[1].Replace(" bags", "").Replace(" bag", "").Split(", ");
            
            return new Rule
            {
                Color = color,
                Bags = containingColors
                    .Where(x => !x.Contains("no other"))
                    .Select(x => new ContainingBag { Count = Convert.ToInt32(x.Substring(0, 1)), Color = x.Substring(2, x.Length - 2)}).ToList()
            };
        }
    }
}