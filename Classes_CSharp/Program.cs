using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;
using Classes_CSharp.Repository;

namespace Classes_CSharp
{
        
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = Country.SetData();

            foreach (var country in countries)
            {
                Console.WriteLine(country.ToString());
            }

            var moldova = countries[0];
            var italia = countries[1];
            var ucraina = countries[2];
            var russia = countries[3];

            moldova.AddLocation("Chisinau", LocationType.City);
            moldova.AddLocation("Orhei", LocationType.Village);
            moldova.AddLocation("Cocieri", LocationType.City);
            italia.AddLocation("Milano", LocationType.City);
            italia.AddLocation("Rimini", LocationType.City);
            italia.AddLocation("Rome", LocationType.City);
            ucraina.AddLocation("Kiev", LocationType.City);

            // ex. Icomparer
            countries.Sort(new CountryComparer()); 

            Console.WriteLine();
            foreach (var country in countries)
            {
                Console.WriteLine(country.ToString());
            }

            




            countries.Insert(0, new Country("Ungaria", 451, Region.EuropeUnion, "EUR"));

            Console.WriteLine(countries[0].Description);


            var moscow = new Location("Moscow", russia, LocationType.City);
            var seliste = new Location("Seliste", moldova, LocationType.Village);


            // postarile de marfa
            var post1 = new Posts(new DateTime(2017, 7, 10), moldova, italia, 3700.00, "EUR");
            var post2 = new Posts(new DateTime(2017, 7, 14), italia, moldova, 2450.00, "EUR");

            


            
                
            Console.ReadLine();
        }
    }
}
