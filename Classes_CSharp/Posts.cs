using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Events;

namespace Classes_CSharp
{
    public class Posts
    {
        private readonly DateTime _dataPublication = DateTime.Now;
        public DateTime FromDate { get; private set; }
        public DateTime UpToDate { get; private set; }
        public Country CountryFrom { get; private set;}
        public Country CountryIn { get; private set; }
        public long ID { get; private set; }
        private string _currency = "eur";
        private double _price;
        public static int _copies = 0;
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

        public Posts(DateTime fromDate, DateTime upToDate, Country countryFrom, Country countryIn, double price, long id)
        {
            FromDate = fromDate;
            UpToDate = upToDate;
            CountryFrom = countryFrom;
            CountryIn = countryIn;
            Price = price;
            ID = id;
            EditCurrency(ref _currency);
            _copies++;
        }

        public event EventHandler<PostPriceChangedEventArgs> PostPriceChanged; // The event
        
        public virtual void OnPostPriceChanged(PostPriceChangedEventArgs e) // Notify register objects
        {
            if (PostPriceChanged != null)
            {
                PostPriceChanged(this, e); // delagate invoke()
            }
        }

        
        public static void EditCurrency(ref string str)// ex. ref
        {
           
            str = "$$ " + str.ToUpper() + " $$";
        }


        public override string ToString()
        {
            return CountryFrom.Description + "-" + CountryIn.Description + " : " + (int)Price + " " + _currency; 
        }
    }
}
