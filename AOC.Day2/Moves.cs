using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day2
{
    public class Moves
    {
        public Moves(string player1Move, string player2Move)
        {
            Player1Move = player1Move;
            Player2Move = player2Move;
        }

        public string Player1Move { get; set; }
        public string Player2Move { get; set; }

        public static string MapMove(string input)
        {
            if (input == "A" || input == "X") return "Rock";
            if (input == "B" || input == "Y") return "Paper";
            if (input == "C" || input == "Z") return "Scissors";

            return "";
        }        
    }
}
