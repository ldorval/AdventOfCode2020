using System;

namespace AdventOfCode2020.Day14
{
    public class Converter
    {
        public static string ToBinary(long i)
        {
            var binary = Convert.ToString(i, 2).PadLeft(36, '0');
            return binary;
        }

        public static long ToLong(string binary)
        {
            return Convert.ToInt64(binary, 2);
        }
    }
}