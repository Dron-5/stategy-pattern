using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();


            Duck[] ducks = new Duck[] { mallardDuck, redheadDuck };

            foreach (var x in ducks)
            {
                Console.WriteLine(x.Display());
                Console.WriteLine(x.Quack());
                Console.WriteLine(x.Swim());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
