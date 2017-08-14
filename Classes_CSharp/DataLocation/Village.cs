using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLogistic.DataLocation
{
    public class Village : EntityBase, ILocalityPlace
    {
        public string Name  { get;  set; }
        public Country Country { get;  set; }

        public Village(string name, Country country)
        {
            Name = name;
            Country = country;
        }
    }
}
