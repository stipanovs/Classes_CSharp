using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes_CSharp
{
    public interface IPostOptions
    {
        IPostOptions WithFullDescription(string description);
        string GetDescription();
    }

    public class PostOptions : IPostOptions
    {
        private string _description;

        public string GetDescription()
        {
            return _description;
        }

        public IPostOptions WithFullDescription(string fullDescription)
        {
            _description = fullDescription;
            return this;
        }
    }
    public class PostFactory
    {
        public Post CreateNewPost(DateTime dataFrom, DateTime dateTo, 
            Location locationFrom, Location locationTo, double price, long id)
        {
            var options = new PostOptions();
            string description = options.GetDescription();
            if (string.IsNullOrWhiteSpace(description))
                description = "No Description available";

            var post = new Post(dataFrom, dateTo, locationFrom, locationTo, price, id, description);
            
            return post;
        }
    }
}
