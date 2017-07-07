using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Country
    {
        private Region _region;
        private readonly string _nationalCurrency;
        public readonly List<Location> _location = new List<Location>();
        public string Description { get; private set; }
        private int Code { get;  set; }

        public Country(string description, int code, Region region, string currency)
        {
            _region = region;
            _nationalCurrency = currency;
            Description = description;
            Code = code;
        }

        //public void AddLocation(string description, int population, bool city)
        //{

        //    // if bool city == true  city else village
        //    //Country country = this;
        //    _location.Add(city ? new City(description, this, population) : 
        //        new Village(description, this, population));
        //}

        public void AddLocation(string description)
        {
            
            City newLocation = new City(description, this);
            if (!_location.Contains(newLocation)) _location.Add(newLocation);
        }

        public void AddLocation(Location loc)
        {
            if (!_location.Contains(loc)) _location.Add(loc);
        }
    }
}
