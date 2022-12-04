using AOC.Day4;
using AOC.Day4.Models;

const string inputFilename = @"C:\Users\BrennanJ\OneDrive - Version 1\GitLab\AOC.Day1AOC\ACO.Day4\input.txt";


int totalOverlaps = 0;
int totalPartialOverlaps = 0;

foreach (var line in File.ReadLines(inputFilename))
{
    var sections = line.Split(",");

    var pairing = new AssignmentPairing(new Section(sections[0]), new Section(sections[1]));

    if (pairing.IsFullyContained())
    {
        Console.WriteLine("Section {0} and {1} are fully", pairing.SectionA, pairing.SectionB);
        totalOverlaps++;
    }

    if(pairing.IsPartialOverlap())
    {
        Console.WriteLine("Section {0} and {1} are partial overlaps", pairing.SectionA, pairing.SectionB);
        totalPartialOverlaps++;        
    }
}

Console.WriteLine("Total contained overlaps = {0}", totalOverlaps);
Console.WriteLine("Total partial overlaps = {0}", totalPartialOverlaps);

