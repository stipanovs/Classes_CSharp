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
            moldova.AddCity("Chisinau", 500000, true);
            moldova.AddCity("Orhei", 145000, true);
            moldova.AddCity("Cocieri", 3452, false);
            italia.AddCity("Milano", 1500000, true);
            italia.AddCity("Rome", italia, 2451000);

            Village seliste = new Village("Seliste", moldova, 4512); // de facut sa se duca in List<city> la Country
            seliste.AddToCountryList(seliste);
            
            Posts post1 = new Posts(new DateTime(2017, 7, 10), moldova, italia, 3700.00, "EUR");
            Posts post2 = new Posts(new DateTime(2017, 7, 14), italia, moldova, 2450.00, "EUR");

            var posts = new List<Posts>();
            posts.Add(post1);
            posts.Add(post2);
            foreach (var post in posts)
            {
                Console.WriteLine(post.ToString());
            }


            //foreach (var city in moldova._citys)
            //{
            //    Console.WriteLine(city.Description + " " + city.Country.Description);
            //}
            
            //izbiste.PrintHistory("A fost odata ...", "Ion Creanga");
            //Console.WriteLine();
                
            Console.ReadLine();
        }
    }
}
