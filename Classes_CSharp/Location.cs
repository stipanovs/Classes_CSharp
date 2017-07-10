using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;

namespace Classes_CSharp
{
    public class Location : EntityBase
    {
        private LocationType LocType { get; set; }
        private  Country Country { get;  set; }
        public  string Description { get; private set; }
        public override long ID { get; protected set; }

        public Location(string description, Country country, LocationType locType)
        {
            Description = description;
            Country = country;
            LocType = locType;
            AddToCountryList(country, this);

        }

        public void AddToCountryList(Country country, Location loc)
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
