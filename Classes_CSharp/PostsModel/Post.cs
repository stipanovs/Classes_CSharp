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
        public User User { get; set; }
        private DateTime PublicationDate () => DateTime.Now;
        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }
        public Locality LocationFrom { get; } 
        public Locality LocationTo { get; }

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
        public string AdditionalInformation { get; set; } 
           
        public Post(DateTime dataFrom, DateTime dateTo, 
            Locality localityFrom, Locality localityTo, double price, string additionalInformation, User user)
        {
            DateFrom = dataFrom;
            DateTo = dateTo;
            LocationFrom = localityFrom;
            LocationTo = localityTo;
            Price = price;
            AdditionalInformation = additionalInformation;
            User = user;
                 
        }

        #region Event
        public event EventHandler<PostPriceChangedEventArgs> PostPriceChanged; // The event
        public void OnPostPriceChanged(PostPriceChangedEventArgs e) // Notify register objects
        {
            if (PostPriceChanged != null)
            {
                PostPriceChanged(this, e); // delagate invoke()
            }
        }
        #endregion
        
        public override string ToString()
        {
            return $"{LocationFrom} - {LocationTo}, {DateFrom.ToShortDateString()}-{DateTo.ToShortDateString()}, {Price}";
        }
    }
}
