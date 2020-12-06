using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day06
{
    public class Day06Test
    {
        [Test]
        public void ExamplePart1()
        {
            var input = InputReader.ReadAll("Day06/input-example.txt");
            Day06Part1.Solve(input).Should().Be(11);
        }

        [Test]
        public void SolutionPart1()
        {
            var input = InputReader.ReadAll("Day06/input.txt");
            Console.WriteLine(Day06Part1.Solve(input));
        }

        [Test]
        public void ExamplePart2()
        {
            var input = InputReader.ReadAll("Day06/input-example.txt");
            Day06Part2.Solve(input).Should().Be(6);
        }

        [Test]
        public void SolutionPart2()
        {
            var input = InputReader.ReadAll("Day06/input.txt");
            Console.WriteLine(Day06Part2.Solve(input));
        }
    }
}