using System;
using System.Linq;

namespace AdventOfCode2020.Day06
{
    public class Day06Part1
    {
        public static int Solve(string input)
        {
            return input
                .Split($"{Environment.NewLine}{Environment.NewLine}")
                .SelectMany(x => x.Distinct())
                .Count(x => x != '\r' && x != '\n');
        }
    }
}