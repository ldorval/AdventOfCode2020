using System.Collections.Generic;

namespace AdventOfCode2020.Day01
{
    public class Day01Part2
    {
        public static int Solve(IList<int> expenses)
        {
            foreach (var expense1 in expenses)
            {
                foreach (var expense2 in expenses)
                {
                    foreach (var expense3 in expenses)
                    {
                        if (expense1 + expense2 + expense3 == 2020)
                            return expense1 * expense2 * expense3;                        
                    }
                }
            }

            return 0;
        }
    }
}