using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Posts
    {
        private readonly DateTime _dataPublication = DateTime.Now;
        private DateTime _upToDate;
        public Country CountryFrom { get; private set;}
        public Country CountryIn { get; private set; }
        //private int _distance;
        //private int _weight;
        public double Price { get; private set; }
        private string _currency;
        //private string typeOfGoods;
        //private string _typeOfTruck;
        //private string _description;

        public Posts(DateTime upToDate, Country countryFrom, Country countryIn, double price, string currecy)
        {
            _upToDate = upToDate;
            CountryFrom = countryFrom;
            CountryIn = countryIn;
            Price = price;
            _currency = currecy;
        }


        public void PrintPost()
        {
            Console.WriteLine(CountryFrom.Description + "-" + CountryIn.Description + " : " + Price);
        }

        public override string ToString()
        {
            return CountryFrom.Description + "-" + CountryIn.Description + " : " + Price + _currency;
        }
    }
}
