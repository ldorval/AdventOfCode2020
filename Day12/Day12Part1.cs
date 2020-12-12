using System;
using System.Collections.Generic;

namespace AdventOfCode2020.Day12
{
    public class Day12Part1
    {
        public static int Solve(List<string> instructions)
        {
            var boat = new Boat();
            instructions.ForEach(instruction => boat.ExecuteInstruction(instruction));
            return Math.Abs(boat.X) + Math.Abs(boat.Y);
        }
    }
}