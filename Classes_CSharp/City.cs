using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class City
    {
        public readonly int _population;
        public string Description { get; private set; }
        public Country Country { get; private set; }

        public City(string descr, Country country, int population)
        {
            Description = descr;
            Country = country;
            _population = population;
        }

        public virtual void PrintHistory(string history)
        {
            Console.WriteLine(history);
        }

        public virtual void PrintHistory(string history, string author)
        {
            Console.WriteLine(history);
            Console.WriteLine(author);
        }
    }
}
