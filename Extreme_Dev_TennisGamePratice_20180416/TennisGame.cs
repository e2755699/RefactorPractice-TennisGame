﻿using System;
using System.Collections.Generic;

namespace Extreme_Dev_TennisGamePractice_20180416
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        private int _secondPlayerScore;
        private readonly Dictionary<int, string> _scoreMapping = new Dictionary<int, string>() {{0,"Love"},{1, "Fifteen"},{2,"Thirty"},{3,"Forty"}};

        public string Score()
        {
            if (IsSameScore())
            {
                if (IsDeuceGame())
                {
                    return "Deuce";
                }

                return _scoreMapping[_firstPlayerScore] + " All";
            }

            return _scoreMapping[_firstPlayerScore] + " " + _scoreMapping[_secondPlayerScore];

        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
        }

        private bool IsDeuceGame()
        {
            return _firstPlayerScore>=3;
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
