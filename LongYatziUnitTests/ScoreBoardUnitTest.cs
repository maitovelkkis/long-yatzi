using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LongYatzi;

namespace LongYatziUnitTests
{
    [TestClass]
    public class ScoreBoardUnitTest
    {
        #region UpperSectionTotal
        [TestMethod]
        public void UpperSectionTotal_5()
        {
            ScoreBoard scoreBoard = new ScoreBoard();
            scoreBoard.upperSection = new int?[,] { { 1, 1,null,1,1,1}, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };
            Assert.AreEqual(5,scoreBoard.UpperSectionTotal(0));
        }
        [TestMethod]
        public void UpperSectionTotal_10()
        {
            ScoreBoard scoreBoard = new ScoreBoard();
            scoreBoard.upperSection = new int?[,] { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };
            scoreBoard.StoreScoreUp(4, 1, 7);
            scoreBoard.StoreScoreUp(4, 2, 3);
            Assert.AreEqual(10,scoreBoard.UpperSectionTotal(3));
        }
        [TestMethod]
        public void UpperSectionTotal_7()
        {
            ScoreBoard scoreBoard = new ScoreBoard();
            scoreBoard.upperSection = new int?[,] { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };
            scoreBoard.StoreScoreUp(4, 1, 7);
            Assert.AreEqual(7, scoreBoard.UpperSectionTotal(3));
        }
        [TestMethod]
        public void UpperSectionTotal_6()
        {
            ScoreBoard scoreBoard = new ScoreBoard();
            scoreBoard.upperSection = new int?[,] { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 3, 1, 1, 1, 1 } };
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            Assert.AreEqual(6, scoreBoard.UpperSectionTotal(3));
        }
        #endregion
        [TestMethod]
        public void LowerSectionTotal_8()
        {
            ScoreBoard scoreBoard = new ScoreBoard();
            scoreBoard.lowerSection = new int?[,] { { 1, 1, null, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1 } };
            Assert.AreEqual(8, scoreBoard.LowerSectionTotal(0));
        }
        [TestMethod]
        public void LowerSectionTotal_8_2()
        {
            ScoreBoard scoreBoard = new ScoreBoard();
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreUp(4, 1, 1);
            scoreBoard.StoreScoreDown(4, 1, 1);
            scoreBoard.StoreScoreDown(4, 1, 1);
            scoreBoard.StoreScoreDown(4, 1, 1);
            scoreBoard.StoreScoreDown(4, 1, 1);
            scoreBoard.StoreScoreDown(4, 1, 1);
            scoreBoard.StoreScoreDown(4, 1, 1);
            scoreBoard.StoreScoreDown(4, 1, 1);
            scoreBoard.StoreScoreDown(4, 1, 1);
            Assert.AreEqual(8, scoreBoard.LowerSectionTotal(3));
        }
    }
}
