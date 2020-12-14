using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day14
{
    public class Day14
    {
        public static List<long> PossibleValues;
        
        public static long SolveV1(List<string> input)
        {
            var currentMask = "";
            var memory = new Dictionary<int, long>();
            
            foreach (var line in input)
            {
                if (line.StartsWith("mask"))
                    currentMask = line.Split(" = ")[1];
                else
                {
                    var memValue = Converter.ToBinary(ValueOf(line));
                    memory[AddressOf(line)] = Converter.ToLong(ApplyMask(currentMask, memValue, 'X'));
                }
            }

            return memory.Sum(x => x.Value);
        }

        public static long SolveV2(List<string> input)
        {
            var currentMask = string.Empty;
            var memory = new Dictionary<long, long>();
            
            foreach (var line in input)
            {
                if (line.StartsWith("mask"))
                    currentMask = MaskFromLine(line);
                else
                {
                    var memAddress = Converter.ToBinary(AddressOf(line));
                    var withMask = ApplyMask(currentMask, memAddress, '0');
                    PossibleValues = new List<long>();
                    AllPossibleValues(withMask);
                    PossibleValues.ForEach(x => memory[x] = ValueOf(line));
                }
            }

            return memory.Sum(x => x.Value);
        }

        public static void AllPossibleValues(string withMask)
        {
            var array = withMask.ToCharArray();

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == 'X')
                {
                    array[i] = '0';
                    AddPossibleValues(array);
                    
                    array[i] = '1';
                    AddPossibleValues(array);
                }
            }
        }

        private static void AddPossibleValues(char[] array)
        {
            if (array.Contains('X'))
                AllPossibleValues(new string(array));
            else
            {
                var value = Converter.ToLong(new string(array));
                if (!PossibleValues.Contains(value)) PossibleValues.Add(value);
            }
        }

        public static string ApplyMask(string currentMask, string memValue, char ignoreChar)
        {
            var newValue = memValue
                .Select((x, index) => currentMask[index] == ignoreChar ? memValue[index] : currentMask[index])
                .ToArray();

            return new string(newValue);
        }
        
        private static int AddressOf(string line)
        {
            return Convert.ToInt32(line.Substring(4, line.IndexOf(']') - 4));
        }

        private static long ValueOf(string line)
        {
            return Convert.ToInt64(line.Split(" = ")[1]);
        }

        private static string MaskFromLine(string line)
        {
            return line.Split(" = ")[1];
        }
    }
}