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
            if (_secondPlayerScore == 0 || _firstPlayerScore==0)
            {
                return _scoreMapping[_firstPlayerScore] + " "+_scoreMapping[_secondPlayerScore];
            }

            if (_firstPlayerScore == _secondPlayerScore && _firstPlayerScore<3)
            {
                return _scoreMapping[_firstPlayerScore] + " All";
            }

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
