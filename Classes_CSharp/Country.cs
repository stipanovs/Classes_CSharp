using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;

namespace Classes_CSharp
{
    public class Country : EntityBase
    {
        readonly Region _region;
        private int? _population = null;   //for example 
        private readonly string _nationalCurrency;
        private readonly List<Location> _location = new List<Location>();
        public string Description { get; private set; }
        public int Code { get;  private set; }
        public override long ID { get; protected set; }

        public Country(string description, int code, Region region, string currency)
        {
            _region = region;
            _nationalCurrency = currency;
            Description = description;
            Code = code;
        }

        
        public void AddLocation(string description, LocationType locType)
        {
            
            Location newLocation = new Location(description, this, locType);
            if (!_location.Contains(newLocation)) _location.Add(newLocation);
        }

        public void AddLocation(Location loc)
        {
            if (!_location.Contains(loc)) _location.Add(loc);
        }

        public List<Location> GetAllLocations()
        {
            return _location;
        }

        public static List<Country> SetData()
        {
            return new List<Country>()
            {
                new Country("Republica Moldova", 643, Region.EuropeUnion, "LEI"),
                new Country("Italia", 974, Region.EuropeUnion, "EUR"),
                new Country("Ucraina", 745, Region.EuropeUnion, "Grivna"),
                new Country("Russia", 647, Region.CSI, "RUB"),
                new Country("Belorusia", 651, Region.CSI, "BYR")
            };
        }
            

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}",
                Description, _region, _nationalCurrency, _population.HasValue ? _population.Value.ToString() : "Undefined"); 
        }
    }
}
