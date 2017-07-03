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
        public List<City> _citys = new List<City>();
        public string Description { get; private set; }
        private int Code { get;  set; }

        public Country(string region, string currency, string description, int code)
        {
            _region = region;
            Description = description;
            Code = code;
            _nationalCurrency = currency;
        }

        public void AddCity(string description, int population)
        {
            Country country = this;
            if (country != null)
            {
                _citys.Add(new City(description, this, population));
            }
            else
            {
                Console.WriteLine("Obiectul nu este initializat!");
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



    }
}
