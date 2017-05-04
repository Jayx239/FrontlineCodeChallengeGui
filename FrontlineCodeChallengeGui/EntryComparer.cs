using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineCodeChallenge
{
    /* Comparer class for comparing two Entry objects */
    public class EntryComparer : IComparer<Entry>
    {
        public int Compare(Entry entryA, Entry entryB)
        {
            if (entryB == null)
                return 1;

            return entryA.GetValue().CompareTo(entryB.GetValue());
        }
    }
}
