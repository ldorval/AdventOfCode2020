using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day06
{
    public class Day06Part2
    {
        private static readonly IList<char> Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public static int Solve(string input)
        {
            return input
                .Split($"{Environment.NewLine}{Environment.NewLine}")
                .Select(x => x.Split(Environment.NewLine))
                .Sum(group => Alphabet.Count(a => group.All(g => g.Contains(a))));
        }
    }
}