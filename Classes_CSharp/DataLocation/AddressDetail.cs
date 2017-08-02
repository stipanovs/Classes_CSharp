using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.DataLocation
{
    public class AddressDetail
    {
        public string Index { get; set; }
        public string Street { get; set; }

        public AddressDetail(string index, string street)
        {
            Index = index;
            Street = street;
        }

        public override string ToString()
        {
            return $"{Index} {Street}";
        }
    }
}
