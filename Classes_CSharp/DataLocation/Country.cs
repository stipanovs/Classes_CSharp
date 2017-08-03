using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLogistic
{
    public class Country : EntityBase
    {
        public string Name { get; private set; }
        public int NumericCode { get;  private set; }
        public string Alpha2Code { get; set; }

        public Country(string name, int digitalCode = 0, string isoCode = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name) + " is null or whitespace");
            }
            Name = name;
            NumericCode = digitalCode;
            Alpha2Code = isoCode;
        }

        public override string ToString()
        {
            return $"Name: {Name}, IsoCode: {Alpha2Code}";
        }
    }
}
