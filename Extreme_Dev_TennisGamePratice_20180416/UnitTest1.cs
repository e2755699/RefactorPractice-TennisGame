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
            Assert.AreEqual("Love All", tennisGame.Scroe());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScore();
            Assert.AreEqual("Fifteen Love", tennisGame.Scroe());
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            Assert.AreEqual("Thirty Love", tennisGame.Scroe());
        }

        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            Assert.AreEqual("Forty Love", tennisGame.Scroe());
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            tennisGame.SecondPlayerScore();
            Assert.AreEqual("Love Fifteen", tennisGame.Scroe());
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScore(2);
            Assert.AreEqual("Love Thirty", tennisGame.Scroe());
        }

        [TestMethod]
        public void Love_Forty()
        {
            GivenSecondPlayerScore(3);
            Assert.AreEqual("Love Forty", tennisGame.Scroe());
        }

        [TestMethod]
        public void Fiftten_All()
        {
            GivenFirstPlayerScore(1);
            GivenSecondPlayerScore(1);
            Assert.AreEqual("Fifteen All", tennisGame.Scroe());
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScore(2);
            GivenSecondPlayerScore(2);
            Assert.AreEqual("Thirty All", tennisGame.Scroe());
        }

        [TestMethod]
        public void Deuce()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(3);
            Assert.AreEqual("Deuce", tennisGame.Scroe());
        }

        [TestMethod]
        public void Deuce_when_4_4()
        {
            GivenFirstPlayerScore(4);
            GivenSecondPlayerScore(4);
            Assert.AreEqual("Deuce", tennisGame.Scroe());
        }

        private void GivenSecondPlayerScore(int times)
        {
            throw new NotImplementedException();

        }

        private void GivenFirstPlayerScore(int times)
        {
            throw new NotImplementedException();
        }
    }
}