using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.DataLocation;
using Classes_CSharp.Enums;
using Classes_CSharp.Repository;
using Classes_CSharp.Users;
using Classes_CSharp.Events;
using Classes_CSharp.Facade;
using Classes_CSharp.PostsModel;

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

        public static void ChangePostPrice(ref Post post, double price)
        {
            post.Price = price;
        }

        
        static void Main(string[] args)
        {
           
            var moldova = new Country("Moldova", 373, "LEI");
            var italia = new Country("Italia", 040, "EUR");
            var ucraina = new Country("Ucraina", 854, "UAH");
            var russia = new Country("Russia", 643, "RUB");
            var countries = new List<Country>(){moldova, italia, ucraina, russia};

            
            Location loc1_chisinau = new Location(moldova, new City("Chisinau"),"str. Titulescu 10/4 ap 61");
            Location loc_Bardar = new Location(moldova, new Village("Bardar"), "nu sunt strazi" );
            Location loc2_moscow = new Location(russia, new City("Moscow"), "adress detail");
            Location loc3_Rome = new Location(italia, new Village("Padovana"), "adress detail");
            Location loc4_Kiev = new Location(ucraina, new City("Kiev"), "adress detail");

            


            // ex. IEqualityComparer
            var dict = new Dictionary<Country, string>(new CountryEqalityComparer());
            // ex. Icomparer
            countries.Sort(new CountryComparer()); 
            

            // posting new information about Transport Freight 
            var post1 = new PostCargo();
            var post2 = new Post(new DateTime(2017, 7, 07), new DateTime(2017, 7, 09), loc2_moscow, loc3_Rome, 2450.00, 769898456);
            var post3 = new Post(new DateTime(2017, 7, 10), new DateTime(2017, 7, 12), loc4_Kiev, loc1_chisinau, 4100.00, 128978941);

            IPostType post4 = new PostCargo();
          
            
            post1.AddToRepository(post1);
            post1.AddToRepository(post2);
            post3.AddToRepository(post3);
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
            Repository<Country> countryRepository = new Repository<Country>();

            foreach (var c in countries)
            {
                countryRepository.SaveToFile(c, fileName);
            }

            FacadeClass facade1 = FacadeClass.Instance;
            FacadeClass facade2 = FacadeClass.Instance;
            
            

            facade1.CreatePost(true, post1);

            //Console.ReadLine();
        }
    }
}
