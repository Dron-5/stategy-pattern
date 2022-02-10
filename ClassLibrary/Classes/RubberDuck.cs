using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class RubberDuck : Duck, IQuackBehavior
    {
        public override string Display()
        {
            return "RubberDuck " + GetType();
        }
        public string Quack()
        {
            return "Quack " + this.GetType();
        }
    }
}
