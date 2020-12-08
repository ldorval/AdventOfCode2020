using System.Collections.Generic;

namespace AdventOfCode2020.Day08
{
    public class Day08Part2
    {
        public static int Solve(List<string> input)
        {
            for (var i = 0; i < input.Count; i++)
            {
                var commands = Command.FromInput(input);

                if (commands[i].Name == "jmp")
                    commands[i].Name = "nop";
                else if (commands[i].Name == "nop")
                    commands[i].Name = "jmp";
                
                var result = CommandExecutor.Execute(commands);
                if (result.EndedNormally)
                    return result.Accumulator;
            }

            return 0;
        }
    }
}