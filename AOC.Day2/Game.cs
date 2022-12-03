using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day2
{
    public class Game
    {
        public const string Rock = "Rock";
        public const string Paper = "Paper";
        public const string Scissors = "Scissors";
         
        Dictionary<String, String> gameRules = new Dictionary<string, string>();

        public Game()
        {
            gameRules.Add(Paper, Rock);
            gameRules.Add(Scissors, Paper);
            gameRules.Add(Rock, Scissors);
        }

        public string GetPlayerMove(int playerNumber, string move)
        {
            if (playerNumber == 1)
            {
                if (move == "A")
                    return Rock;
                if (move == "B")
                    return Paper;
                if (move == "C")
                    return Scissors;
            }
            else if (playerNumber == 2)
            {
                if (move == "X")
                    return Rock;
                if (move == "Y")
                    return Paper;
                if (move == "Z")
                    return Scissors;
            }
            
            return "";
        } 
         
        public GameResult GetGameResult(string player1Move, string player2Move)
        {
            // return 1 - player 1 wins
            // return 2 - player 2 wins
            // return 0 - draw

            GameResult outcome = GameResult.Unknown;
            if (string.IsNullOrEmpty(player2Move)) throw new ArgumentNullException(nameof(player2Move));
            if (string.IsNullOrEmpty(player1Move)) throw new ArgumentNullException(nameof(player1Move));

            string losingMove;

            if (String.Compare(player1Move, player2Move) == 0)
            {
                outcome = GameResult.Draw;
            }
            else
            {
                gameRules.TryGetValue(player1Move, out losingMove);

                if (String.Compare(player2Move, losingMove) == 0)
                {
                    outcome = GameResult.Player1Wins;
                }
                else
                {
                    outcome = GameResult.Player2Wins;
                }
            }

            return outcome;
        } 

        public string MapPlayer2Move(string player1Move, string action)
        {
            // X => losing move
            if (action == "Y")
                return player1Move;

            // Y => draw
            if (action == "X")
            {
                string losingMove;
                gameRules.TryGetValue(player1Move, out losingMove);
                return losingMove;
            }

            // Remap player 2 move
            // Z => winning move
            if(action == "Z")
            {
                switch (player1Move)
                {
                    case Rock: return Paper;
                    case Paper: return Scissors;
                    case Scissors: return Rock;
                }   
            }

            return "";
        }
    }


    public enum GameResult
    {
        Unknown = -1,
        Draw = 0,
        Player1Wins = 1,
        Player2Wins = 2
    }
}
