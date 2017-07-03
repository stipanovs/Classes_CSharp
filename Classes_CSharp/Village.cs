using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Village : City
    {
        private int _distanceToCapital;

        public int DistanceToCapital
        {
            get { return _distanceToCapital; }
            set{_distanceToCapital = value * 2;}
        }
        public Village(string descr, Country country, int population)
            : base(descr, country, population)
        {
            
        }

        public override void PrintHistory(string history)
        {
            Console.WriteLine("Welcome to " + Description);
            base.PrintHistory(history);
            
        }
    }
}
