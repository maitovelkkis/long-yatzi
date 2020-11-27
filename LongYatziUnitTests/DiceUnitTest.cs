using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LongYatzi;
using System.Diagnostics;

namespace LongYatziUnitTests
{
    [TestClass]
    public class DiceUnitTest
    {
        [TestMethod]
        public void ValidatePair_2() //should return 2 as biggest possible pair is 2.
        {
            Dice dice = new Dice();
            dice.AddDie(1);
            dice.AddDie(1);
            dice.AddDie(1);
            dice.AddDie(4);
            dice.AddDie(5);
            Assert.AreEqual(2, dice.ValidatePair());
        }
        [TestMethod]
        public void ValidatePair_6() //should return 2 as biggest possible pair is 6.
        {
            Dice dice = new Dice();
            dice.AddDie(1);
            dice.AddDie(1);
            dice.AddDie(1);
            dice.AddDie(3);
            dice.AddDie(3);
            Assert.AreEqual(6, dice.ValidatePair());
        }
        [TestMethod]
        public void ValidatePair_0() //should return 0 as no pair is found
        {
            Dice dice = new Dice();
            dice.AddDie(1);
            dice.AddDie(2);
            dice.AddDie(3);
            dice.AddDie(4);
            dice.AddDie(5);
            Assert.AreEqual(0, dice.ValidatePair());
        }
    }
}
