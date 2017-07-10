using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    class CountryEqalityComparer : IEqualityComparer<Country>
    {
        public bool Equals(Country x, Country y)
        {
            return x.Description == y.Description && x.Code == y.Code;
        }

        public int GetHashCode(Country obj)
        {
            return (obj.Description + ";" + obj.Code).GetHashCode();
        }
    }
}
