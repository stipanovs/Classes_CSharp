using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;
using Classes_CSharp.Events;
using Classes_CSharp.Models;
using Classes_CSharp.Repository;

namespace Classes_CSharp
{
    public class Posts : EntityBase
    {
        private readonly DateTime _publicationDate = DateTime.Now;
        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }
        public Location LocationFrom { get; } 
        public Location LocationTo { get; }
        public Cargo<CargoTypes> CargoType { get; set; }
        public long ID { get; private set; }
        private string _currency = "eur";
        private double _price;
        public static int _copies = 0;
        public readonly Repository<Posts> _allPosts = new Repository<Posts>();
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

        public Posts(DateTime dataFrom, DateTime dateTo, Location locationFrom, Location locationTo,  double price, long id)
        {
            DateFrom = dataFrom;
            DateTo = dateTo;
            LocationFrom = locationFrom;
            LocationTo = locationTo;
            Price = price;
            ID = id;
            EditCurrency(ref _currency);
            _copies++;
            //AddToRepository(this);


        }

        public Posts()
        {
            
        }

        public event EventHandler<PostPriceChangedEventArgs> PostPriceChanged; // The event
        
        public virtual void OnPostPriceChanged(PostPriceChangedEventArgs e) // Notify register objects
        {
            if (PostPriceChanged != null)
            {
                PostPriceChanged(this, e); // delagate invoke()
            }
        }

        public Posts CreatePost()
        {
            return new Posts();
        }

        public void AddToRepository(Posts post)
        {
           _allPosts.Create(post);
        }
        
        public static void EditCurrency(ref string str)// ex. ref
        {
           
            str = "$$ " + str.ToUpper() + " $$";
        }

        
    }

    public class Posts1
    {
    }
}
