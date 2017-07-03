using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
        
    
    class Program
    {
        static void Main(string[] args)
        {
            Country moldova = new Country("R. Moldova", 643, "EUROPE", "LEI");
            moldova.AddCity("Chisinau", 500000, true);
            moldova.AddCity("Orhei", 145000, true);
            moldova.AddCity("Cocieri", 3452, false);
            
            Village izbiste = new Village("Izbiste", moldova, 4512);
            //izbiste.DistanceToCapital = 200;


            //var citys = moldova._citys;
            foreach (var city in moldova._citys)
            {
                Console.WriteLine(city.Description + " " + city.Country.Description);
            }
            
            izbiste.PrintHistory("A fost odata ...", "Ion Creanga");
            Console.WriteLine();
                
            Console.ReadLine();
        }
    }
}
