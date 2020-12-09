using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day09
{
    public class Day09Test
    {
        [Test]
        public void ExamplePart1()
        {
            var input = InputReader.ReadLinesLong("Day09/input-example.txt");
            new Day09Part1(input).Solve(5).Should().Be(127);
        }

        [Test]
        public void Solution1()
        {
            var input = InputReader.ReadLinesLong("Day09/input.txt");
            Console.WriteLine(new Day09Part1(input).Solve(25));
        }

        [Test]
        public void ExamplePart2()
        {
            var input = InputReader.ReadLinesLong("Day09/input-example.txt");
            Day09Part2.Solve(input, 127).Should().Be(62);
        }

        [Test]
        public void Solution2()
        {
            var input = InputReader.ReadLinesLong("Day09/input.txt");
            Console.WriteLine(Day09Part2.Solve(input, 22406676));
        }
    }
}