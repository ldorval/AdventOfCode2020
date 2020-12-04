using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day04
{
    public class Day04Part1
    {
        private static readonly IList<string> RequiredFields = new List<string>{"byr","iyr","eyr","hgt","hcl","ecl","pid"};

        public static int Solve(string passportsInput)
        {
            var passports = passportsInput.Split(Environment.NewLine + Environment.NewLine);
            return passports.Count(x => RequiredFields.All(x.Contains));
        }
    }
}