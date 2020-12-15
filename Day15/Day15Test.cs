using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day15
{
    public class Day15Test
    {
        [Test]
        public void ExamplePart1()
        {
            var input = new List<int> {0, 3, 6};
            Day15.Solve(input, 2020).Should().Be(436);
        }

        [Test]
        public void Solution1()
        {
            var input = new List<int> {1, 12, 0, 20, 8, 16};
            Console.WriteLine(Day15.Solve(input, 2020));
        }

        [Test]
        public void Example1Part2()
        {
            var input = new List<int> {0,3,6};
            Day15.Solve(input, 30000000).Should().Be(175594);
        }
        
        [Test]
        public void Example2Part2()
        {
            var input = new List<int> {1,3,2};
            Day15.Solve(input, 30000000).Should().Be(2578);
        }
        
        [Test]
        public void Example3Part2()
        {
            var input = new List<int> {2,1,3};
            Day15.Solve(input, 30000000).Should().Be(3544142);
        }
        
        [Test]
        public void Example4Part2()
        {
            var input = new List<int> {1,2,3};
            Day15.Solve(input, 30000000).Should().Be(261214);
        }
        
        [Test]
        public void Example5Part2()
        {
            var input = new List<int> {2,3,1};
            Day15.Solve(input, 30000000).Should().Be(6895259);
        }
        
        [Test]
        public void Example6Part2()
        {
            var input = new List<int> {3,2,1};
            Day15.Solve(input, 30000000).Should().Be(18);
        }
        
        [Test]
        public void Example7Part2()
        {
            var input = new List<int> {3,1,2};
            Day15.Solve(input, 30000000).Should().Be(362);
        }

        [Test]
        public void Solution2()
        {
            var input = new List<int> {1, 12, 0, 20, 8, 16};
            Console.WriteLine(Day15.Solve(input, 30000000));
        }
    }
}