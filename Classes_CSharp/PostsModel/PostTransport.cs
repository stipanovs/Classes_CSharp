using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.PostsModel
{
    public class PostTransport : Post
    {
        public PostTransport(DateTime dataFrom, DateTime dateTo, Location locationFrom,
            Location locationTo, double price, long id, string description = "") 
            : base(dataFrom, dateTo, locationFrom, locationTo, price, id, description)
        {

        }
    }
}
