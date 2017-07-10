using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;

namespace Classes_CSharp
{
    public class Country : EntityBase // IEqualityComparer<Country>
    {
        private Region _region;
        public int? _population ; //for example 
        private readonly string _nationalCurrency;
        public readonly List<Location> _location = new List<Location>();
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

        public bool Equals(Country x, Country y)
        {
            return x.Description == y.Description && x.Code == y.Code;
        }

        public int GetHashCode(Country obj)
        {
            return (obj.Description + ";" + obj.Code).GetHashCode();
        }

        public override string ToString()
        {
            
            return String.Format("{0} {1} {2} {3}",
                Description, _region, _nationalCurrency, _population.HasValue ? _population.Value.ToString() : "Undefined");
        }
    }
}
