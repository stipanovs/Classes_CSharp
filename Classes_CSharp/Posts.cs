using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Posts
    {
        private readonly DateTime _dataPublication;
        private DateTime _upToDate;
        private Country _countryFrom;
        private Country _countryIn;
        //private int _distance;
        //private int _weight;
        private double _price;
        //private string typeOfGoods;
        //private string _typeOfTruck;
        //private string _description;

        public Posts(DateTime datePublication, DateTime upToDate,
            Country countryFrom, Country countryIn, double price)
        {
            _dataPublication = datePublication;
            _upToDate = upToDate;
            _countryFrom = countryFrom;
            _countryIn = countryIn;
            _price = price;
        }
            





    }
}
