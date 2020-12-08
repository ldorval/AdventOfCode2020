using System.Collections.Generic;

namespace AdventOfCode2020.Day08
{
    public class Day08Part1
    {
        private int accumulator;
        private List<Command> commands;
        
        public Day08Part1(IEnumerable<string> input)
        {
            commands = Command.FromInput(input);
        }
        
        public int Solve()
        {
            return CommandExecutor.Execute(commands).Accumulator;
        }
    }
}