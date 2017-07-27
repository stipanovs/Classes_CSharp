using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.PostsModel;
using Microsoft.Scripting.Utils;


namespace Classes_CSharp
{
    public enum PostType
    {
       Cargo = 1,
       Transport
    }
    
    // static Fabric Methode - Type of product in dependece of params
    // polimorphic Fabric Methode - Interface, Concrete Fabric in dependece of params

    public class PostFactory
    {
        public Post CreateNewPost(DateTime dataFrom, DateTime dateTo, 
            Location locationFrom, Location locationTo, double price, long id, PostType type)
        {
            Post post = null;

            switch (type)
            {
                case PostType.Cargo:
                    post =  new PostCargo(dataFrom, dateTo, locationFrom, locationTo, price, id);
                    break;
                case PostType.Transport:
                    post =  new PostTransport(dataFrom, dateTo, locationFrom, locationTo, price, id);
                    break;
            }
            return post;
        }

    }
}
