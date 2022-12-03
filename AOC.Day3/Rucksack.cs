using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day3
{
    internal class Rucksack
    {

        public Rucksack(string contents)
        {
            if (contents == null) throw new ArgumentNullException(nameof(contents));
            
            Id = contents;
            Compartment1 = contents.Substring(0, (contents.Length / 2));
            Compartment2 = contents.Substring(contents.Length / 2, contents.Length / 2);
        }

        public string Id { get; private set; }
        public string Compartment1 { get; private set; }
        public string Compartment2 { get; private set; }

        public IEnumerable<char> GetCommonItemsInCompartments()
        {
            return Compartment1.Intersect(Compartment2);
        }

        public int CalculateScore()
        {
            int total = 0;

            foreach (var c in GetCommonItemsInCompartments())
            {
                total += GetPositionInAlphabet(c);
            }

            return total;
        }

        public static int GetPositionInAlphabet(char character)
        {
            int position = 0;

            if (character.ToString().ToUpper() == character.ToString())
            {
                // if is upper case
                position = char.ToUpper(character) - 38;
            }
            else
            {
                // lowercase
                position = char.ToUpper(character) - 64;
            }

            return position;
        }
    }
}
