using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Village : Location
    {
        
        public Village(string descr, Country country)
        {
            Description = descr;
            Country = country;
            AddToCountryList(country, this);
        }

        public override Country Country {get; set; }
        public override string Description {get; set; }

        public override void AddToCountryList(Country country, Location loc)
        {
            if (country._location.Contains(loc))
            {
                Console.WriteLine("There are this Locations in list");
            }
            else
            {
                country._location.Add(loc);
            }
        }

    }
}
