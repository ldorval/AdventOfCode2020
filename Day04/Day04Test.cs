using System;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day04
{
    public class Day04Test
    {
        [Test]
        public void Day04Part1Test()
        {
            var passports = InputReader.ReadAll("Day04/input-example.txt");
            Day04Part1.Solve(passports).Should().Be(2);
        }

        [Test]
        public void Solution1()
        {
            var passports = InputReader.ReadAll("Day04/input.txt");
            Console.WriteLine(Day04Part1.Solve(passports));
        }

        [Test]
        public void Day04Part2AllInvalid()
        {
            var passports = InputReader.ReadAll("Day04/input-example-all-invalide.txt");
            Day04Part2.Solve(passports).Should().Be(0);
        }
        
        [Test]
        public void Day04Part2AllValid()
        {
            var passports = InputReader.ReadAll("Day04/input-example-all-valide.txt");
            Day04Part2.Solve(passports).Should().Be(4);
        }

        [Test]
        public void Solution2()
        {
            var passports = InputReader.ReadAll("Day04/input.txt");
            Console.WriteLine(Day04Part2.Solve(passports));
        }
    }
}