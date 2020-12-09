using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day09
{
    public class Day09Part2
    {
        public static long Solve(List<long> input, int invalidNumber)
        {
            var matchingSumNumbers = MatchingSumNumbers(input, invalidNumber);
            return matchingSumNumbers.Min() + matchingSumNumbers.Max();
        }

        private static List<long> MatchingSumNumbers(List<long> input, in int invalidNumber)
        {
            for (var i = 0; i < input.Count; i++)
            {
                var numbers = new List<long> {input[i]};

                for (var j = i + 1; j < input.Count; j++)
                {
                    numbers.Add(input[j]);

                    if (numbers.Sum() == invalidNumber)
                        return numbers;
                }
            }

            throw new Exception("Can't solve...");
        }
    }
}