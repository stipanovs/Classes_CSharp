using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Events;
using Classes_CSharp.Models;
using Classes_CSharp.Repository;
using Classes_CSharp.Users;

namespace Classes_CSharp
{
    public abstract class Post : EntityBase
    {
        public User _user;
        private readonly DateTime _publicationDate = DateTime.Now;
        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }
        public Location LocationFrom { get; } 
        public Location LocationTo { get; }
        private double _price;

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

        public string Description { get; }
           
        public Post(DateTime dataFrom, DateTime dateTo, Location locationFrom,
            Location locationTo,  double price, long id , string description = "")
        {
            DateFrom = dataFrom;
            DateTo = dateTo;
            LocationFrom = locationFrom;
            LocationTo = locationTo;
            Price = price;
            ID = id;
            Description = description;
        }
       
        public event EventHandler<PostPriceChangedEventArgs> PostPriceChanged; // The event
        public void OnPostPriceChanged(PostPriceChangedEventArgs e) // Notify register objects
        {
            if (PostPriceChanged != null)
            {
                PostPriceChanged(this, e); // delagate invoke()
            }
        }
        
       public override string ToString()
        {
            return string.Format("{0} - {1}: {2}", LocationFrom.Country.Name, LocationTo.Country.Name, Price);
        }
    }
}
