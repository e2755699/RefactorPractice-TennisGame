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
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            tennisGame.SecondPlayerScore();
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScore(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            GivenSecondPlayerScore(3);
            ScoreShouldBe("Love Forty");
        }

        [TestMethod]
        public void Fiftten_All()
        {
            GivenFirstPlayerScore(1);
            GivenSecondPlayerScore(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScore(2);
            GivenSecondPlayerScore(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_when_4_4()
        {
            GivenFirstPlayerScore(4);
            GivenSecondPlayerScore(4);
            ScoreShouldBe("Deuce");
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScore();
            }
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.Scroe());
        }
    }
}