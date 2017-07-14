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
        public static void SwapItemsByIndex<T>(List<T> list, int indexA, int indexB)
        {
            T temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
        }

        public static void SwapItemsByItems<T>(List<T> list, T item1, T item2)
        {
            T temp = item1;
            int tempIndex = list.IndexOf(item2);
            list[list.IndexOf(item1)] = item2;
            list[tempIndex] = temp;
        }

        public static void TextCountryToPrint(out string str, Country country)
        {
            str = country.ToString();
        }

        
        static void Main(string[] args)
        {
            List<Country> countries = Country.SetData();
            
            var moldova = countries[0];
            var italia = countries[1];
            var ucraina = countries[2];
            var russia = countries[3];

            
            // swap
            SwapItemsByIndex<Country>(countries, 1, 3);
            SwapItemsByItems<Country>(countries, moldova, ucraina);

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
            
            // new users 
            User user1 = new User("Stipanov", "Sergiu", 35);
            User user2 = new User("Maracuta", "Andrei", 27);
            
            // subscribe to event price reduced
            user1.RegisterToEvent(post1);
            user2.RegisterToEvent(post1);

            //Register weak events by WeakEventManager
            user1.RegisterToEventWeakMethod(post2); 
            user1.RegisterToEventWeakMethod(post3);

            // simulate change price
            post1.Price = 3550.00;
            post2.Price = 2300;
            Console.WriteLine();

            // UnregisterToEvent
            user2.UnregisterToEvent(post1);
            user1.UnregisterToEventWeakMethod(post3);

            post1.Price = 3450;

            
            // CustomList
            
            CustomList<Country> customCountry = new CustomList<Country>();
            customCountry.Add(moldova);
            customCountry.Add(italia);
            customCountry.Add(russia);
            customCountry.Add(ucraina);
            
            
            // method out
            string textToPrint;
            TextCountryToPrint(out textToPrint, moldova);
            //Console.WriteLine("textToPrint(out): " + textToPrint);
            // method out
            Console.ReadLine();
        }
    }
}
