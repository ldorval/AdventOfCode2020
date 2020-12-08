using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day08
{
    public class Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Argument { get; set; }
        public bool Executed { get; set; }

        public static List<Command> FromInput(IEnumerable<string> input)
        {
            return input
                .Select((x, index) => new Command
                {
                    Name = x.Substring(0, 3), 
                    Argument = Convert.ToInt32(x.Substring(4, x.Length - 4)), 
                    Id = index
                })
                .ToList();
        }
    }
}