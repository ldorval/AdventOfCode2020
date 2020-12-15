using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day15
{
    public class Day15
    {
        public static int Solve(List<int> input, int roundCount)
        {
            var numbers = input.Select((x, index) => new KeyValuePair<int, int>(x, index)).ToDictionary(x => x.Key, y => y.Value);
            var i = numbers.Count - 1;
            var lastNumber = numbers.Last().Key;
            numbers.Remove(lastNumber);
            
            while (i != roundCount - 1)
            {
                if (numbers.ContainsKey(lastNumber))
                {
                    var indexLastNumber = numbers[lastNumber]; 
                    numbers[lastNumber] = i;
                    lastNumber = i - indexLastNumber;
                }
                else
                {
                    numbers[lastNumber] = i;
                    lastNumber = 0;
                }

                i++;
            }

            return lastNumber;
        }
    }
}