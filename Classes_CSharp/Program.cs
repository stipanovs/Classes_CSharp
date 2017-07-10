using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;

namespace Classes_CSharp
{
        
    
    class Program
    {
        static void Main(string[] args)
        {
            Country moldova = new Country("Republica Moldova", 643, Region.EuropeUnion, "LEI");
            Country italia = new Country("Italia", 040, Region.EuropeUnion, "EUR");
            Country ucraina = new Country("Ucraina", 038, Region.EuropeUnion, "Grivna");
            Country russia = new Country("Russia", 038, Region.EuropeUnion, "RUB");

            List<Country> countries = new List<Country>();
            countries.Add(moldova);
            countries.Add(italia);
            countries.Add(ucraina);
            
            countries.Insert(0, new Country("Ungaria", 451, Region.EuropeUnion, "EUR"));
            Console.WriteLine(countries[0].Description);


            moldova.AddLocation("Chisinau", LocationType.City);
            moldova.AddLocation("Orhei", LocationType.Village);
            moldova.AddLocation("Cocieri", LocationType.City);
            italia.AddLocation("Milano", LocationType.City);
            italia.AddLocation("Rimini", LocationType.City);
            italia.AddLocation("Rome", LocationType.City);
            ucraina.AddLocation("Kiev", LocationType.City);
            Location moscow = new Location("Moscow", russia, LocationType.City);
            Location seliste = new Location("Seliste", moldova, LocationType.Village);
            
            
            // postarile de marfa
            Posts post1 = new Posts(new DateTime(2017, 7, 10), moldova, italia, 3700.00, "EUR");
            Posts post2 = new Posts(new DateTime(2017, 7, 14), italia, moldova, 2450.00, "EUR");

            var posts = new List<Posts>();
            posts.Add(post1);
            posts.Add(post2);
            foreach (var post in posts)
            {
                Console.WriteLine(post.ToString());
            }


            //foreach (var loc in russia._location)
            //{
            //  Console.WriteLine(loc.Description + " " + loc.Country.Description);
            //}


            Console.WriteLine();
                
            Console.ReadLine();
        }
    }
}
