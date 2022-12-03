// See https://aka.ms/new-console-template for more information



using AOC.Day3;

const string inputFilename = @"C:\Users\BrennanJ\OneDrive - Version 1\GitLab\AOC.Day1AOC\AOC.Day3\sacks.txt";

string contents = "PmmdzqPrVvPwwTWBwg";
List<Rucksack> sacks = new List<Rucksack>();
int total = 0;

foreach (var line in File.ReadLines(inputFilename))
{
    sacks.Add(new Rucksack(line));
}


foreach (var rucksack in sacks)
{
    Console.WriteLine($"Compartment 1: {rucksack.Compartment1}");
    Console.WriteLine($"Compartment 2: {rucksack.Compartment2}");

    var commonItems = rucksack.GetCommonItemsInCompartments();
    foreach (var item in commonItems)
    {
        Console.WriteLine($"{item} = {rucksack.CalculateScore()}");
    }

    total += rucksack.CalculateScore();
}

Console.WriteLine($"Total is {total}");


int groupNumber = 0;
List<string> grouping = new List<string>();
total = 0;

for (int index = 0; index < sacks.Count;index++)
{

    grouping.Add(sacks[index].Id);

    if ( (index+1) % 3 == 0 )
    {
        groupNumber++;
        IEnumerable<char> elfGroup = grouping[0].Intersect(grouping[1]).Intersect(grouping[2]);

        Console.WriteLine($"New Group {groupNumber} - {elfGroup.First()}.");

        total += Rucksack.GetPositionInAlphabet(elfGroup.First());
        grouping.Clear();
    }
}
Console.WriteLine($"Elf group total is {total}");
