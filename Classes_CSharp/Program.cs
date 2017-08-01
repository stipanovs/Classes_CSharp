using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.DataLocation;
using Classes_CSharp.Repository;
using Classes_CSharp.Users;
using Classes_CSharp.Events;
using Classes_CSharp.Facade;
using Classes_CSharp.PostsModel;
using Classes_CSharp.PostsModel.SpecificationType;
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

            #region Location

            Location locChisinau = new Location(moldova, new City("Chisinau"), "str. Titulescu 10/4 ap 61");
            Location locBardar = new Location(moldova, new Village("Bardar"), "nu sunt strazi");
            Location locMoscow = new Location(russia, new City("Moscow"));
            Location locRome = new Location(italia, new Village("Padovana"));
            Location locKiev = new Location(country: ucraina, unitLocality: new City("Kiev"));

            #endregion

            #region PostData
            
            // posting new information about Transport Freight 
            var post1 = new PostCargo(new DateTime(2017, 7, 07), new DateTime(2017, 7, 09), locMoscow, locRome, 2450.00);
            var post2 = new PostCargo(new DateTime(2017, 7, 07), new DateTime(2017, 7, 09), locMoscow, locRome, 3875.00);
            var post3 = new PostTransport(new DateTime(2017, 7, 10), new DateTime(2017, 7, 12), locKiev, locChisinau, 4100.00);
            var post4 = new PostCargo(new DateTime(2017, 7, 14), new DateTime(2017, 7, 12), locKiev, locBardar, 3800.00);
            // named arg
            var post5 = new PostCargo(locationFrom: locChisinau, locationTo: locKiev,
                dataFrom: new DateTime(2017, 07, 20), dateTo: new DateTime(2017, 08, 02), price: 3500.00);
            #endregion

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
            //    WriteLine(c.Name);
            //}

            //Console.ReadKey();

            #endregion

            #region NameOf
            // Country name validate

            #endregion

            #region Comparer

            //// ex. IEqualityComparer
            //var dict = new Dictionary<Country, string>(new CountryEqalityComparer());
            //// ex. Icomparer
            //countries.Sort(new CountryComparer());


            #endregion

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

            //string fileName = @"C:\Users\sergiu.stipanov\OneDrive\Materiale\files\Repository.txt";
            //FileInfo f = new FileInfo(fileName);
            //StreamWriter sr = f.AppendText();
            //sr.WriteLine("hello");
            //sr.Close();
            //Console.WriteLine(sr);


            //Console.WriteLine();

            ////save countries to file

            //Repository<Country> countryRepository = new Repository<Country>();

            //foreach (var c in countries)
            //{
            //    countryRepository.SaveToFile(c, fileName);
            //}
            #endregion
            
            #region Facade

           UserFacade userFacade = UserFacade.Instance;
            userFacade.CreatePost(post1);

            userFacade.CreatePost(
                new DateTime(2017, 07, 25), new DateTime(2017, 08, 04),
                locChisinau, locKiev, 1500.00,
                1241564, "call Vasea", new CargoSpecification("Water Mineral", 20.00, 25.00));

            #endregion
            
            #region Tuple
            //// tuple
            //(string Alpha, string Beta, string Gama) namedLetters = ("a", "b", "c");

            #endregion

            #region FACTORY
            PostFactory postFactory = new PostFactory();

            var beerCargoSpecification = new CargoSpecification("Karlsberg Beer", 7.5, 3.7);
            var woodCargoSpecification = new CargoSpecification("Wood", 15.45, 27.00);
            var truckSpecification = new TransportSpecification(TransportType.Truck, 20.00, 35.00);
            var minibusSpecification = new TransportSpecification(TransportType.Minibus, 6.00, 7.8);
            
            var newPostCargo = postFactory.CreateNewPost(
                new DateTime(2017, 07, 25), new DateTime(2017, 08, 05), locRome,
                locChisinau, 4750.00, "Call 373 6544518", beerCargoSpecification);

            Console.WriteLine(newPostCargo.Description);
            WriteLine(newPostCargo is PostCargo);

            var newPostTransport = postFactory.CreateNewPost(new DateTime(2017, 07, 08), new DateTime(2017, 08, 31), locMoscow,
                locChisinau, 1875.00, "For more information Call +3739547821", truckSpecification);

            
            Console.WriteLine(newPostTransport);
            Console.WriteLine(newPostTransport is PostCargo);

            #endregion

            #region Dictionary

            //var posts = new Dictionary<string, Post>()
            //{
            //    ["post1"] = post1,
            //    ["post2"] = post2,
            //    ["post3"] = post3,
            //    ["post4"] = post4,
            //    ["post4"] = post1,

            //};

            //Console.WriteLine($" ====== {posts["post4"]}");
            ////posts["post4"] = post4;

            #endregion

            #region Null Conditional Operator

            //Country morocco = null;
            //WriteLine(morocco?.Name ?? "Field is null");

            #endregion

            #region ExceptionFilters

            //string httpStatusCode = "401";

            //try
            //{
            //    throw new Exception(httpStatusCode);
            //}
            //catch (Exception ex) when (ex.Message.Equals("400"))
            //{
            //    Write("Bad Request");
            //}
            //catch (Exception ex) when (ex.Message.Equals("401"))
            //{
            //    Write("Unauthorized");
            //}
            //catch (Exception ex) when (ex.Message.Equals("402"))
            //{
            //    Write("Payment Required");
            //}
            //catch (Exception ex) when (ex.Message.Equals("403"))
            //{
            //    Write("Forbidden");
            //}
            //catch (Exception ex) when (ex.Message.Equals("404"))
            //{
            //    Write("Not Found");
            //}


            #endregion

            #region out var

            //if (int.TryParse("000457", out int result))
            //    WriteLine(result);
            //else
            //    WriteLine("Could not parse input");


            #endregion

            #region Ref locals 

            //ref int Find(int number, int[] numbers)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] == number)
            //        {
            //            return ref numbers[i]; // we return reference, not value
            //        }
            //    }
            //    throw new IndexOutOfRangeException("Number is not found");
            //}

            //int[] listNum = { 4, 6, 9, 4, 7, 12 };
            //ref int numRef = ref Find(7, listNum);
            //WriteLine(numRef);
            //numRef = 55;
            //WriteLine(listNum[4]);


            #endregion

            #region Cast convertion

            //A a = new A();
            //B b = (B)a;
            //WriteLine(b?.ToString() ?? "b is null");

            //a = new C();
            //WriteLine(a is A);
            //WriteLine(a is B);
            //WriteLine(a is C);
            //WriteLine(a is D);


            #endregion
            
            Console.ReadKey();
        }
   }
    
    //class A{}
    //class B : A{}
    //class C : B { }
    //class D : A { }
}
