using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day02
{
    public class Day02Part1
    {
        public static int Solve(IEnumerable<string> passwords)
        {
            var lines = PasswordLine.LinesFrom(passwords);

            return lines.Count(x =>
            {
                var characterCount = x.Password.Count(y => y == x.Character);
                return characterCount >= x.PolicyRuleInt1 && characterCount <= x.PolicyRuleInt2;
            });
        }
    }
}