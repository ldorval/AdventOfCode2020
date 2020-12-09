using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day09
{
    public class Day09Part1
    {
        private readonly List<long> input;

        public Day09Part1(List<long> input)
        {
            this.input = input;
        }
        
        public long Solve(int preamble)
        {
            for (var i = preamble; i < input.Count; i++)
            {
                var possibleSums = GetPossibleSums(i, preamble);
                if (!possibleSums.Contains(input[i]))
                    return input[i];
            }

            throw new Exception("Can't solve...");
        }

        private IEnumerable<long> GetPossibleSums(int index, int preamble)
        {
            for (var i = index - preamble; i < index; i++)
            {
                for (var j = index - preamble; j < index; j++)
                {
                    if (i != j) yield return input[i] + input[j];
                }
            }
        }
    }
}