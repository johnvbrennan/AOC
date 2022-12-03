// See https://aka.ms/new-console-template for more information
using AOC.Day1;

const string inputFilename = @"C:\Users\BrennanJ\OneDrive - Version 1\GitLab\AOC.Day1AOC\AOC.Day1\File\input.txt";

try
{
	int elfPosition = 1;
	List<Elf> elves = new List<Elf>() {  new Elf(elfPosition, new List<int>()) };

	// Open the text file using a stream reader.
	foreach(var line in File.ReadLines(inputFilename))
	{
		// allocate a new elf
		if (String.IsNullOrWhiteSpace(line))
		{
			// Allocate a new Elf
			elfPosition++;
			elves.Add(new Elf(elfPosition, new List<int>()));
		}
		else
        {
            elves[elfPosition-1].AddCalories(Int32.Parse(line));
		}			
	}		

	elves.Sort();
	elves.Reverse();

    Console.WriteLine($"Top elf is number {elves[0].Position} with {elves[0].TotalCalories} calories.");

	int topElvesTotalCalories = 0;

	for(int index = 0; index<3; index++)
    {
		topElvesTotalCalories += elves[index].TotalCalories;
    }

	Console.WriteLine($"Top 3 elves are carrying {topElvesTotalCalories} calories.");

}
catch (IOException e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}


/*
1.Read the input file
2. Iterate over the file 
	while not eof
	{
		Record the current elf number/position in file
		Calculate the total calories for this elf.
		if total_calories > max_calories_observed
			Set max_elf_position = currentPosition
			Set max_calories_observed = total_calories
		end if
	}	
3.Determine elf with greatest number of calories
*/