using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day14
{
    public class ConverterTest
    {
        [Test]
        public void ConvertsTo36Bits()
        {
            Converter.ToBinary(11).Should().Be("000000000000000000000000000000001011");
        }

        [Test]
        public void ConvertsToInt()
        {
            Converter.ToLong("000000000000000000000000000000001011").Should().Be(11);
        }
    }
}