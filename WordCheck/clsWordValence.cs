using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCheck
{
    public class clsWordValence
    {
        public enum WordState
        {
            added,
            correct,
            skipped,
            unknown
        };

        // Initialize
        public clsWordValence(string StringIn, WordState Valence)
        {
            Word = StringIn;
            State = Valence;
        }

        // Properties
        public string Word { get; set; }
        public WordState State { get; set; }
    }
}
