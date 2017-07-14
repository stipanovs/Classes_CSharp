using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.Events
{
    public class PostPriceChangedEventArgs : EventArgs
    {
        public readonly double LastPrice, NewPrice;
        public readonly long ID;

        public PostPriceChangedEventArgs(double lastPrice, double newPrice, long id)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
            ID = id;
        }
    }
}
