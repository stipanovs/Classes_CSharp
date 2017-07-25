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
        public string Name { get; private set; }
        public int CountryCode { get;  private set; }

        public Country(string name, int countryCode, Region region, string currency)
        {
            Name = name;
            CountryCode = countryCode;
            _region = region;
            _nationalCurrency = currency;
            
        }
        
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}",
                Name, _region, _nationalCurrency, _population.HasValue ? _population.Value.ToString() : "Undefined"); 
        }
    }
}
