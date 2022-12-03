// See https://aka.ms/new-console-template for more information
using AOC.Day2;

const string inputFilename = @"C:\Users\BrennanJ\OneDrive - Version 1\GitLab\AOC.Day1AOC\AOC.Day2\moves.txt";

var g = new Game();

List<Moves> moves = new List<Moves>();

foreach (var line in File.ReadLines(inputFilename))
{
    var items = line.Split(' ');

    // Remap player 2 move
    // X => losing move
    // Y => draw
    // Z => winning move

    moves.Add(new Moves(items[0], items[1]));
};

Player playerOne = new Player(1);
Player playerTwo = new Player(2);


foreach (var m in moves)
{
    playerOne.CurrentMove = Moves.MapMove(m.Player1Move);
    playerTwo.CurrentMove = g.MapPlayer2Move(playerOne.CurrentMove, m.Player2Move);

    GameResult result = g.GetGameResult(playerOne.CurrentMove, playerTwo.CurrentMove);


    ;
    playerTwo.CalculateScoreForGame(result);

    Console.WriteLine($"Player 1 move: {playerOne.CurrentMove}");
    Console.WriteLine($"Player 2 move: {playerTwo.CurrentMove}");
    Console.WriteLine($"Result is {result}");
    Console.WriteLine($"Player 1 score: {playerOne.CalculateScoreForGame(result)}");
    Console.WriteLine($"Player 2 score: {playerTwo.CalculateScoreForGame(result)}");
    playerOne.Score += playerOne.CalculateScoreForGame(result);
    playerTwo.Score += playerTwo.CalculateScoreForGame(result);
}

Console.WriteLine("");
Console.WriteLine($"Player 2 total score: {playerTwo.Score}");

// Read move
// Work out winner
// Calculate Score for each player