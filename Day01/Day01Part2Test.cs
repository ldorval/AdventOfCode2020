﻿using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day01
{
    public class Day01Part2Test
    {
        private List<int> expenses = new List<int> {1721, 979, 366, 299, 675, 1456};

        [Test]
        public void Example1()
        {
            Day01Part2.Solve(expenses).Should().Be(241861950);
        }
        
        [Test]
        public void Solution()
        {
            var input = InputReader.ReadLinesInt("Day01/input.txt");
            Console.WriteLine(Day01Part2.Solve(input));
        }
    }
}