using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day2
{
    internal class Player
    {
        public Player(int id)
        {
            this.Id = id;
        }
        public int Id { get; set; }

        public string CurrentMove { get; set; }
        public int Score { get; set; }

        public int CalculateScoreForGame(GameResult result)
        {
            int gameScore = 0;

            // Rock = 1
            // Paper = 2
            // Scissors = 3 
            if(result == GameResult.Draw)
            {
                gameScore = 3 + GetPlayerMoveScore();
            }
            else if(result == GameResult.Player1Wins && Id == 1)
            {
                // player1 wins
                gameScore = 6 + GetPlayerMoveScore(); 
            }
            else if(result == GameResult.Player2Wins && Id == 2)
            {
                // player 2 wins
                gameScore = 6 + GetPlayerMoveScore();
            }
            else
            {
                gameScore = GetPlayerMoveScore();
            }

            return gameScore;
        }

        private int GetPlayerMoveScore()
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
         

            // Rock = 1
            // Paper = 2
            // Scissors = 3
            if (CurrentMove == Rock) return 1;
            if (CurrentMove == Paper) return 2;
            if (CurrentMove == Scissors) return 3;

            return 0;
        }
    }
}
