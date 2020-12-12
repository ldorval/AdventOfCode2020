using System;

namespace AdventOfCode2020.Day12
{
    public class Boat2
    {
        public int BoatX { get; set; }
        public int BoatY { get; set; }
        public int WaypointX { get; set; }
        public int WaypointY { get; set; }

        public Boat2()
        {
            WaypointX = 10;
            WaypointY = 1;
        }
        
        public void ExecuteInstruction(string instruction)
        {
            var direction = instruction.Substring(0, 1);
            var value = Convert.ToInt32(instruction.Substring(1, instruction.Length - 1));

            if (direction == "N") Move(0, value);
            else if (direction == "S") Move(0, -value);
            else if (direction == "E") Move(value, 0);
            else if (direction == "W") Move(-value, 0);
            else if (instruction == "R90" || instruction == "L270") Invert(-1, 1);
            else if (instruction == "L90" || instruction == "R270") Invert(1, -1);
            else if (instruction == "R180" || instruction == "L180") Negate();
            else if (direction == "F") MoveBoat(value);
        }

        private void MoveBoat(in int value)
        {
            var offsetX = WaypointX - BoatX;
            var offsetY = WaypointY - BoatY;
            
            BoatX += offsetX * value;
            BoatY += offsetY * value;
            WaypointX = BoatX + offsetX;
            WaypointY = BoatY + offsetY;
        }

        private void Move(int x, int y)
        {
            WaypointX += x;
            WaypointY += y;
        }

        private void Invert(int xMod, int yMod)
        {
            var offsetX = (WaypointX - BoatX) * xMod;
            var offsetY = (WaypointY - BoatY) * yMod;

            WaypointX = BoatX + offsetY;
            WaypointY = BoatY + offsetX;
        }

        private void Negate()
        {
            var offsetX = (WaypointX - BoatX) * -1;
            var offsetY = (WaypointY - BoatY) * -1;
            
            WaypointX = BoatX + offsetX;
            WaypointY = BoatY + offsetY;
        }
    }
}