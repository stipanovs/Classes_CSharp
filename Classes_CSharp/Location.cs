using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public abstract class  Location
    {
        public abstract Country Country { get; set; }
        public abstract string Description { get; set; }

        public abstract void AddToCountryList(Country country,Location loc);

    }
}
