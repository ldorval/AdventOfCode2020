using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2020.Day12
{
    public class BoatTest
    {
        private Boat boat;

        [SetUp]
        public void ThisBoat()
        {
            boat = new Boat();
        }
        
        [Test]
        public void MoveNorthIncreasesYPosition()
        {
            boat.ExecuteInstruction("N10");
            boat.Y.Should().Be(10);
        }

        [Test]
        public void MoveSouthDecreasesYPosition()
        {
            boat.ExecuteInstruction("S10");
            boat.Y.Should().Be(-10);
        }
        
        [Test]
        public void MoveEastIncreasesXPosition()
        {
            boat.ExecuteInstruction("E10");
            boat.X.Should().Be(10);
        }
        
        [Test]
        public void MoveWestDecreasesYPosition()
        {
            boat.ExecuteInstruction("W10");
            boat.X.Should().Be(-10);
        }

        [Test]
        public void MoveForwardShouldIncreaseTheCoordinateInTheWayItIsFacing()
        {
            boat.ExecuteInstruction("F10");
            boat.X.Should().Be(10);
        }

        [Test]
        public void TurningRight90DegreesWhenFacingEastShouldMakeTheBoatFaceSouth()
        {
            boat.ExecuteInstruction("R90");
            boat.Orientation.Should().Be("S");
        }
        
        [Test]
        public void TurningLeft90DegreesWhenFacingEastShouldMakeTheBoatFaceNorth()
        {
            boat.ExecuteInstruction("L90");
            boat.Orientation.Should().Be("N");
        }
        
        [Test]
        public void TurningRight180DegreesWhenFacingEastShouldMakeTheBoatFaceWest()
        {
            boat.ExecuteInstruction("R180");
            boat.Orientation.Should().Be("W");
        }
        
        [Test]
        public void TurningLeft180DegreesWhenFacingEastShouldMakeTheBoatFaceWest()
        {
            boat.ExecuteInstruction("L180");
            boat.Orientation.Should().Be("W");
        }

        [Test]
        public void TurningRight270DegressWhenFacingEastSHouldMakeTheBoastFaceNorth()
        {
            boat.ExecuteInstruction("R270");
            boat.Orientation.Should().Be("N");
        }
    }
}