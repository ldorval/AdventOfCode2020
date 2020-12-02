using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day02
{
    public class Day02Part2
    {
        public static int Solve(IEnumerable<string> passwords)
        {
            var lines = PasswordLine.LinesFrom(passwords);
            return lines.Count(x => x.Password[x.PolicyRuleInt1 - 1] == x.Character ^
                                    x.Password[x.PolicyRuleInt2 - 1] == x.Character);
        }
    }
}