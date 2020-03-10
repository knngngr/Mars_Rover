using MarsRover;
using NUnit.Framework;

namespace MarsRoverTest
{
   [TestFixture]
    public class MarsRoverTest
    {
        private Rover r1;
        private Rover r2;
        private Position plateau;
        [SetUp]
        public void Setup()
        {
           r1 = new Rover();
           r2 = new Rover();
           plateau = new Position(5, 5);
        }

        [Test]
        public void Test_1_3_N()
        {

            plateau.CurrentRotation = "N";
            plateau.X = 1;
            plateau.Y = 2;

            r1.SetPosition(plateau);
            r1.SetRotateList("LMLMLMLMM");
            r1.StartAction();
            Position finalPosition =r1.GetPosition();
            Assert.AreEqual(finalPosition.X, 1);
            Assert.AreEqual(finalPosition.Y, 3);
            Assert.AreEqual(finalPosition.CurrentRotation, "N");
    
        }
        [Test]
        public void Test_5_1_E()
        {
            plateau.CurrentRotation = "E";
            plateau.X = 3;
            plateau.Y = 3;
            r2.SetPosition(plateau);
            r2.SetRotateList("MMRMMRMRRM");
            r2.StartAction();
            Position finalPositionTwo = r2.GetPosition();
            Assert.AreEqual(finalPositionTwo.X, 5);
            Assert.AreEqual(finalPositionTwo.Y, 1);
            Assert.AreEqual(finalPositionTwo.CurrentRotation, "E");
        }
    }
}