using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day01
{
    public class Day01Test
    {
        private List<int> expenses = new List<int> {1721, 979, 366, 299, 675, 1456};

        [Test]
        public void ExamplePart1()
        {
            Day01Part1.Solve(expenses).Should().Be(514579);
        }

        [Test]
        public void SolutionPart1()
        {
            var input = InputReader.ReadLinesInt("Day01/input.txt");
            Console.WriteLine(Day01Part1.Solve(input));
        }
        
        [Test]
        public void ExamplePart2()
        {
            Day01Part2.Solve(expenses).Should().Be(241861950);
        }
        
        [Test]
        public void SolutionPart2()
        {
            var input = InputReader.ReadLinesInt("Day01/input.txt");
            Console.WriteLine(Day01Part2.Solve(input));
        }
    }
}