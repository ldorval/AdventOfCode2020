using System.Collections.Generic;
using System.Drawing;

namespace AdventOfCode2020.Day03
{
    public class Day03
    {
        public static long Solve(List<string> map, int xDisplacement, int yDisplacement)
        {
            var coordinate = new Point(0, 0);
            var treesCrossed = 0;

            while (coordinate.Y < map.Count)
            {
                if (map[coordinate.Y][coordinate.X] == '#')
                    treesCrossed++;
                
                coordinate.X = CalculateX(coordinate.X, map[coordinate.Y].Length, xDisplacement);
                coordinate.Y += yDisplacement;
            } 

            return treesCrossed;
        }

        private static int CalculateX(int x, int lineLength, int xDisplacement)
        {
            var newX = x + xDisplacement;
            return newX >= lineLength ? newX - lineLength : newX;
        }
    }
}