using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.Enums;
using Classes_CSharp.Repository;

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

        
        static void Main(string[] args)
        {
            List<Country> countries = Country.SetData();

            foreach (var country in countries)
            {
                Console.WriteLine(country.ToString());
            }

            var moldova = countries[0];
            var italia = countries[1];
            var ucraina = countries[2];
            var russia = countries[3];

            // dictionary
            Dictionary<Country, string> myCountries = new Dictionary<Country, string>(new CountryEqalityComparer());
                
            // cream dictinary din lista de tari existenta

            for (int i = 0; i < countries.Count; i++)
            {
                myCountries[countries[i]] = "key" + i.ToString();
            }
            // la tipar dict
            foreach (var kvp in myCountries)
            {
                Console.WriteLine(kvp.Key.Description + " " + kvp.Value);
            }

            // ex Insert List
            countries.Insert(0, new Country("Ungaria", 451, Region.EuropeUnion, "EUR"));

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
            
            // ex. IEqualityComparer
            var dict = new Dictionary<Country, string>(new CountryEqalityComparer());
            
            // ex. Icomparer
            countries.Sort(new CountryComparer()); 

            Console.WriteLine();

            foreach (var country in countries)
            {
                Console.WriteLine(country.ToString());
            }

            
            Console.WriteLine(countries[0].Description);


            var moscow = new Location("Moscow", russia, LocationType.City);
            var seliste = new Location("Seliste", moldova, LocationType.Village);


            // postarile de marfa
            var post1 = new Posts(new DateTime(2017, 7, 10), new DateTime(2017, 7, 14), moldova, italia, 3700.00);
            var post2 = new Posts(new DateTime(2017, 7, 07), new DateTime(2017, 7, 09), russia, moldova, 2450.00);
            
            Console.ReadLine();
        }
    }
}
