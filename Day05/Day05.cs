using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day05
{
    public class Day05
    {
        public static double SolvePart1(IList<string> boardingPasses)
        {
            return boardingPasses.Select(GetSeatId)
                .OrderByDescending(x => x)
                .First();
        }
        
        public static double SolvePart2(IList<string> boardingPasses)
        {
            var passesId = boardingPasses.Select(GetSeatId).OrderBy(x => x).ToList();
            
            for (var i = 0; i < passesId.Count - 1; i++)
            {
                if (passesId[i + 1] - passesId[i] == 2)
                    return passesId[i] + 1;
            }

            return 0;
        }
        
        public static double GetSeatId(string boardingPass)
        {
            var row = GetPosition(boardingPass.Substring(0, 7), 0, 127, 'F');
            var column = GetPosition(boardingPass.Substring(7, 3), 0, 7, 'L');
            return row * 8 + column;
        }

        private static double GetPosition(string partition, double minIndex, double maxIndex, char front)
        {
            for (var i = 0; i < partition.Length - 1; i++)
            {
                if (partition[i] == front)
                    maxIndex -= Math.Ceiling((maxIndex - minIndex) / 2.0);
                else
                    minIndex += Math.Ceiling((maxIndex - minIndex) / 2.0);
            }

            return partition[^1] == front ? minIndex : maxIndex;
        }
    }
}