using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    class PriorityComparer : IComparer<Country>
    {
        public int Compare(Country x, Country y)
        {
            if (Equals(x, y)) return 0;
            return x.Code.CompareTo(y.Code);
        }
        
    }
}
