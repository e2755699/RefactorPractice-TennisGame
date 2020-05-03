using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    [TestClass]
    public class UnitTest1
    {
        private TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            Assert.AreEqual("Love All", tennisGame.Score());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScore();
            Assert.AreEqual("Fifteen Love", tennisGame.Score());
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            Assert.AreEqual("Thirty Love", tennisGame.Score());
        }

        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            Assert.AreEqual("Forty Love", tennisGame.Score());
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            tennisGame.SecondPlayerScore();
            Assert.AreEqual("Love Fifteen", tennisGame.Score());
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScore(2);
            Assert.AreEqual("Love Thirty", tennisGame.Score());
        }

        [TestMethod]
        public void Love_Forty()
        {
            GivenSecondPlayerScore(3);
            Assert.AreEqual("Love Forty", tennisGame.Score());
        }

        [TestMethod]
        public void Fiftten_All()
        {
            GivenFirstPlayerScore(1);
            GivenSecondPlayerScore(1);
            Assert.AreEqual("Fifteen All", tennisGame.Score());
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScore(2);
            GivenSecondPlayerScore(2);
            Assert.AreEqual("Thirty All", tennisGame.Score());
        }

        [TestMethod]
        public void Deuce()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(3);
            Assert.AreEqual("Deuce", tennisGame.Score());
        }

        [TestMethod]
        public void Deuce_when_4_4()
        {
            GivenFirstPlayerScore(4);
            GivenSecondPlayerScore(4);
            Assert.AreEqual("Deuce", tennisGame.Score());
        }

        private void GivenSecondPlayerScore(int times)
        {
            throw new NotImplementedException();
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }
    }
}