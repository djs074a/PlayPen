using System;
using NUnit.Framework;


namespace SandPit
{
    [TestFixture]
    public class BowlingTestClass
    {
        Game g;

        [SetUp]
        public void Init()
        {
            g = new Game();
        }

        public void manyRolls(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.Roll(pins);
            }
        }
        [Test]
        public void gutterGame()
        {
            manyRolls(20, 0);
            Assert.AreEqual(0, g.Score());
        }

        [Test]
        public void allOnes()
        {
            manyRolls(20, 1);
            Assert.AreEqual(20, g.Score());

        }

        [Test]
        public void singleSpare()
        {
            rollSpare();
            g.Roll(3);
            manyRolls(16, 0);
            Assert.AreEqual(16, g.Score());
        }

        public void rollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        [Test]
        public void singleStrike()
        {
            g.Roll(10);
            g.Roll(3);
            g.Roll(4);
            manyRolls(16, 0);
            Assert.AreEqual(24, g.Score());
        }

        [Test]
        public void perfectGame()
        {
            manyRolls(13, 10);
            Assert.AreEqual(300, g.Score());
        }

    }
}
