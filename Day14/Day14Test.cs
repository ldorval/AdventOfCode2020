using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day14
{
    public class Day14Test
    {
        [Test]
        public void ExamplePart1()
        {
            var input = InputReader.ReadLines("Day14/input-example1.txt");
            Day14.SolveV1(input).Should().Be(165);
        }

        [Test]
        public void AppliesMaskV1()
        {
            Day14.ApplyMask("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X", "000000000000000000000000000000001011", 'X')
                .Should().Be("000000000000000000000000000001001001");
        }

        [Test]
        public void Solution1()
        {
            var input = InputReader.ReadLines("Day14/input.txt");
            Console.WriteLine(Day14.SolveV1(input));
        }

        [Test]
        public void ExamplePart2()
        {
            var input = InputReader.ReadLines("Day14/input-example2.txt");
            Day14.SolveV2(input).Should().Be(208);
        }

        [Test]
        public void AppliesMaskV2()
        {
            Day14.ApplyMask("00000000000000000000000000000000X0XX", "000000000000000000000000000000011010", '0')
                .Should().Be("00000000000000000000000000000001X0XX");
        }

        [Test]
        public void GeneratesAllPossibilitiesExample1()
        {
            Day14.PossibleValues = new List<long>();
            Day14.AllPossibleValues("000000000000000000000000000000X1101X");
            Day14.PossibleValues.Should().BeEquivalentTo(26, 27, 58, 59);
        }

        [Test]
        public void GeneratesAllPossibilitiesExample2()
        {
            Day14.PossibleValues = new List<long>();
            Day14.AllPossibleValues("00000000000000000000000000000001X0XX");
            Day14.PossibleValues.Should().BeEquivalentTo(16, 17, 18, 19, 24, 25, 26, 27);
        }

        [Test]
        public void Solution2()
        {
            var input = InputReader.ReadLines("Day14/input.txt");
            Console.WriteLine(Day14.SolveV2(input));
        }
    }
}