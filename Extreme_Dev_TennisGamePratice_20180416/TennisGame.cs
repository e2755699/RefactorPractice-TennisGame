using System;
using System.Collections.Generic;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private int _secondPlayerScore;
        private Dictionary<int, string> _scoreMapping = new Dictionary<int, string>() {{0,"Love"},{1, "Fifteen"},{2,"Thirty"},{3,"Forty"}};

        public string Score()
        {
            if (IsGameStart())
                return "Love All";

            if (IsDeuce())
            {
                return "Deuce";
            }

            if (IsSameScore())
            {
                return _scoreMapping[_firstPlayerScore] + " All";
            }

            return _scoreMapping[_firstPlayerScore] + " " + _scoreMapping[_secondPlayerScore];

        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore && _firstPlayerScore<3;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore == _secondPlayerScore && _firstPlayerScore>=3;
        }

        private bool IsGameStart()
        {
            return _firstPlayerScore == 0 && _secondPlayerScore == 0;
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
