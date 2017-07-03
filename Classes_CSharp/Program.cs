using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Legs
    {
        public int LesgNr { get; private set; }

        public Legs(int legs)
        {
            LesgNr = legs;
        }
    }
    public class Animal
    {
        private string _name;
        public readonly int _legs = 4;
        public const int mouth = 1;
        public int Age { get; private set; }

        public Animal(string name, int age)
        {
            _name = name;
            Age = age;
            _legs += 1;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Legs legs_for_dog = new Legs(4);
            Animal dog = new Animal("Bonny", 2);
            int legs_dog = dog._legs;
            
            Console.WriteLine(dog._legs);
            Console.ReadLine();
        }
    }
}
