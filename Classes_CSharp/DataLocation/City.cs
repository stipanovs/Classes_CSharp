using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.DataLocation
{
    public class City : EntityBase, ILocalityPlace
    {
        public Country Country { get; set; }
        public string Name { get; set; }

        public City(string name, Country country)
        {
            Name = name;
            Country = country;
        }
    }
}
