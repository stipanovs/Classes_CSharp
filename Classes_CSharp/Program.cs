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

            moldova.AddCity("Chisinau", moldova, 500000);
            moldova.AddCity("Orhei", moldova, 145000);
            moldova.AddCity("Cocieri", moldova, 3452);
            italia.AddCity("Milano",italia, 1500000);
            italia.AddCity("Rome", italia, 2451000);
            ucraina.AddCity("Kiev", ucraina, 2450000);

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


            //foreach (var city in moldova._location)
            //{
            //    Console.WriteLine(city.Description + " " + city.Country.Description);
            //}
            
            //izbiste.PrintHistory("A fost odata ...", "Ion Creanga");
            //Console.WriteLine();
                
            Console.ReadLine();
        }
    }
}
