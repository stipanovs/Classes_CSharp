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
        private Country _countryFrom;
        private Country _countryIn;
        //private int _distance;
        //private int _weight;
        private double _price;
        private string _currency;
        //private string typeOfGoods;
        //private string _typeOfTruck;
        //private string _description;

        public Posts(DateTime upToDate, Country countryFrom, Country countryIn, double price, string currecy)
        {
            _upToDate = upToDate;
            _countryFrom = countryFrom;
            _countryIn = countryIn;
            _price = price;
            _currency = currecy;
        }


        public void PrintPost()
        {
            Console.WriteLine(_countryFrom.Description + "-" + _countryIn.Description + " : " + _price);
        }

        public override string ToString()
        {
            return _countryFrom.Description + "-" + _countryIn.Description + " : " + _price + _currency;
        }
    }
}
