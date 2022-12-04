using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day4.Models
{
    internal class AssignmentPairing
    {
        private Section _a;
        private Section _b;

        public AssignmentPairing(Section a, Section b)
        {
            _a = a;
            _b = b;
        }


        public Section SectionA { get { return _a; } }
        public Section SectionB { get { return _b; } }

        public bool IsFullyContained()
        {
            //
            if (_a.Start >= _b.Start && _a.End <= _b.End
                || _b.Start >= _a.Start && _b.End <= _a.End)
            {
                return true;
            }

            return false;
        }

        public bool IsPartialOverlap()
        {
            //
            if (_a.End >= _b.Start && _a.End <= _b.End
                || _b.Start >= _a.Start && _b.End <= _a.End
                || _a.Start >= _b.Start && _a.Start <= _b.End
                || _b.End >= _a.Start && _b.End <= _a.End)
            {
                return true;
            }

            return false;
        }
    }
}
