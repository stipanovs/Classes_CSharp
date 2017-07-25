using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.DataLocation;
using Classes_CSharp.Enums;

namespace Classes_CSharp
{
    public class Location : EntityBase
    {
        public  Country Country { get;  set; }
        public IUnitLocality UnitLocality { get; set; }
        public string AddressDetail { get; set; }
        public readonly List<Location> _locations = new List<Location>();
        
        public Location(Country country, IUnitLocality unitLocality, string addressDetail)
        {
            Country = country;
            UnitLocality = unitLocality;
            AddressDetail = addressDetail;
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
