using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day08
{
    public class Day08Test
    {
        [Test]
        public void ExamplePart1()
        {
            var input = InputReader.ReadLines("Day08/input-example.txt");
            new Day08Part1(input).Solve().Should().Be(5);
        }

        [Test]
        public void Solution1()
        {
            var input = InputReader.ReadLines("Day08/input.txt");
            Console.WriteLine(new Day08Part1(input).Solve());
        }

        [Test]
        public void ExamplePart2()
        {
            var input = InputReader.ReadLines("Day08/input.txt");
            Console.WriteLine(Day08Part2.Solve(input));
        }
        
        [Test]
        public void Solution2()
        {
            var input = InputReader.ReadLines("Day08/input.txt");
            Console.WriteLine(Day08Part2.Solve(input));
        }
    }
}