using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;
using Classes_CSharp.Events;
using Classes_CSharp.Models;
using Classes_CSharp.Repository;
using Classes_CSharp.Users;

namespace Classes_CSharp
{
    public class Post : EntityBase
    {
        public User _user;
        private readonly DateTime _publicationDate = DateTime.Now;
        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }
        public Location LocationFrom { get; } 
        public Location LocationTo { get; }
        private double _price;
        public readonly Repository<Post> _allPosts = new Repository<Post>();
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price == value)
                {
                    return;
                }

                if (_price < value)
                    OnPostPriceChanged(new PostPriceChangedEventArgs(Price, value, ID));
                _price = value;
            }
        }

        public Post(DateTime dataFrom, DateTime dateTo, Location locationFrom, Location locationTo,  double price, long id)
        {
            DateFrom = dataFrom;
            DateTo = dateTo;
            LocationFrom = locationFrom;
            LocationTo = locationTo;
            Price = price;
            ID = id;
        }

        public Post()
        {
            
        }

        public event EventHandler<PostPriceChangedEventArgs> PostPriceChanged; // The event
        public void OnPostPriceChanged(PostPriceChangedEventArgs e) // Notify register objects
        {
            if (PostPriceChanged != null)
            {
                PostPriceChanged(this, e); // delagate invoke()
            }
        }
        
        public void AddToRepository(Post post)
        {
            var allpost = _allPosts.GetAll();
            if (allpost != null && allpost.Contains(post)) _allPosts.Create(post);
        }
        
    }
}
