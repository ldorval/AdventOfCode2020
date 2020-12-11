using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day11
{
    public class Day11Part2
    {
        public int Solve(List<string> input)
        {
            List<string> seats = input;
            var previousCount = 0;

            while (true)
            {
                seats = SeatingRound(seats);
                var count = seats.SelectMany(x => x.ToCharArray()).Count(x => x == '#');

                if (count == previousCount)
                    return count;

                previousCount = count;
            }
        }

        private List<string> SeatingRound(List<string> seats)
        {
            var newSeats = new List<string>();

            for (var y = 0; y < seats.Count; y++)
            {
                newSeats.Add("");
                for (var x = 0; x < seats[y].Length; x++)
                {
                    var occupiedAdjacentSeats = CountOccupiedAdjacentSeats(x, y, seats);

                    if (seats[y][x] == 'L' && occupiedAdjacentSeats == 0)
                        newSeats[y] += '#';
                    else if (seats[y][x] == '#' && occupiedAdjacentSeats >= 5)
                        newSeats[y] += 'L';
                    else
                        newSeats[y] += seats[y][x];
                }
            }

            return newSeats;
        }

        private int CountOccupiedAdjacentSeats(in int x, in int y, List<string> seats)
        {
            return Seated(x, -1, y, -1, seats) +
                   Seated(x, -1, y, 0, seats) +
                   Seated(x, -1, y, 1, seats) +
                   Seated(x, 0, y, -1, seats) +
                   Seated(x, 0, y, 1, seats) +
                   Seated(x, 1, y, -1, seats) +
                   Seated(x, 1, y, 0, seats) +
                   Seated(x, +1, y, +1, seats);
        }

        private int Seated(int x, int xModifier, int y, int yModifier, List<string> seats)
        {
            var modX = x + xModifier;
            var modY = y + yModifier;
            
            if (modY < 0 || modY >= seats.Count || modX < 0 || modX >= seats[modY].Length)
                return 0;

            if (seats[modY][modX] == 'L' || seats[modY][modX] == '#')
                return seats[modY][modX] == '#' ? 1 : 0;

            return Seated(modX, xModifier, modY, yModifier, seats);
        }
    }
}