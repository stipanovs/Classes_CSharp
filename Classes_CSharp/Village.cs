using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Village : Location
    {
        
        
        public Village(string descr, Country country, int population) 
        {
            
        }

        public override Country Country {get; set; }
        public override string Description {get; set; }

        public override void AddToCountryList(Location loc)
        {
            if (Country._location.Contains(loc))
            {
                Console.WriteLine("There are this Locations in list");
            }
            else
            {
                Country._location.Add(loc);
            }
        }

    }
}
