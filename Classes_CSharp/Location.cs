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
        public  string Description { get;  set; }

        public readonly List<Location> _locations = new List<Location>();
        

        public Location(Country country, string description, LocationType locType)
        {
            Country = country;
            Description = description;
            LocType = locType;
            AddToLocationList(this);
        }

        public void AddToLocationList(Location location)
        {
            if (_locations.Contains(location))
            {
                Console.WriteLine("There are this Locations in list");
            }
            else
            {
                _locations.Add(location);
            }
        }

        
    }
}
