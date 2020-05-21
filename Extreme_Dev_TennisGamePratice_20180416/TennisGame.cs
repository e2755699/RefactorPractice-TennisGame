using System;
using System.Collections.Generic;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private int _secondPlayerScore;
        private List<Score> _scores;
        private Dictionary<int, string> _scoreMapping = new Dictionary<int, string>() {{0,"Love"},{1, "Fifteen"},{2,"Thirty"},{3,"Forty"}};

        public string Score()
        {
            if (_firstPlayerScore == 0 && _secondPlayerScore == 0)
                return "Love All";
            if (_secondPlayerScore == 0)
            {
                return _scoreMapping[_firstPlayerScore] + " Love";
            }

            if (_firstPlayerScore == 0)
                return "Love " + _scoreMapping[_secondPlayerScore];
            else if (_firstPlayerScore == 1 && _secondPlayerScore == 1)
                return "Fifteen All";
            else if (_firstPlayerScore == 2 && _secondPlayerScore == 2) return "Thirty All";

            if (_firstPlayerScore == _secondPlayerScore && _firstPlayerScore>=3)
            {
                return "Deuce";
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
        private void GivenScore()
        {
            _scores = new List<Score>()
            {
                new Score() {},
            };
        }
    }

}
