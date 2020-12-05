using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day05
{
    public class Day05Test
    {
        [Test]
        public void ExamplePart1()
        {
            Day05.GetSeatId("BFFFBBFRRR").Should().Be(567);
            Day05.GetSeatId("FFFBBBFRRR").Should().Be(119);
            Day05.GetSeatId("BBFFBBFRLL").Should().Be(820);
        }

        [Test]
        public void Solution1()
        {
            var boardingPasses = InputReader.ReadLines("Day05/input.txt");
            Console.WriteLine(Day05.SolvePart1(boardingPasses));
        }
        
        [Test]
        public void Solution2()
        {
            var boardingPasses = InputReader.ReadLines("Day05/input.txt");
            Console.WriteLine(Day05.SolvePart2(boardingPasses));
        }
    }
}