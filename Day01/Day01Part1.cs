using System.Collections.Generic;

namespace AdventOfCode2020.Day01
{
    public class Day01Part1
    {
        public static int Solve(IList<int> expenses)
        {
            foreach (var expense1 in expenses)
            {
                foreach (var expense2 in expenses)
                {
                    if (expense1 + expense2 == 2020)
                        return expense1 * expense2;
                }
            }

            return 0;
        }
    }
}