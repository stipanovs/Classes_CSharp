using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CargoLogistic.Domain
{
    public class Locality : EntityBase
    {
        
        public virtual LocalityPlace LocalityPlace { get; set; }
        public virtual AddressDetail AddressDetail { get; set; }
        
               
        public Locality(LocalityPlace localityPlace, AddressDetail addressDetail = null)
        {
            LocalityPlace = localityPlace;
            AddressDetail = addressDetail;
        }

        protected Locality()
        {

        }

        public override string ToString()
        {
            return $"{LocalityPlace.Country.Name}, {LocalityPlace?.Name}, {AddressDetail}" ;
        }
    }
}
