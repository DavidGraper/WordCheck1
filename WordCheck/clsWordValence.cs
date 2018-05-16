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
        public string Word { get; set; }
        public WordState State { get; set; }
    }
}
