using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class CompareWeight : IComparer<Program.Animal>
    {
        private bool _descending;

        public CompareWeight(bool descending)
        {
            _descending = descending;
        }

        public int Compare(Program.Animal x, Program.Animal y)
        {
            if (x == null || y == null) return 0;

            int result = x.Weight.CompareTo(y.Weight);

            // flip result if descending
            return _descending ? -result : result;
        }
    }
}
