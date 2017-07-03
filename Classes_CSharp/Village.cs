using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Village : City
    {
        public Village(string descr, Country country, int population)
            : base(descr, country, population)
        {
            
        }

        public override void PrintHistory(string history)
        {
            Console.WriteLine("Welcome to " + this.Description);
            base.PrintHistory(history);
            Console.WriteLine("Welcome to " + this.Description);
        }
    }
}
