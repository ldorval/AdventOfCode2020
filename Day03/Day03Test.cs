using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day03
{
    public class Day03Test
    {
        private List<string> mapExample = new List<string>
        {
            "..##.......",
            "#...#...#..",
            ".#....#..#.",
            "..#.#...#.#",
            ".#...##..#.",
            "..#.##.....",
            ".#.#.#....#",
            ".#........#",
            "#.##...#...",
            "#...##....#",
            ".#..#...#.#"
        };

        [Test]
        public void ExamplePart1()
        {
            Day03.Solve(mapExample, 3, 1).Should().Be(7);
        }

        [Test]
        public void Solution1()
        {
            var map = InputReader.ReadLines("Day03/input.txt");
            Console.WriteLine(Day03.Solve(map, 3, 1));
        }

        [Test]
        public void ExamplePart2()
        {
            var result = Day03.Solve(mapExample, 1, 1) *
                         Day03.Solve(mapExample, 3, 1) *
                         Day03.Solve(mapExample, 5, 1) *
                         Day03.Solve(mapExample, 7, 1) *
                         Day03.Solve(mapExample, 1, 2);

            result.Should().Be(336);
        }

        [Test]
        public void Solution2()
        {
            var map = InputReader.ReadLines("Day03/input.txt");
            
            var result = Day03.Solve(map, 1, 1) *
                         Day03.Solve(map, 3, 1) *
                         Day03.Solve(map, 5, 1) *
                         Day03.Solve(map, 7, 1) *
                         Day03.Solve(map, 1, 2);
            
            Console.WriteLine(result);
        }
    }
}