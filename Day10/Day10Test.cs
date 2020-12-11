using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day10
{
    public class Day10Test
    {
        [Test]
        public void Example1Part1()
        {
            var input = InputReader.ReadLinesInt("Day10/input-example1.txt");
            Day10Part1.Solve(input).Should().Be(35);
        }
        
        [Test]
        public void Example2Part1()
        {
            var input = InputReader.ReadLinesInt("Day10/input-example2.txt");
            Day10Part1.Solve(input).Should().Be(220);
        }

        [Test]
        public void Solution1()
        {
            var input = InputReader.ReadLinesInt("Day10/input.txt");
            Console.WriteLine(Day10Part1.Solve(input));
        }

        [Test]
        public void Example1Part2()
        {
            var input = InputReader.ReadLinesInt("Day10/input-example1.txt");
            Day10Part2.Solve(input).Should().Be(8);
        }
        
        [Test]
        public void Example2Part2()
        {
            var input = InputReader.ReadLinesInt("Day10/input-example2.txt");
            Day10Part2.Solve(input).Should().Be(19208);
        }
        
        [Test]
        public void Solution2()
        {
            //2644613988352
            var input = InputReader.ReadLinesInt("Day10/input.txt");
            Console.WriteLine(Day10Part2.Solve(input));
        }
    }
}