using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Country
    {
        public string _region;
        private readonly string _nationalCurrency;
        public readonly List<Location> _location = new List<Location>();
        public string Description { get; private set; }
        private int Code { get;  set; }

        public Country(string description, int code, string region, string currency)
        {
            _region = region;
            _nationalCurrency = currency;
            Description = description;
            Code = code;
        }

        //public void AddCity(string description, int population, bool city)
        //{

        //    // if bool city == true  city else village
        //    //Country country = this;
        //    _location.Add(city ? new City(description, this, population) : 
        //        new Village(description, this, population));
        //}

        public void AddCity(string description, Country country, int population)
        {
            _location.Add(new City(description, country));
        }

        public void AddCity(City city)
        {
            _location.Add(city);
        }



    }
}
