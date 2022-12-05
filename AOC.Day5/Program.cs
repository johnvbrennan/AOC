using AOC.Day5;
using AOC.Day5.Models;
using static System.Collections.Specialized.BitVector32;

const string inputFilename = @"C:\Users\BrennanJ\OneDrive - Version 1\GitLab\AOC.Day1AOC\AOC.Day5\input.txt";

String answer = "";

var containers = new Containers();

Console.WriteLine("Solution 1");
foreach (var line in File.ReadLines(inputFilename))
{
    var c = new Command(line);
    containers.Move(c);
}

for (int index = 0; index < containers.Stacks.Count;index++)
{
    var topItem = containers.Stacks[index].Pop();
    answer += ((Crate)topItem).Name;
    Console.WriteLine("Column {0} => {1}", index+1, ((Crate)topItem).Name);
}

Console.WriteLine("Answer to solution 1 = {0}", answer);
Console.WriteLine("**********");

Console.WriteLine("Solution 2");
containers = new Containers();
answer = "";
foreach (var line in File.ReadLines(inputFilename))
{
    var c = new Command(line);
    containers.NewMove(c);
}

for (int index = 0; index < containers.Stacks.Count; index++)
{
    var topItem = containers.Stacks[index].Pop();
    answer += ((Crate)topItem).Name;
    Console.WriteLine("Column {0} => {1}", index + 1, ((Crate)topItem).Name);
}

Console.WriteLine("Answer to solution 2 = {0}", answer);
Console.WriteLine("**********");
