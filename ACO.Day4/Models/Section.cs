using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day4.Models
{
    internal class Section
    {
        public Section(string range)
        {
            if (string.IsNullOrEmpty(range)) throw new ArgumentNullException(nameof(range));

            var values = range.Split('-');

            Start = int.Parse(values[0]);
            End = int.Parse(values[1]);
        }

        public int Start { get; set; }
        public int End { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}", Start, End);
        }
    }
}
