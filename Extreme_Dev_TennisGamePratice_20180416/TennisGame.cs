using System;
using System.Collections.Generic;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private int _secondPlayerScore;
        private List<Score> _scores;

        public string Score()
        {

            if (_secondPlayerScore == 0)
            {
                Dictionary<int, string> scoreMapping = new Dictionary<int, string>() {{1, "Fifteen"},{2,"Thirty"},{3,"Forty"}};
                switch (_firstPlayerScore)
                {
                    case 1:
                        return  scoreMapping[1] +" Love";
                    case 2:
                        return scoreMapping[2] + " Love";
                    case 3:
                        return scoreMapping[3] + " Love";
                }
            }

            switch (_firstPlayerScore)
            {
                case 0:
                    switch (_secondPlayerScore)
                    {
                        case 1:
                            return "Love Fifteen";
                        case 2:
                            return "Love Thirty";
                        case 3:
                            return "Love Forty";
                    }

                    break;
                case 1 when _secondPlayerScore == 1:
                    return "Fifteen All";
                case 2 when _secondPlayerScore == 2:
                    return "Thirty All";
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
