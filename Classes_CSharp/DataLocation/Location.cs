using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.DataLocation;

namespace Classes_CSharp
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

        //public void AddToLocationList(Locality location)
        //{
        //    if (_locations.Contains(location))
        //    {
        //        Console.WriteLine($"This Location: {location.FullAddressLocation()} is content in the list.");
        //    }
        //    else
        //    {
        //        _locations.Add(location);
        //    }
        //}

        public override string ToString()
        {
            return $"{LocalityPlace.Country.Name}, {LocalityPlace?.Name}, {AddressDetail}" ;
        }
    }
}
