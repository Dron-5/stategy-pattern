using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace stategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();
            RubberDuck rubberDuck = new RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();


            Duck[] ducks = new Duck[] { mallardDuck, redheadDuck, rubberDuck, decoyDuck };

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Display());
                Console.WriteLine(duck.Swim());

                if (duck is IQuackable)
                {
                    Console.WriteLine((duck as IQuackable).Quack());
                }
                if (duck is IFlyable)
                {
                    Console.WriteLine((duck as IFlyable).Fly());
                }
            }
            Console.ReadKey();
        }
    }
}
