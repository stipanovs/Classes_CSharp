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
using IronPython.Hosting;
using static System.Console;


namespace Classes_CSharp
{
   class Program
    {
       
        static void Main(string[] args)
        {
            #region countries

            var moldova = new Country("Moldova", 373, "LEI");
            var italia = new Country("Italia", 040, "EUR");
            var ucraina = new Country("Ucraina", 854, "UAH");
            var russia = new Country("Russia", 643, "RUB");
            var countries = new List<Country>() { moldova, italia, ucraina, russia };
            
            #endregion
            

            Location locChisinau = new Location(moldova, new City("Chisinau"),"str. Titulescu 10/4 ap 61");
            Location locBardar = new Location(moldova, new Village("Bardar"), "nu sunt strazi" );
            Location locMoscow = new Location(russia, new City("Moscow"));
            Location locRome = new Location(italia, new Village("Padovana"));
            Location locKiev = new Location(country: ucraina, unitLocality: new City("Kiev"));

            #region Dynamic

            //var PythonRuntime = Python.CreateRuntime();
            //dynamic pythonFile = PythonRuntime.UseFile("Test.py");
            //dynamic resultFromPythonTest = pythonFile.SummNumbersInRange(50);
            //Console.WriteLine(resultFromPythonTest);
            
            //// import Countries from Python file
            //dynamic countryList = pythonFile.country_list;

            //for (int i = 0; i < countryList.Count; i++)
            //{
            //    countries.Add(new Country(countryList[i].name, countryList[i].code));
            //}

            //foreach (var c in countries)
            //{
            //   WriteLine(c.Name);
            //}

            //Console.ReadKey();

            #endregion

            #region NameOf

            
            #endregion

            #region Comparer

            //// ex. IEqualityComparer
            //var dict = new Dictionary<Country, string>(new CountryEqalityComparer());
            //// ex. Icomparer
            //countries.Sort(new CountryComparer());


            #endregion

            // posting new information about Transport Freight 
            var post1 = new PostCargo(new DateTime(2017, 7, 07), new DateTime(2017, 7, 09), locMoscow, locRome, 2450.00, 769898456);
            var post2 = new PostCargo(new DateTime(2017, 7, 07), new DateTime(2017, 7, 09), locMoscow, locRome, 3875.00, 769898456);
            var post3 = new PostTransport(new DateTime(2017, 7, 10), new DateTime(2017, 7, 12), locKiev, locChisinau, 4100.00, 128978941);
            IPostType post4 = new PostCargo(new DateTime(2017, 7, 14), new DateTime(2017, 7, 12), locKiev, locBardar, 3800.00, 128978941);
          
            post1.AddToRepository(post1);
            post1.AddToRepository(post2);
            post3.AddToRepository(post3);

            #region EVENTS

            //// new users 

            //User user1 = new User("Stipanov", "Sergiu", 35);
            //User user2 = new User("Maracuta", "Andrei", 27);

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

            #endregion
            
            #region Stream
            ////save countries to file
            //string fileName = @"C:\Users\sergiu.stipanov\OneDrive\Materiale\files\Repository.txt";
            //Repository<Country> countryRepository = new Repository<Country>();

            //foreach (var c in countries)
            //{
            //    countryRepository.SaveToFile(c, fileName);
            //}
            #endregion
            
            FacadeClass facade1 = FacadeClass.Instance;
            facade1.CreatePost(true, post1);

            // tuple
            (string Alpha, string Beta, string Teta) namedLetters = ("a", "b", "c");

            #region FACTORY

            PostFactory postFactory = new PostFactory();
            var newPost = postFactory.CreateNewPost(new DateTime(2017, 07, 25), new DateTime(2017, 08, 05), locChisinau,
                locMoscow, 4750.00, 154568);
            Console.WriteLine(newPost.Description);

            #endregion

            Console.ReadKey();
        }
    }
}
