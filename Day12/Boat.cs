using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Day12
{
    public class Boat
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Orientation { get; set; }

        private readonly Dictionary<string, int> cardinalPoints = new Dictionary<string, int>
        {
            {"N", 0}, {"E", 90}, {"S", 180}, {"W", 270}
        };

        public Boat()
        {
            Orientation = "E";
        }

        public void ExecuteInstruction(string instruction)
        {
            var direction = instruction.Substring(0, 1);
            var value = Convert.ToInt32(instruction.Substring(1, instruction.Length - 1));

            if (direction == "F") direction = Orientation;
            if (direction == "N") Move(0, value);
            else if (direction == "S") Move(0, -value);
            else if (direction == "E") Move(value, 0);
            else if (direction == "W") Move(-value, 0);
            else if (direction == "R") Turn(value);
            else if (direction == "L") Turn(-value);
        }

        private void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        private void Turn(int angle)
        {
            var currentAngle = cardinalPoints[Orientation];
            var newAngle = AddAngle(currentAngle, angle);
            Orientation = cardinalPoints.First(x => x.Value == newAngle).Key;
        }

        private int AddAngle(int angleA, int angleB)
        {
            var newAngle = (angleA + angleB) % 360;

            if (newAngle < 0)
                return newAngle + 360;

            return newAngle;
        }
    }
}