using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day02
{
    public class Day02Part1Test
    {
        private List<string> exmaple = new List<string> {"1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc"};
        
        [Test]
        public void ExamplePart1()
        {
            Day02Part1.Solve(exmaple).Should().Be(2);
        }

        [Test]
        public void Solution1()
        {
            var input = InputReader.ReadLines("Day02/input.txt");
            Console.WriteLine(Day02Part1.Solve(input));
        }

        [Test]
        public void ExamplePart2()
        {
            Day02Part2.Solve(exmaple).Should().Be(1);
        }
        
        [Test]
        public void Solution2()
        {
            var input = InputReader.ReadLines("Day02/input.txt");
            Console.WriteLine(Day02Part2.Solve(input));
        }
    }
}