using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day07
{
    public class Day07Test
    {
        [Test]
        public void Example1Part1()
        {
            var input = InputReader.ReadLines("Day07/input-example1.txt");
            new Day07Part1(input).Solve().Should().Be(4);
        }

        [Test]
        public void SolutionPart1()
        {
            var input = InputReader.ReadLines("Day07/input.txt");
            Console.WriteLine(new Day07Part1(input).Solve());
        }
        
        [Test]
        public void Example1Part2()
        {
            var input = InputReader.ReadLines("Day07/input-example1.txt");
            new Day07Part2(input).Solve().Should().Be(32);
        }
        
        [Test]
        public void Example2Part2()
        {
            var input = InputReader.ReadLines("Day07/input-example2.txt");
            new Day07Part2(input).Solve().Should().Be(126);
        }

        [Test]
        public void SolutionPart2()
        {
            var input = InputReader.ReadLines("Day07/input.txt");
            Console.WriteLine(new Day07Part2(input).Solve());
        }
    }
}