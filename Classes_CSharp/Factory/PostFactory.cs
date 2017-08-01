using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.PostsModel;
using Classes_CSharp.PostsModel.SpecificationType;
using Microsoft.Scripting.Utils;


namespace Classes_CSharp
{
    
    public class PostFactory
    {
        
        public Post CreateNewPost(DateTime dataFrom, DateTime dateTo,
            Location locationFrom, Location locationTo, double price, string description,
            ISpecification specification)
        {
            Post post = null;

            if (specification is CargoSpecification)
            {
                post = new PostCargo(dataFrom, dateTo, locationFrom, locationTo, price, description, (CargoSpecification)specification);
            }
            else if (specification is TransportSpecification)
            {
                post = new PostTransport(dataFrom, dateTo, locationFrom, locationTo, price, description, (TransportSpecification)specification);
            }
            return post;
        }

    }
}
