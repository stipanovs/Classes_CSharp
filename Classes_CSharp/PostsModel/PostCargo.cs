using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.PostsModel
{
    public class PostCargo : Post, IPostType
    {
        public PostCargo(DateTime dataFrom, DateTime dateTo, Location locationFrom,
            Location locationTo, double price, long id, string description = "") 
            : base(dataFrom, dateTo, locationFrom, locationTo, price, id, description)
        {
            
        }
    }
}
