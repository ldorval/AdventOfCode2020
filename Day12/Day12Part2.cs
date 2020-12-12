using System;
using System.Collections.Generic;

namespace AdventOfCode2020.Day12
{
    public class Day12Part2
    {
        public static int Solve(List<string> instructions)
        {
            var boat = new Boat2();
            instructions.ForEach(instruction => boat.ExecuteInstruction(instruction));
            return Math.Abs(boat.BoatX) + Math.Abs(boat.BoatY);
        }
    }
}