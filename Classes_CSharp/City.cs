using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class City : Location
    {
        private readonly int _population;
        public override string Description { get; set; }
        public override Country Country { get; set; }

        public City(string descr, Country country)
        {
            Description = descr;
            Country = country;
        }

        public override void AddToCountryList(Location loc)
        {
            if (Country._location.Contains(loc))
            {
                Console.WriteLine("There are this Locations in list");
            }
            else
            {
                Country._location.Add(loc);
            }
         }
        public void PrintHistory(string history)
        {
            Console.WriteLine(history);
        }

        public void PrintHistory(string history, string author)
        {
            Console.WriteLine(history);
            Console.WriteLine(author);
        }
    }
}
