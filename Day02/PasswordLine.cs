using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day02
{
    public class PasswordLine
    {
        public int PolicyRuleInt1 { get; set; }
        public int PolicyRuleInt2 { get; set; }
        public char Character { get; set; }
        public string Password { get; set; }

        private static PasswordLine FromString(string line)
        {
            var sections = line.Split(' ');
            return new PasswordLine
            {
                PolicyRuleInt1 = Convert.ToInt32(sections[0].Split('-')[0]),
                PolicyRuleInt2 = Convert.ToInt32(sections[0].Split('-')[1]),
                Character = sections[1].Trim(':')[0],
                Password = sections[2]
            };
        }
        
        public static IEnumerable<PasswordLine> LinesFrom(IEnumerable<string> passwords)
        {
            return passwords.Select(FromString).ToList();
        }
    }
}