using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoLogistic.DataLocation;

namespace CargoLogistic
{
    public class Locality : EntityBase
    {
        
        public ILocalityPlace LocalityPlace { get; set; }
        public AddressDetail AddressDetail { get; set; }
        public string FullAddressLocation () => string.Format("{0}, {1}, {2}", LocalityPlace.Country.Name, LocalityPlace.Name, AddressDetail.ToString());

               
        public Locality(ILocalityPlace unitLocality, AddressDetail addressDetail = null)
        {
            LocalityPlace = unitLocality;
            AddressDetail = addressDetail;
        }

        
        public override string ToString()
        {
            return $"{LocalityPlace.Country.Name}, {LocalityPlace?.Name}, {AddressDetail}" ;
        }
    }
}
