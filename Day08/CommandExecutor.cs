using System.Collections.Generic;

namespace AdventOfCode2020.Day08
{
    public class ExecutionResult
    {
        public int Accumulator { get; set; }
        public bool EndedNormally { get; set; }
    }
    
    public class CommandExecutor
    {
        public static ExecutionResult Execute(List<Command> commands)
        {
            ClearExecutionFlag(commands);
            var accumulator = 0;
            var index = 0;

            while (true)
            {
                var command = commands[index];
                if (command.Executed) return new ExecutionResult {Accumulator = accumulator, EndedNormally = false};
                
                if (command.Name == "acc")
                {
                    index++;
                    accumulator += command.Argument;
                } else if (command.Name == "nop")
                    index++;
                else if (command.Name == "jmp")
                    index += command.Argument;

                command.Executed = true;

                if (index == commands.Count) return new ExecutionResult {Accumulator = accumulator, EndedNormally = true};
            }
        }

        private static void ClearExecutionFlag(List<Command> commands)
        {
            commands.ForEach(x => x.Executed = false);
        }
    }
}