using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day6
{
    internal class Transmission
    {
        private string _inputText;

        public Transmission(string inputText)
        {
            this._inputText = inputText;
        }

        public int GetUniqueItemsProcessed(int requiredUniquePatternCount)
        {
            for(int index = (requiredUniquePatternCount-1); index < _inputText.Length; index++)
            {  
                if(IsUniqueString(_inputText.Substring(index-(requiredUniquePatternCount-1), requiredUniquePatternCount)))
                {
                    return index + 1;
                }
            }

            return 0;
        }

        public bool IsUniqueString(string input)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (char c in input)
            {
                if (set.Contains(c))
                {
                    return false;
                }
                else
                {
                    set.Add(c);
                }
            }

            return true;
        }
    }
}
