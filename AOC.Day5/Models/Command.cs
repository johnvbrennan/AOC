using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day5.Models
{
    internal class Command
    {
        public Command(string command)
        {
            // "move 5 from 8 to 2"
            var items = command.Split(' ');

            NumberToMove= Int32.Parse(items[1]);
            FromColumn = Int32.Parse(items[3]);
            ToColumn = Int32.Parse(items[5]);
        }
        public int FromColumn { get; set; }
        public int ToColumn { get; set; }
        public int NumberToMove { get; set; }

    }
}
