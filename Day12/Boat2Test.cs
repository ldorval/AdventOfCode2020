using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day12
{
    public class Boat2Test
    {
        private Boat2 boat;

        [SetUp]
        public void ThisBoat()
        {
            boat = new Boat2 {WaypointX = 0, WaypointY = 0};
        }
        
        [Test]
        public void MoveWaypointNorthIncreasesYPosition()
        {
            boat.ExecuteInstruction("N10");
            boat.WaypointY.Should().Be(10);
        }

        [Test]
        public void MoveWaypointSouthDecreasesYPosition()
        {
            boat.ExecuteInstruction("S10");
            boat.WaypointY.Should().Be(-10);
        }
        
        [Test]
        public void MoveWaypointEastIncreasesXPosition()
        {
            boat.ExecuteInstruction("E10");
            boat.WaypointX.Should().Be(10);
        }
        
        [Test]
        public void MoveWaypointWestDecreasesYPosition()
        {
            boat.ExecuteInstruction("W10");
            boat.WaypointX.Should().Be(-10);
        }

        [Test]
        public void RotatingTheWaypoint90DegreesRightMovesTheWaypoint()
        {
            boat.ExecuteInstruction("E5");
            boat.ExecuteInstruction("N4");
            
            boat.ExecuteInstruction("R90");
            boat.WaypointX.Should().Be(4);
            boat.WaypointY.Should().Be(-5);
        }
        
        [Test]
        public void RotatingTheWaypoint180DegreesRightMovesTheWaypoint()
        {
            boat.BoatX = 15;
            boat.BoatY = 12;
            boat.WaypointX = 20;
            boat.WaypointY = 16;

            boat.ExecuteInstruction("R180");
            boat.WaypointX.Should().Be(10);
            boat.WaypointY.Should().Be(8);
        }

        [Test]
        public void RotatingTheWaypoint90DegreesLeftMovesTheWaypoint()
        {
            boat.ExecuteInstruction("E5");
            boat.ExecuteInstruction("N4");
            
            boat.ExecuteInstruction("L90");
            boat.WaypointX.Should().Be(-4);
            boat.WaypointY.Should().Be(5);
        }
        
        [Test]
        public void RotatingTheWaypoint270DegreesRightMovesTheWaypoint()
        {
            boat.ExecuteInstruction("E5");
            boat.ExecuteInstruction("N4");
            
            boat.ExecuteInstruction("L90");
            boat.WaypointX.Should().Be(-4);
            boat.WaypointY.Should().Be(5);
        }

        [Test]
        public void MovesBoatToWaypoint()
        {
            boat.WaypointX = 5;
            boat.WaypointY = 2;
            boat.ExecuteInstruction("F10");

            boat.WaypointX.Should().Be(55);
            boat.WaypointY.Should().Be(22);
            boat.BoatX.Should().Be(50);
            boat.BoatY.Should().Be(20);
        }
    }
}