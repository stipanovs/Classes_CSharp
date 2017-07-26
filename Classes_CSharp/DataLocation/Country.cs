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
        
        private readonly string _nationalCurrency;
        public string Name { get; private set; }
        public int CountryCode { get;  private set; }

        public Country(string name, int countryCode = 0, string currency = "null")
        {
            Name = name;
            CountryCode = countryCode;
            _nationalCurrency = currency;
        }

        public override string ToString()
        {
            return Name + " " + CountryCode + " " + _nationalCurrency;
        }
    }
}
