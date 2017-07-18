using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class Program
    {
        class A
        {
            public static int i;

           public A()
            {
                Console.WriteLine("Default");
                i++;
            }

            static A()
            {
                i++;
                Console.WriteLine("static");
            }

            public void IShow()
            {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {
            var obj = new A();
            obj.IShow();

        }
    }
}
