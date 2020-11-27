﻿using System;
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
        [TestMethod]
        public void ValidateYatzy_50() //should return 50 as all are same
        {
            Dice dice = new Dice();
            dice.AddDie(1);
            dice.AddDie(1);
            dice.AddDie(1);
            dice.AddDie(1);
            dice.AddDie(1);
            Assert.AreEqual(50, dice.ValidateYatzy());
        }
        [TestMethod]
        public void ValidateYatzy_50_6() //should return 50 as all are same
        {
            Dice dice = new Dice();
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            Assert.AreEqual(50, dice.ValidateYatzy());
        }
        [TestMethod]
        public void ValidateYatzy_0() //should return 0 as all are not same
        {
            Dice dice = new Dice();
            dice.AddDie(1);
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            Assert.AreEqual(0, dice.ValidateYatzy());
        }
        [TestMethod]
        public void ValidateYatzy_0_2() //should return 0 as all are not same
        {
            Dice dice = new Dice();
            dice.AddDie(6);
            dice.AddDie(1);
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            Assert.AreEqual(0, dice.ValidateYatzy());
        }
        [TestMethod]
        public void ValidateYatzy_0_3() //should return 0 as all are not same
        {
            Dice dice = new Dice();
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(1);
            dice.AddDie(6);
            dice.AddDie(6);
            Assert.AreEqual(0, dice.ValidateYatzy());
        }
        [TestMethod]
        public void ValidateYatzy_0_4() //should return 0 as all are not same
        {
            Dice dice = new Dice();
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(1);
            dice.AddDie(6);
            Assert.AreEqual(0, dice.ValidateYatzy());
        }
        [TestMethod]
        public void ValidateYatzy_0_5() //should return 0 as all are not same
        {
            Dice dice = new Dice();
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(6);
            dice.AddDie(1);
            Assert.AreEqual(0, dice.ValidateYatzy());
        }
        [TestMethod]
        public void ValidateSmallStraight_0() //should return 0
        {
            Dice dice = new Dice();
            dice.AddDie(1);
            dice.AddDie(2);
            dice.AddDie(3);
            dice.AddDie(4);
            dice.AddDie(6);
            Assert.AreEqual(0, dice.ValidateSmallStraight());
        }
        [TestMethod]
        public void ValidateSmallStraight_15() //should return 15
        {
            Dice dice = new Dice();
            dice.AddDie(1);
            dice.AddDie(2);
            dice.AddDie(3);
            dice.AddDie(4);
            dice.AddDie(5);
            Assert.AreEqual(15, dice.ValidateSmallStraight());
        }
        [TestMethod]
        public void ValidateSmallStraight_15_2() //should return 15
        {
            Dice dice = new Dice();
            dice.AddDie(2);
            dice.AddDie(1);
            dice.AddDie(3);
            dice.AddDie(5);
            dice.AddDie(4);
            Assert.AreEqual(15, dice.ValidateSmallStraight());
        }
        public void ValidateBigStraight_20() //should return 15
        {
            Dice dice = new Dice();
            dice.AddDie(2);
            dice.AddDie(3);
            dice.AddDie(4);
            dice.AddDie(5);
            dice.AddDie(6);
            Assert.AreEqual(20, dice.ValidateBigStraight());
        }
        public void ValidateBigStraight_20_2() //should return 15
        {
            Dice dice = new Dice();
            dice.AddDie(2);
            dice.AddDie(3);
            dice.AddDie(4);
            dice.AddDie(5);
            dice.AddDie(1);
            Assert.AreEqual(20, dice.ValidateBigStraight());
        }
    }
}