using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day11
{
    public class Day11Test
    {
        [Test]
        public void ExamplePart1()
        {
            var input = InputReader.ReadLines("Day11/input-example.txt");
            new Day11Part1().Solve(input).Should().Be(37);
        }

        [Test]
        public void SolutionPart1()
        {
            var input = InputReader.ReadLines("Day11/input.txt");
            Console.WriteLine(new Day11Part1().Solve(input));
        }
        
        [Test]
        public void ExamplePart2()
        {
            var input = InputReader.ReadLines("Day11/input-example.txt");
            new Day11Part2().Solve(input).Should().Be(26);
        }
        
        [Test]
        public void SolutionPart2()
        {
            var input = InputReader.ReadLines("Day11/input.txt");
            Console.WriteLine(new Day11Part2().Solve(input));
        }
    }
}