using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day1
{
    public class ElfFactory
    {
        public List<Elf> Create(string fileInput)
        {
            if (String.IsNullOrWhiteSpace(fileInput)) throw new ArgumentNullException(nameof(fileInput));

            // iterate over the file
            List<Elf> elves = new List<Elf>();

            foreach(var line in fileInput)
            {

            }

            return elves;
        }
    }
}
