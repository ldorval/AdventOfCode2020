using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day13
{
    public class Day13Test
    {
        [Test]
        public void ExamplePart1()
        {
            var input = new List<int> {7, 13, 59, 31, 19};
            Day13Part1.Solve(939, input).Should().Be(295);
        }

        [Test]
        public void Solution1()
        {
            var input = new List<int> {19, 41, 743, 13, 17, 29, 643, 37, 23};
            Console.WriteLine(Day13Part1.Solve(1015292, input));
        }

        [Test]
        public void ExamplePart2()
        {
            Day13Part2.Solve(new List<int> {7, 13, 0, 0, 59, 0, 31, 19}).Should().Be(1068781);
            Day13Part2.Solve(new List<int> {17, 0, 13, 19}).Should().Be(3417);
            Day13Part2.Solve(new List<int> {67, 7, 59, 61}).Should().Be(754018);
            Day13Part2.Solve(new List<int> {67, 0, 7, 59, 61}).Should().Be(779210);
            Day13Part2.Solve(new List<int> {67, 7, 0, 59, 61}).Should().Be(1261476);
            Day13Part2.Solve(new List<int> {1789, 37, 47, 1889}).Should().Be(1202161486);
        }

        [Test]
        public void Solution2()
        {
            // 1001569619313439
            var input = new List<int> {19,0,0,0,0,0,0,0,0,41,0,0,0,0,0,0,0,0,0,743,0,0,0,0,0,0,0,0,0,0,0,0,13,17,0,0,0,0,0,0,0,0,0,0,0,0,0,0,29,0,643,0,0,0,0,0,37,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,23};
            Console.WriteLine(Day13Part2.Solve(input));
        }
    }
}