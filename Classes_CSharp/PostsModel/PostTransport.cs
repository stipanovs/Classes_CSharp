using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.PostsModel.SpecificationType;

namespace Classes_CSharp.PostsModel
{
    public class PostTransport : Post
    {
        public TransportSpecification Specification;
        public PostTransport(DateTime dataFrom, DateTime dateTo, Location locationFrom,
            Location locationTo, double price, string description = "", TransportSpecification transportSpecification = null) 
            : base(dataFrom, dateTo, locationFrom, locationTo, price, description)
        {
            Specification = transportSpecification;
        }
    }
}
