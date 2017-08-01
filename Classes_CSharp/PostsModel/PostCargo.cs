using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.PostsModel.SpecificationType;

namespace Classes_CSharp.PostsModel
{
    public class PostCargo : Post
    {
        public CargoSpecification Specification { get; set; }
       
        public PostCargo(DateTime dataFrom, DateTime dateTo, Location locationFrom,
            Location locationTo, double price, string description = "", CargoSpecification specification = null) 
            : base(dataFrom, dateTo, locationFrom, locationTo, price, description)
        {
            Specification = specification;
        }
    }
}
