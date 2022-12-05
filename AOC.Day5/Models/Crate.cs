using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day5.Models
{
    internal class Crate
    {
        public Crate(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
