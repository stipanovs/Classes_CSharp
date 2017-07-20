﻿using System;
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
using System.Windows;

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
            List<Country> countries = Country.SetData();
            
            var moldova = countries[0];
            var italia = countries[1];
            var ucraina = countries[2];
            var russia = countries[3];

            
            
            // use Enums LocationType
            moldova.AddLocation("Chisinau", LocationType.City);
            moldova.AddLocation("Orhei", LocationType.Village);
            moldova.AddLocation("Cocieri", (LocationType)3);
            italia.AddLocation("Milano", LocationType.City);
            italia.AddLocation("Rimini", LocationType.City);
            italia.AddLocation("Rome", LocationType.City);
            ucraina.AddLocation("Kiev", LocationType.City);
            var moscow = new Location("Moscow", russia, LocationType.City);
            var seliste = new Location("Seliste", moldova, LocationType.Village);

            // ex. IEqualityComparer
            var dict = new Dictionary<Country, string>(new CountryEqalityComparer());
            // ex. Icomparer
            countries.Sort(new CountryComparer()); 
            

            // posting new information about Transport Freight 
            var post1 = new Posts(new DateTime(2017, 7, 10), new DateTime(2017, 7, 14), moldova, italia, 3700.00, 154565435);
            var post2 = new Posts(new DateTime(2017, 7, 07), new DateTime(2017, 7, 09), russia, moldova, 2450.00, 769898456);
            var post3 = new Posts(new DateTime(2017, 7, 10), new DateTime(2017, 7, 12), italia, ucraina, 4100.00, 128978941);
            
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
            
            Console.ReadLine();
        }
    }
}
