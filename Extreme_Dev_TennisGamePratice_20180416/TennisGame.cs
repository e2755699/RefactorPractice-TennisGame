using System;
using System.Collections.Generic;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private int _secondPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore == 1 && _secondPlayerScore == 0)
            {
                return "Fifteen Love";
            }
            if (_firstPlayerScore == 2)
            {
                return "Thirty Love";
            }
            if (_firstPlayerScore == 3)
            {
                return "Forty Love";
            }

            if (_firstPlayerScore ==0 && _secondPlayerScore == 1)
            {
                return "Love Fifteen";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}
