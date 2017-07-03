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
            Country moldova = new Country("EU", "Lei", "R. Moldova", 643);
            moldova.AddCity("Chisinau", 500000);
            moldova.AddCity("Orhei", 145000);


            //var citys = moldova._citys;
            foreach (var city in moldova._citys)
            {
                Console.WriteLine(city.Description + " " + city.Country.Description);
            }
            Console.WriteLine(moldova._citys.Count());
                
            Console.ReadLine();
        }
    }
}
