using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLogistic.Domain
{
    public class AddressDetail
    {
        public virtual string ZipCode { get; private set; }
        public virtual string Street { get; set; }

        public AddressDetail(string zipCode, string street)
        {
            ZipCode = zipCode;
            Street = street;
        }

        public override string ToString()
        {
            return $"{ZipCode}, {Street}";
        }
    }
}
