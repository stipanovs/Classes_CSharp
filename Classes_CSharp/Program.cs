using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;
using Classes_CSharp.Repository;
using Classes_CSharp.Users;
using Classes_CSharp.Events;
using Classes_CSharp.Facade;
namespace Classes_CSharp
{
    
    class Program
    {
        public static void Foo(string hello)
        {
            Console.WriteLine(hello + ", World");
        }
        
        
        public static void TextCountryToPrint(out string str, Country country)
        {
            str = country.ToString();
        }

        public static void ChangePostPrice(ref Posts post, double price)
        {
            post.Price = price;
        }

        
        static void Main(string[] args)
        {
           
            
            var moldova = new Country("Moldova", 373, Region.EuropeUnion, "LEI");
            var italia = new Country("Italia", 040, Region.EuropeUnion, "EUR");
            var ucraina = new Country("Ucraina", 854, Region.EuropeUnion, "UAH");
            var russia = new Country("Russia", 643, Region.EuropeUnion, "RUB");

            var countries = new List<Country>(){moldova, italia, ucraina, russia};


            // use Enums LocationType
            
            
            Location loc1_chisinau = new Location(moldova, "Chisinau, str Titulescu 10/4", LocationType.City);
            Location loc2_moscow = new Location(russia, "Moscow, str naberejnaia 45/5", LocationType.City);
            Location loc3_Rome = new Location(italia, "Rome, str Cesar ", LocationType.City);
            Location loc4_Kiev = new Location(ucraina, "Kiev, str Esenin 45/6", LocationType.City);

            


            // ex. IEqualityComparer
            var dict = new Dictionary<Country, string>(new CountryEqalityComparer());
            // ex. Icomparer
            countries.Sort(new CountryComparer()); 
            

            // posting new information about Transport Freight 
            var post1 = new Posts(new DateTime(2017, 7, 10), new DateTime(2017, 7, 14), loc1_chisinau, loc2_moscow, 3700.00, 154565435);
            var post2 = new Posts(new DateTime(2017, 7, 07), new DateTime(2017, 7, 09), loc2_moscow, loc3_Rome, 2450.00, 769898456);
            var post3 = new Posts(new DateTime(2017, 7, 10), new DateTime(2017, 7, 12), loc4_Kiev, loc1_chisinau, 4100.00, 128978941);
            
            //Console.WriteLine(post1);
            //Console.WriteLine(post2);
            // new users 
            User user1 = new User("Stipanov", "Sergiu", 35);
            User user2 = new User("Maracuta", "Andrei", 27);
            
            //// subscribe to event price rice
            //user1.RegisterToEvent(post1);
            //user2.RegisterToEvent(post1);

            //// Register weak events by WeakEventManager
            //user1.RegisterToEventWeakMethod(post2); 
            //user1.RegisterToEventWeakMethod(post3);

            //// simulate change price
            //post1.Price = 3750;
            //post2.Price = 2550;
            //Console.WriteLine();

            //// UnregisterToEvent
            //user2.UnregisterToEvent(post1);
            //user1.UnregisterToEventWeakMethod(post3);
            
            //// simulate change price
            //post1.Price = 3800;
            

            // save countries to file
            string fileName= @"C:\Users\sergiu.stipanov\OneDrive\Materiale\files\Repository.txt";
            Repository<Country> repository = new Repository<Country>();

            foreach (var c in countries)
            {
                repository.SaveToFile(c, fileName);
            }

            FacadeClass facade1 = FacadeClass.Instance;
            FacadeClass facade2 = FacadeClass.Instance;

            facade1.CreatePost(true, post1);

            Console.ReadLine();
        }
    }
}
