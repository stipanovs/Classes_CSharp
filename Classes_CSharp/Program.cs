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
            Country moldova = new Country("Republica Moldova", 643, "EUROPE", "LEI");
            Country italia = new Country("Italia", 040, "EUROPE", "EUR");
            Country ucraina = new Country("Ucraina", 038, "EUROPE", "Grivna");
            Country russia = new Country("Russia", 038, "EURASIA", "RUB");

            moldova.AddLocation("Chisinau");
            moldova.AddLocation("Orhei");
            moldova.AddLocation("Cocieri");
            italia.AddLocation("Milano");
            italia.AddLocation("Rimini");
            italia.AddLocation("Rome");
            ucraina.AddLocation("Kiev");
            City moscova = new City("Moscova", russia);
            Village seliste = new Village("Seliste", moldova); 
            
            // postarile de marfa
            Posts post1 = new Posts(new DateTime(2017, 7, 10), moldova, italia, 3700.00, "EUR");
            Posts post2 = new Posts(new DateTime(2017, 7, 14), italia, moldova, 2450.00, "EUR");

            //var posts = new List<Posts>();
            //posts.Add(post1);
            //posts.Add(post2);
            //foreach (var post in posts)
            //{
            //    Console.WriteLine(post.ToString());
            //}
            

            foreach (var loc in russia._location)
            {
              Console.WriteLine(loc.Description + " " + loc.Country.Description);
            }


            Console.WriteLine();
                
            Console.ReadLine();
        }
    }
}
