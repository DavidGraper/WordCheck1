using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCheck
{
    public class clsWordMatch
    {
        // Initialize
        public clsWordMatch(string StringIn, int? MatchingPosition)
        {
            Word = StringIn;
            MatchPosition = MatchingPosition; 
        }

        // Properties
        public string Word { get; set; }
        public int? MatchPosition { get; set; }
    }
}
