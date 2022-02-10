using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;


namespace ClassLibrary
{
    protected IFlyBehavior flyBehavoir;
    protected IQuackBehavior quackBehavoir;
    public class Duck
    {

        public string Swim()
        {
            return "Бульк";
        }

        public string Display()
        {
          return $"{GetType()} | {flyBehavior.GetType()} | {quackBehavior.GetType()}";
        }
        public string Quack()
        {
            return quackBehavior.Quack();
        }
        public string Fly()
        {
            return flyBehavior.Fly();
        }
        public void SetQuckBehavior(IQuackBehavior.qBehavior)
        {
            quackBehavior = qBehavior;
        }
        public void SetFlyBehavoir(IFlyBehavior. fBehavior)
        {
            SetFlyBehavior = fBehavior;
        }
    }
}
