using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoLogistic.PostsModel.SpecificationType;
using CargoLogistic.Users;

namespace CargoLogistic.PostsModel
{
    public class PostTransport : Post
    {
        public TransportSpecification Specification;
        public PostTransport(DateTime dataFrom, DateTime dateTo, Locality locationFrom,
            Locality locationTo, double price, string additionalInformation, TransportSpecification transportSpecification = null, User user = null) 
            : base(dataFrom, dateTo, locationFrom, locationTo, price, additionalInformation, user)
        {
            Specification = transportSpecification;
        }
    }
}
