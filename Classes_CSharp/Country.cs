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
        public readonly string _nationalCurrency;
        public readonly List<City> _citys = new List<City>();
        public string Description { get; private set; }
        private int Code { get;  set; }

        public Country(string description, int code, string region, string currency)
        {
            _region = region;
            Description = description;
            Code = code;
            _nationalCurrency = currency;
        }

        public void AddCity(string description, int population, bool city)
        {
            // if bool city == true  city else village
            Country country = this;
            if (country != null & city == true)
            {
                _citys.Add(new City(description, this, population));
            }
            else if(country != null & city != true)
            {
                _citys.Add(new Village(description, this, population));
            }
        }

        public void AddCity(string description, Country country, int population)
        {
            
            if (country != null)
            {
                _citys.Add(new City(description, country, population));
            }
            else
            {
                Console.WriteLine("Country nu este initializat!");
            }
        }

        public void AddCity(City city)
        {
            _citys.Add(city);
        }



    }
}
