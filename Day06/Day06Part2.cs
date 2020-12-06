using System;
using System.Linq;

namespace AdventOfCode2020.Day06
{
    public class Day06Part2
    {
        public static int Solve(string input)
        {
            return input
                .Split($"{Environment.NewLine}{Environment.NewLine}")
                .Select(x => x.Split(Environment.NewLine))
                .Sum(group =>
                {
                    var count = 0;
                    
                    for (var c = 'a'; c <= 'z'; c++)
                    {
                        if (group.All(x => x.Contains(c)))
                            count++;
                    }

                    return count;
                });
        }
    }
}