﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.Events
{
    public class PostPriceChangedEventArgs : EventArgs
    {
        public double LastPrice { get; private set; }
        public double NewPrice { get; private set; }
        public long ID { get; private set; }

        public PostPriceChangedEventArgs(double lastPrice, double newPrice, long id)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
            ID = id;
        }
    }
}
