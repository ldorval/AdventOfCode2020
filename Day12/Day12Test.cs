using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day12
{
    public class Day12Test
    {
        [Test]
        public void ExamplePart1()
        {
            var input = InputReader.ReadLines("Day12/input-example.txt");
            Day12Part1.Solve(input).Should().Be(25);
        }

        [Test]
        public void Solution1()
        {
            var input = InputReader.ReadLines("Day12/input.txt");
            Console.WriteLine(Day12Part1.Solve(input));
        }
        
        [Test]
        public void ExamplePart2()
        {
            var input = InputReader.ReadLines("Day12/input-example.txt");
            Day12Part2.Solve(input).Should().Be(286);
        }
        
        [Test]
        public void Solution2()
        {
            var input = InputReader.ReadLines("Day12/input.txt");
            Console.WriteLine(Day12Part2.Solve(input));
        }
    }
}